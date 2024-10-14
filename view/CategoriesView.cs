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
    public partial class CategoriesView : Form,ICategoriesView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public CategoriesView()
        {
            InitializeComponent();
            AssociativeAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabCategoriesDetail);
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

        public void SetCategoriesListBildingSource(BindingSource CategoriesList)
        {
           dataGridView1.DataSource = CategoriesList;

            tabControl1.TabPages.Remove(tabCategoriesDetail);
            BtnCerrar.Click += delegate { this.Close(); };

        }
        private static CategoriesView instance;

        public static CategoriesView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoriesView();
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
        public string CategoriesId
        {
            get { return TxtId.Text; }
            set { TxtId.Text = value; }
        }

        public string CategoriesName
        {
            get { return TxtName.Text; }
            set { TxtName.Text = value; }
        }

        public string CategoriesDescription
        {
            get { return TxtDescription.Text; }
            set { TxtDescription.Text = value; }
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


        private void CategoriesView_Load(object sender, EventArgs e)
        {

        }

    }
}
