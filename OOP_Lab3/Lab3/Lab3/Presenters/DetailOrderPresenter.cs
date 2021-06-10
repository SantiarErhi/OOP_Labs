using Lab3.Views;
using System;
namespace Lab3.Presenters
{
    class DetailOrderPresenter : IPresenter
    {
        private DetailOrderView _view;
        private Order order;
        public DetailOrderPresenter(DetailOrderView view, object order)
        {
            _view = view;
            this.order = order as Order;
            foreach (var item in this.order.Dishes)
            {
                _view.Dishes.Items.Add(item);
            }
            _view.cafeNameLabel.Text = this.order.cafeName;
            _view.orderDateLabel.Text = this.order.createOrderTime.ToString();

            _view.Dishes.SelectedIndexChanged += Dishes_SelectedIndexChanged;
        }

        private void Dishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _view.dishNameLabel.Text = order.Dishes[_view.Dishes.SelectedIndex].name;
            _view.costLabel.Text = order.Dishes[_view.Dishes.SelectedIndex].cost.ToString();
            _view.categoriesLabel.Text = order.Dishes[_view.Dishes.SelectedIndex].categories.ToString();
            _view.cookNameAndSurnameLabel.Text = order.Dishes[_view.Dishes.SelectedIndex].cook.ToString();

        }

        public void Run()
        {
            _view.ShowDialog();
        }
    }
}
