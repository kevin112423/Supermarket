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
            tabProductList = new TabPage();
            tabProductDetail = new TabPage();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnDelete = new Button();
            BtnCerrar = new Button();
            TxtId = new TextBox();
            TxtName = new TextBox();
            TxtLastName = new TextBox();
            TxtAddress = new TextBox();
            TxtPhone = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtEmail = new TextBox();
            label8 = new Label();
            button6 = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabProductList.SuspendLayout();
            tabProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 124);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
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
            label1.Size = new Size(172, 54);
            label1.TabIndex = 0;
            label1.Text = "Product ";
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
            tabControl1.Size = new Size(800, 396);
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
            tabProductList.Size = new Size(792, 368);
            tabProductList.TabIndex = 0;
            tabProductList.Text = "Product List";
            tabProductList.UseVisualStyleBackColor = true;
            // 
            // tabProductDetail
            // 
            tabProductDetail.Controls.Add(button7);
            tabProductDetail.Controls.Add(button6);
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
            tabProductDetail.Controls.Add(TxtName);
            tabProductDetail.Controls.Add(TxtId);
            tabProductDetail.Location = new Point(4, 24);
            tabProductDetail.Name = "tabProductDetail";
            tabProductDetail.Padding = new Padding(3);
            tabProductDetail.Size = new Size(792, 368);
            tabProductDetail.TabIndex = 1;
            tabProductDetail.Text = "Product Detail";
            tabProductDetail.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(25, 42);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(333, 23);
            TxtSearch.TabIndex = 0;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 16);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Product";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(569, 257);
            dataGridView1.TabIndex = 3;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(629, 123);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(140, 45);
            BtnEdit.TabIndex = 4;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += button2_Click;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(629, 56);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(140, 45);
            BtnNew.TabIndex = 5;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(629, 196);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(140, 45);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Image = Properties.Resources.cerrar;
            BtnCerrar.Location = new Point(629, 266);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(140, 45);
            BtnCerrar.TabIndex = 7;
            BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(200, 40);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(218, 23);
            TxtId.TabIndex = 0;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(200, 100);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(218, 23);
            TxtName.TabIndex = 1;
            // 
            // TxtLastName
            // 
            TxtLastName.Location = new Point(200, 164);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(218, 23);
            TxtLastName.TabIndex = 2;
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(484, 40);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(218, 23);
            TxtAddress.TabIndex = 3;
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(484, 100);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(218, 23);
            TxtPhone.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 22);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Product Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 82);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 6;
            label4.Text = "Product firt Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 146);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 7;
            label5.Text = "Product Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 82);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 8;
            label6.Text = "Product Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(484, 22);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 9;
            label7.Text = "Product Address";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(484, 164);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(218, 23);
            TxtEmail.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(484, 146);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 11;
            label8.Text = "Product Email";
            label8.Click += label8_Click;
            // 
            // button6
            // 
            button6.Image = Properties.Resources.save;
            button6.Location = new Point(238, 248);
            button6.Name = "button6";
            button6.Size = new Size(154, 72);
            button6.TabIndex = 12;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Image = Properties.Resources.cancel;
            button7.Location = new Point(495, 247);
            button7.Name = "button7";
            button7.Size = new Size(170, 73);
            button7.TabIndex = 13;
            button7.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabProductList.ResumeLayout(false);
            tabProductList.PerformLayout();
            tabProductDetail.ResumeLayout(false);
            tabProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox TxtName;
        private TextBox TxtId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private TextBox TxtEmail;
        private Button button7;
        private Button button6;
    }
}