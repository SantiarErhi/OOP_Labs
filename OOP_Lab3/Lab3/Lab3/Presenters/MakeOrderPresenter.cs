using Lab3.View;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Lab3.Presenters
{
    class MakeOrderPresenter : IPresenter
    {
        private bool saved;
        private bool wantToSave;

        private MakeOrderForm _view;
        private IPresenter _context;
        public ObservableCollection<Dish> dishes;

        public MakeOrderPresenter(MakeOrderForm view, IPresenter context)
        {
            dishes = new ObservableCollection<Dish>();
            _view = view;
            _context = context;

            _view.saveOrderButton.Click += SaveOrderButton_Click;
            _view.removeDishButton.Click += RemoveDishButton_Click;
            _view.createDishButton.Click += new System.EventHandler(this.createDishButton_Click);

            _view.cafeNameTextBox.Validating += CafeNameTextBox_Validating;
            _view.removeDishButton.Click += RemoveDishButton_Click;

            dishes.CollectionChanged += Dishes_CollectionChanged;
            _view.Dishes.Validating += Dishes_Validating;
            _view.FormClosing += _view_FormClosing;

            CheckDishes();
        }

        #region Validating
        private void Dishes_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_view.Dishes.Items.Count == 0)
            {
                e.Cancel = true;
                _view.Dishes.Focus();
                _view.errorProvider.SetError(_view.Dishes, "List must have bigger than 0 elements");
            }
            else
            {
                e.Cancel = false;
                _view.errorProvider.SetError(_view.Dishes, null);
            }

        }
        private void CafeNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(_view.cafeNameTextBox.Text))
            {
                e.Cancel = true;
                _view.cafeNameTextBox.Focus();
                _view.errorProvider.SetError(_view.cafeNameTextBox, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                _view.errorProvider.SetError(_view.cafeNameTextBox, null);
            }
        }
        #endregion
        private void Dishes_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            _view.Dishes.Items.Clear();
            foreach (var item in dishes)
            {
                _view.Dishes.Items.Add(item);
            }
            CheckDishes();
        }

        #region Form events
        private void _view_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved && _view.ValidateChildren())
            {
                DialogResult dr = MessageBox.Show("Are you want to save result?",
                          "Save", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        wantToSave = true;
                        Save();

                        break;
                    case DialogResult.No:
                        wantToSave = false;
                        break;
                }
                if (!saved && wantToSave)
                    e.Cancel = true;
                else
                    e.Cancel = false;
                if (saved && wantToSave)
                    e.Cancel = false;
            }
        }

       

        private void RemoveDishButton_Click(object sender, EventArgs e)
        {
            if (_view.Dishes.SelectedItem != null)
            {
                dishes.RemoveAt(_view.Dishes.SelectedIndex);
            }
        } 

        private void SaveOrderButton_Click(object sender, EventArgs e)
        {
            if (_view.ValidateChildren())
            {
                Save();
                _view.Close();

            }
        }

        private void createDishButton_Click(object sender, EventArgs e)
        {
            var presenter = new CreateDishPresenter(new CreateDishForm(), this);
            presenter.Run();
        }
        #endregion
        private void CheckDishes()
        {
            if (_view.Dishes.Items.Count == 0)
                _view.removeDishButton.Enabled = false;
            else
                _view.removeDishButton.Enabled = true;

        }
        private void Save()
        {
            if (_view.ValidateChildren())
            {
                (_context as MainFormPresenter).Orders.Add(new Order(_view.dateTimePicker1.Value, _view.cafeNameTextBox.Text, dishes));
                saved = true;
            }
        }

        public void Run()
        {
            _view.ShowDialog();
        }

    }

}
