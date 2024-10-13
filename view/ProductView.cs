using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.view
{
    public partial class ProductView : Form,IProductView
    {
        private bool isSuccessful;
        private bool isEdit;

        public ProductView()
        {
            InitializeComponent();
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler EditEvent;


        public void SetProductListBildingSource(BindingSource ProductList)
        {
            dataGridView1.DataSource = ProductList;
        }
        public string ProductId
        {
            get { return TxtId.Text; }
            set { TxtId.Text = value; }
        }
        public string ProductPrice
        {
            get { return TxtPrice.Text; }
            set { TxtPrice.Text = value; }
        }
        public string ProductStock
        {
            get { return Txt.Text; }
            set { TxtSearch.Text = value; }
        }
        public string ProductCategoria
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }

        }

        public string message { get; private set; }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ProductView_Load(object sender, EventArgs e)
        {

        }
    }
}
