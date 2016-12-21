using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();
        private decimal storeProfit = 0;

        public ConsignmentShop()
        {
            InitializeComponent();
            SetUpData();

            itemsBinding.DataSource = store.Items.Where(x=> x.Sold == false).ToList();
            itemsListbox.DataSource = itemsBinding;

            //Gives Listbox something to display
            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";

            vendorBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorBinding;

            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";
        }

        private void SetUpData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Mike", LastName = "Pence" });
            store.Vendors.Add(new Vendor { FirstName = "Exxon", LastName = "Mobil", });

            store.Items.Add(new Item
            {
                Title = "Racing Yacht",
                Description = "A Yuge Boat",
                Price = 450.000M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Penthouse Suite",
                Description = "A Yuge Apartment",
                Price = 380.000M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Private Jet",
                Description = "For Flying to China",
                Price = 520.000M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Yuge Wall",
                Description = "A Yuge Wall",
                Price = 150.000M,
                Owner = store.Vendors[0]
            });

            store.Name = "Trump Change";
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            /*
             Figtures out what is selected from items list
             and copies that item to the shopping cart
             */
            Item selectedItem = (Item)itemsListbox.SelectedItem;

            shoppingCartData.Add(selectedItem);

            //Tells bindings to refresh
            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            /*
              Marks each item as sold
              clears the cart
              then resets bindings
             */
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission * item.Price);
            }

            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValue.Text = string.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorBinding.ResetBindings(false);
        }

        private void ConsignmentShop_Load(object sender, EventArgs e)
        {

        }

        private void storeProfitValue_Click(object sender, EventArgs e)
        {

        }
    }
}
