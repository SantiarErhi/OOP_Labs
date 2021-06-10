using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Lab3.Presenters
{
    class MainFormPresenter : IPresenter
    {
        private MainForm _view;
        private ObservableCollection<Order> _orders;
        public ObservableCollection<Order> Orders
        { 
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
            }
        }


        public MainFormPresenter(MainForm view)
        {
            _view = view;
            _orders = new ObservableCollection<Order>();

            _view.createOrderButton.Click += new System.EventHandler(createOrderButton_Click);
            _view.editOrderButton.Click += new System.EventHandler(editOrderButton_Click);
            _view.Load += new System.EventHandler(MainForm_Load);
            _view.removeOrderButton.Click += new System.EventHandler(removeOrderButton_Click);
            _view.detailViewButton.Click += new System.EventHandler(detailViewButton_Click);
            _view.saveFileButton.Click += new System.EventHandler(saveFileButton_Click);
            _view.openFileButton.Click += new System.EventHandler(openFileButton_Click);

            _orders.CollectionChanged += _orders_CollectionChanged;
        }

        private void _orders_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            _view.Orders.Items.Clear();
            foreach(var item in _orders)
            {
                _view.Orders.Items.Add(item);
            }
            CheckOrders();
        }
        #region Form events
        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "(*.ocf)|*.ocf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var repository = new Models.OrdersRepository();
                        Orders = repository.LoadFrom(openFileDialog.FileName);
                        _view.Orders.Items.Clear();
                        foreach (var item in _orders)
                        {
                            _view.Orders.Items.Add(item);
                        }
                        _orders.CollectionChanged += _orders_CollectionChanged;
                        CheckOrders();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Corrupted data");
                    }

                }
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                openFileDialog.AddExtension = true;
                openFileDialog.DefaultExt = ".ocf";
                openFileDialog.Filter = "(*.ocf)|*.ocf";
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var repository = new Models.OrdersRepository();
                    repository.SaveTo(_orders, openFileDialog.FileName);
                }
            }
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            var presenter = new MakeOrderPresenter(new View.MakeOrderForm(), this);
            presenter.Run();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckOrders();
        }

        private void detailViewButton_Click(object sender, EventArgs e)
        {
            if (_view.Orders.SelectedItem != null)
            {
                var presenter = new DetailOrderPresenter(new Views.DetailOrderView(), _view.Orders.SelectedItem);
                presenter.Run();
            }
        }

        private void editOrderButton_Click(object sender, EventArgs e)
        {
            if (_view.Orders.SelectedItem != null)
            {
                var presenter = new EditOrderPresenter(new Views.EditOrderForm(), this, _view.Orders.SelectedItem);
                presenter.Run();
            }
        }

        private void removeOrderButton_Click(object sender, EventArgs e)
        {
            if (_view.Orders.SelectedItem != null)
            {
                Orders.RemoveAt(_view.Orders.SelectedIndex);
            }
        }
        #endregion
        private void CheckOrders()
        {
            if (_view.Orders.Items.Count == 0)
                _view.removeOrderButton.Enabled = false;
            else
                _view.removeOrderButton.Enabled = true;
        }
        public void Run()
        {
            Application.Run(_view);
        }
    }
}
