using Lab3.View;
using Lab3.Views;
using System;
using System.Windows.Forms;

namespace Lab3.Presenters
{
    class EditOrderPresenter : IPresenter
    {
        public bool hasChanges;
        private bool saved;
        private bool wantToSave;
        private int index;
        public Order order;
        private IPresenter _context;
        private EditOrderForm _view;
        

        public EditOrderPresenter(EditOrderForm view, IPresenter context, object order)
        {
            this.order = (Order)((Order)order).Clone();
            _view = view;
            _context = context;

            _view.Dishes.Items.Clear();
            foreach (var item in this.order.Dishes)
            {
                _view.Dishes.Items.Add(item);
            }

            _view.cafeNameTextBox.Text = this.order.cafeName;
            _view.saveOrderButton.Click += SaveOrderButton_Click;
            _view.removeDishButton.Click += RemoveDishButton_Click;
            _view.createDishButton.Click += new System.EventHandler(this.createDishButton_Click);
            _view.cafeNameTextBox.Validating += CafeNameTextBox_Validating;
            _view.removeDishButton.Click += RemoveDishButton_Click;

            this.order.Dishes.CollectionChanged += Dishes_CollectionChanged;
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
                hasChanges = true;
            }
        }
        #endregion
        private void Dishes_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            _view.Dishes.Items.Clear();
            foreach (var item in order.Dishes)
            {
                _view.Dishes.Items.Add(item);
            }
            hasChanges = true;
            CheckDishes();
        }
        #region Form events
        private void _view_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hasChanges && !saved && _view.ValidateChildren())
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
                order.Dishes.RemoveAt(_view.Dishes.SelectedIndex);
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
                order.cafeName = _view.cafeNameTextBox.Text;
                order.createOrderTime = _view.dateTimePicker1.Value;
                (_context as MainFormPresenter).Orders[index] = order;
                saved = true;
            }
        }
        public void Run()
        {
            _view.ShowDialog();
        }
    }
}
