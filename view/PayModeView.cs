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
    }
}
