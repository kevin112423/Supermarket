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
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;

        public string PayModeId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PayModeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PayModeObservation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PayModeView()
        {
            InitializeComponent();
            AssociativeAndRaiseViewEvents();

            tabControl1.TabPages.Remove(PagePayModeDetail);

            BtnCerrar.Click += delegate { this.Close(); };
        }

        private void AssociativeAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty);};

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnNew.Click += delegate 
            {
                AddNewEvent?.Invoke(this,EventArgs.Empty);

                tabControl1.TabPages.Remove(PagePayModeList);
                tabControl1.TabPages.Add(PagePayModeDetail);
                PagePayModeDetail.Text = "Add New Pay Mode";
            };

            BtnEdit.Click +=delegate 
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(PagePayModeList);
                tabControl1.TabPages.Add(PagePayModeDetail);
                PagePayModeDetail.Text = "Edit Pay Mode";

            };
            BtnDelete.Click += delegate
            {
                
                var result = MessageBox.Show("are you sure you want  to delete the selected pay mode",
                             "Warning",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            BtnSave.Click += delegate 
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(PagePayModeList);
                    tabControl1.TabPages.Add(PagePayModeDetail);
                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate 
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(PagePayModeList);
                tabControl1.TabPages.Add(PagePayModeDetail);

            };
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler EditEvent;

        private void PagePayModeList_Click(object sender, EventArgs e)
        {

        }

        private void PagePayModeList_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PagePayModeDetail_Click(object sender, EventArgs e)
        {

        }

        private void PayModeView_Load(object sender, EventArgs e)
        {

        }

        public void SetPayModeListBildingSource(BindingSource PayModeList)
        {
            dataGridView1.DataSource = PayModeList;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private static PayModeView instance;

        public static PayModeView GetInstance(Form  parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
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
    }
}
