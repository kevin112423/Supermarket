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
    public partial class CustomersView : Form, ICustomersView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public CustomersView()
        {
            InitializeComponent();
            AssociativeAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabProductDetail);

            BtnCerrar.Click += delegate { this.Close(); };
        }

        private void AssociativeAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler EditEvent;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ProductView_Load(object sender, EventArgs e)
        {

        }

        public void SetCustomersListBildingSource(BindingSource CustomersList)
        {
            dataGridView1.DataSource = CustomersList;
        }

        private static CustomersView instance;
        public static CustomersView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomersView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
        public string CustomersId
        {
            get { return TxtId.Text; }
            set { TxtId.Text = value; }
        }
        public string CustomersFirt_name
        {
            get { return TxtFirtName.Text; }
            set { TxtFirtName.Text = value; }
        }
        public string CustomersLast_name
        {
            get { return TxtLastName.Text; }
            set { TxtLastName.Text = value; }
        }
        public string CustomersDocument
        {
            get { return TxtDocumento.Text; }
            set { TxtDocumento.Text = value; }
        }
        public string CustomersAddress
        {
            get { return TxtAddress.Text; }
            set { TxtAddress.Text = value; }
        }
        public string CustomersBithrday
        {
            get { return TxtBirthday.Text; }
            set { TxtBirthday.Text = value; }
        }
        public string CustomersPhone
        {
            get { return TxtPhone.Text; }
            set { TxtAddress.Text = value; }
        }
        public string CustomersEmail
        {
            get { return TxtEmail.Text; }
            set { TxtEmail.Text = value; }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
