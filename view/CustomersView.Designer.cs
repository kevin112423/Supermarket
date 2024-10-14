namespace Supermarket_mvp.view
{
    partial class CustomersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabProductList = new TabPage();
            BtnCerrar = new Button();
            BtnDelete = new Button();
            BtnNew = new Button();
            BtnEdit = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            tabProductDetail = new TabPage();
            label10 = new Label();
            TxtBirthday = new TextBox();
            label9 = new Label();
            TxtDocumento = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            label8 = new Label();
            TxtEmail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TxtPhone = new TextBox();
            TxtAddress = new TextBox();
            TxtLastName = new TextBox();
            TxtFirtName = new TextBox();
            TxtId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 124);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(184, 39);
            label1.Name = "label1";
            label1.Size = new Size(211, 54);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProductList);
            tabControl1.Controls.Add(tabProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 124);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1138, 396);
            tabControl1.TabIndex = 1;
            // 
            // tabProductList
            // 
            tabProductList.Controls.Add(BtnCerrar);
            tabProductList.Controls.Add(BtnDelete);
            tabProductList.Controls.Add(BtnNew);
            tabProductList.Controls.Add(BtnEdit);
            tabProductList.Controls.Add(dataGridView1);
            tabProductList.Controls.Add(label2);
            tabProductList.Controls.Add(BtnSearch);
            tabProductList.Controls.Add(TxtSearch);
            tabProductList.Location = new Point(4, 24);
            tabProductList.Name = "tabProductList";
            tabProductList.Padding = new Padding(3);
            tabProductList.Size = new Size(1130, 368);
            tabProductList.TabIndex = 0;
            tabProductList.Text = "CUstomers List";
            tabProductList.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Image = Properties.Resources.cerrar;
            BtnCerrar.Location = new Point(965, 276);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(140, 45);
            BtnCerrar.TabIndex = 7;
            BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(965, 208);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(140, 45);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(965, 77);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(140, 45);
            BtnNew.TabIndex = 5;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(965, 140);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(140, 45);
            BtnEdit.TabIndex = 4;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(907, 257);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 16);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Customers";
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(364, 32);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(56, 41);
            BtnSearch.TabIndex = 1;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(25, 42);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(333, 23);
            TxtSearch.TabIndex = 0;
            // 
            // tabProductDetail
            // 
            tabProductDetail.Controls.Add(label10);
            tabProductDetail.Controls.Add(TxtBirthday);
            tabProductDetail.Controls.Add(label9);
            tabProductDetail.Controls.Add(TxtDocumento);
            tabProductDetail.Controls.Add(BtnCancel);
            tabProductDetail.Controls.Add(BtnSave);
            tabProductDetail.Controls.Add(label8);
            tabProductDetail.Controls.Add(TxtEmail);
            tabProductDetail.Controls.Add(label7);
            tabProductDetail.Controls.Add(label6);
            tabProductDetail.Controls.Add(label5);
            tabProductDetail.Controls.Add(label4);
            tabProductDetail.Controls.Add(label3);
            tabProductDetail.Controls.Add(TxtPhone);
            tabProductDetail.Controls.Add(TxtAddress);
            tabProductDetail.Controls.Add(TxtLastName);
            tabProductDetail.Controls.Add(TxtFirtName);
            tabProductDetail.Controls.Add(TxtId);
            tabProductDetail.Location = new Point(4, 24);
            tabProductDetail.Name = "tabProductDetail";
            tabProductDetail.Padding = new Padding(3);
            tabProductDetail.Size = new Size(1003, 368);
            tabProductDetail.TabIndex = 1;
            tabProductDetail.Text = "Customrs Detail";
            tabProductDetail.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(484, 200);
            label10.Name = "label10";
            label10.Size = new Size(114, 15);
            label10.TabIndex = 17;
            label10.Text = "Customers  Bithrday";
            // 
            // TxtBirthday
            // 
            TxtBirthday.Location = new Point(484, 218);
            TxtBirthday.Name = "TxtBirthday";
            TxtBirthday.Size = new Size(218, 23);
            TxtBirthday.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(200, 200);
            label9.Name = "label9";
            label9.Size = new Size(130, 15);
            label9.TabIndex = 15;
            label9.Text = "Customers Documento";
            label9.Click += label9_Click;
            // 
            // TxtDocumento
            // 
            TxtDocumento.Location = new Point(200, 218);
            TxtDocumento.Name = "TxtDocumento";
            TxtDocumento.Size = new Size(218, 23);
            TxtDocumento.TabIndex = 14;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(493, 266);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(170, 73);
            BtnCancel.TabIndex = 13;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(237, 266);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(154, 72);
            BtnSave.TabIndex = 12;
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += button6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(484, 146);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 11;
            label8.Text = "Customers Email";
            label8.Click += label8_Click;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(484, 164);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(218, 23);
            TxtEmail.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(484, 22);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 9;
            label7.Text = "Customers Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 82);
            label6.Name = "label6";
            label6.Size = new Size(148, 15);
            label6.TabIndex = 8;
            label6.Text = "Customers Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 146);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 7;
            label5.Text = "Customers Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 82);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 6;
            label4.Text = "Customers firt Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 22);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 5;
            label3.Text = "Customers Id";
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(484, 100);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(218, 23);
            TxtPhone.TabIndex = 4;
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(484, 40);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(218, 23);
            TxtAddress.TabIndex = 3;
            // 
            // TxtLastName
            // 
            TxtLastName.Location = new Point(200, 164);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(218, 23);
            TxtLastName.TabIndex = 2;
            // 
            // TxtFirtName
            // 
            TxtFirtName.Location = new Point(200, 100);
            TxtFirtName.Name = "TxtFirtName";
            TxtFirtName.Size = new Size(218, 23);
            TxtFirtName.TabIndex = 1;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(200, 40);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(218, 23);
            TxtId.TabIndex = 0;
            // 
            // CustomersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 520);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomersView";
            Text = "Customers Mannager";
            Load += ProductView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabProductList.ResumeLayout(false);
            tabProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabProductDetail.ResumeLayout(false);
            tabProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabProductList;
        private TabPage tabProductDetail;
        private Label label2;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Button BtnCerrar;
        private Button BtnDelete;
        private Button BtnNew;
        private Button BtnEdit;
        private DataGridView dataGridView1;
        private TextBox TxtPhone;
        private TextBox TxtAddress;
        private TextBox TxtLastName;
        private TextBox TxtFirtName;
        private TextBox TxtId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private TextBox TxtEmail;
        private Button BtnCancel;
        private Button BtnSave;
        private Label label9;
        private TextBox TxtDocumento;
        private Label label10;
        private TextBox TxtBirthday;
    }
}