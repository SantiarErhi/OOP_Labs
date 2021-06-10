using Lab3.View;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace Lab3.Presenters
{
    class CreateDishPresenter : IPresenter
    {
        private CreateDishForm _view;
        private IPresenter _context;
        private bool saved;
        private bool wantToSave;
        
        public CreateDishPresenter(CreateDishForm view, IPresenter context)
        {
            saved = false;
            _view = view;
            _context = context;

            Array values = Enum.GetValues(typeof(Categories));
            foreach(var value in values)
            {
                _view.CategoriesComboBox.Items.Add(value);
            }

            _view.FormClosing += new FormClosingEventHandler(this.CreateDishForm_FormClosing);
            _view.saveButton.Click += SaveButton_Click;
            _view.nameTextBox.Validating += NameTextBox_Validating;
            _view.cookName.Validating += CookName_Validating;
            _view.cookSurname.Validating += CookSurname_Validating;
            _view.CategoriesComboBox.Validating += CategoriesComboBox_Validating;

        }
        #region Validating
        private void CategoriesComboBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (!Enum.GetNames(typeof(Categories)).Contains(_view.CategoriesComboBox.Text))
            {

                e.Cancel = true;
                _view.CategoriesComboBox.Focus();
                _view.errorProvider.SetError(_view.CategoriesComboBox, "File is missing in list");
            }
            else
            {
                e.Cancel = false;
                _view.errorProvider.SetError(_view.CategoriesComboBox, null);
            }
        }

        private void CookSurname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.cookSurname.Text))
            {
                e.Cancel = true;
                _view.cookSurname.Focus();
                _view.errorProvider.SetError(_view.cookSurname, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                _view.errorProvider.SetError(_view.cookSurname, null);
            }
        }

        private void CookName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.cookName.Text))
            {
                e.Cancel = true;
                _view.cookName.Focus();
                _view.errorProvider.SetError(_view.cookName, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                _view.errorProvider.SetError(_view.cookName, null);
            }
        }

        private void NameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.nameTextBox.Text))
            {
                e.Cancel = true;
                _view.nameTextBox.Focus();
                _view.errorProvider.SetError(_view.nameTextBox, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                _view.errorProvider.SetError(_view.nameTextBox, null);
            }
        }
        #endregion

        #region Form events
       
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                _view.Close();
            }
        }
        
        private void CreateDishForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved && _view.ValidateChildren())
            {
                DialogResult dr = MessageBox.Show("Are you want to save result?",
                          "Savet", MessageBoxButtons.YesNo);
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
        #endregion
        private bool Save()
        {
            if (!_view.ValidateChildren()) return saved;

            var name = _view.nameTextBox.Text;
            int cost = (int)_view.cost.Value;
            int time = (int)_view.waititngTime.Value;
            Cook cook = new Cook(_view.cookName.Text, _view.cookSurname.Text);
            if (_context is MakeOrderPresenter)
            {
                (_context as MakeOrderPresenter).dishes.Add(new Dish(name, cost, time, cook, (Categories)_view.CategoriesComboBox.SelectedIndex));
            }
            else if (_context is EditOrderPresenter)
            {
                (_context as EditOrderPresenter).order.Add(new Dish(name, cost, time, cook, (Categories)_view.CategoriesComboBox.SelectedIndex));
            }
            saved = true;
            return saved;
        }

        public void Run()
        {
            _view.ShowDialog();
        }
    }
}
