namespace Supermarket_mvp.view
{
    partial class ProductView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabCustomersList = new TabPage();
            BtnCerrar = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            tabCustomersDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtStock = new TextBox();
            label6 = new Label();
            TxtPrice = new TextBox();
            label5 = new Label();
            TxtName = new TextBox();
            label4 = new Label();
            TxtId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabCustomersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 110);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.agregar_producto;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(25, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 94);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(186, 29);
            label1.Name = "label1";
            label1.Size = new Size(109, 37);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCustomersList);
            tabControl1.Controls.Add(tabCustomersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 110);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(999, 382);
            tabControl1.TabIndex = 1;
            // 
            // tabCustomersList
            // 
            tabCustomersList.Controls.Add(BtnCerrar);
            tabCustomersList.Controls.Add(BtnDelete);
            tabCustomersList.Controls.Add(BtnEdit);
            tabCustomersList.Controls.Add(BtnNew);
            tabCustomersList.Controls.Add(dataGridView1);
            tabCustomersList.Controls.Add(label2);
            tabCustomersList.Controls.Add(BtnSearch);
            tabCustomersList.Controls.Add(TxtSearch);
            tabCustomersList.Location = new Point(4, 24);
            tabCustomersList.Name = "tabCustomersList";
            tabCustomersList.Padding = new Padding(3);
            tabCustomersList.Size = new Size(991, 354);
            tabCustomersList.TabIndex = 0;
            tabCustomersList.Text = "Prudoct List";
            tabCustomersList.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Image = Properties.Resources.cerrar;
            BtnCerrar.Location = new Point(801, 254);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(170, 52);
            BtnCerrar.TabIndex = 7;
            BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(801, 196);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(170, 52);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(801, 123);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(170, 52);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(801, 54);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(170, 52);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(528, 263);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 19);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Product";
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(326, 28);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(37, 43);
            BtnSearch.TabIndex = 1;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(34, 39);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(286, 23);
            TxtSearch.TabIndex = 0;
            // 
            // tabCustomersDetail
            // 
            tabCustomersDetail.Controls.Add(BtnCancel);
            tabCustomersDetail.Controls.Add(BtnSave);
            tabCustomersDetail.Controls.Add(TxtStock);
            tabCustomersDetail.Controls.Add(label6);
            tabCustomersDetail.Controls.Add(TxtPrice);
            tabCustomersDetail.Controls.Add(label5);
            tabCustomersDetail.Controls.Add(TxtName);
            tabCustomersDetail.Controls.Add(label4);
            tabCustomersDetail.Controls.Add(TxtId);
            tabCustomersDetail.Controls.Add(label3);
            tabCustomersDetail.Location = new Point(4, 24);
            tabCustomersDetail.Name = "tabCustomersDetail";
            tabCustomersDetail.Padding = new Padding(3);
            tabCustomersDetail.Size = new Size(792, 348);
            tabCustomersDetail.TabIndex = 1;
            tabCustomersDetail.Text = "Product detail";
            tabCustomersDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(618, 41);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(111, 53);
            BtnCancel.TabIndex = 11;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(618, 130);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(111, 53);
            BtnSave.TabIndex = 10;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtStock
            // 
            TxtStock.Location = new Point(287, 160);
            TxtStock.Name = "TxtStock";
            TxtStock.Size = new Size(191, 23);
            TxtStock.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 142);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 6;
            label6.Text = "Product Stock";
            label6.Click += label6_Click;
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(36, 160);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(191, 23);
            TxtPrice.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 142);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 4;
            label5.Text = "Product Price";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(287, 57);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(191, 23);
            TxtName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 38);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 2;
            label4.Text = "Product Name";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(32, 57);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(191, 23);
            TxtId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 39);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Product Id";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 492);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            Load += ProductView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabCustomersList.ResumeLayout(false);
            tabCustomersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabCustomersDetail.ResumeLayout(false);
            tabCustomersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabCustomersList;
        private TabPage tabCustomersDetail;
        private Label label2;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Button BtnCerrar;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView dataGridView1;
        private TextBox TxtName;
        private Label label4;
        private TextBox TxtId;
        private Label label3;
        private Label label6;
        private TextBox TxtPrice;
        private Label label5;
        private TextBox TxtStock;
        private Button BtnCancel;
        private Button BtnSave;
    }
}