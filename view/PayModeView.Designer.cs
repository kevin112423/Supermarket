namespace Supermarket_mvp.view
{
    partial class PayModeView
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            PagePayModeList = new TabPage();
            BtnCerrar = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnNew = new Button();
            dataGridView1 = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            PagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayModeObservation = new TextBox();
            label5 = new Label();
            TxtPayModeName = new TextBox();
            label4 = new Label();
            TxtPayModeId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            PagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            PagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(181, 24);
            label1.Name = "label1";
            label1.Size = new Size(203, 50);
            label1.TabIndex = 1;
            label1.Text = "Pay Mode";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(30, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(PagePayModeList);
            tabControl1.Controls.Add(PagePayModeDetail);
            tabControl1.Location = new Point(-2, 107);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 379);
            tabControl1.TabIndex = 1;
            // 
            // PagePayModeList
            // 
            PagePayModeList.Controls.Add(BtnCerrar);
            PagePayModeList.Controls.Add(BtnEdit);
            PagePayModeList.Controls.Add(BtnDelete);
            PagePayModeList.Controls.Add(BtnNew);
            PagePayModeList.Controls.Add(dataGridView1);
            PagePayModeList.Controls.Add(BtnSearch);
            PagePayModeList.Controls.Add(TxtSearch);
            PagePayModeList.Controls.Add(label2);
            PagePayModeList.Location = new Point(4, 24);
            PagePayModeList.Name = "PagePayModeList";
            PagePayModeList.Padding = new Padding(3);
            PagePayModeList.Size = new Size(789, 351);
            PagePayModeList.TabIndex = 0;
            PagePayModeList.Text = " Pay Mode List";
            PagePayModeList.UseVisualStyleBackColor = true;
            PagePayModeList.Click += PagePayModeList_Click_1;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Image = Properties.Resources.cerrar;
            BtnCerrar.Location = new Point(552, 243);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(147, 50);
            BtnCerrar.TabIndex = 7;
            BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(552, 102);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(147, 50);
            BtnEdit.TabIndex = 6;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(552, 174);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(147, 50);
            BtnDelete.TabIndex = 5;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(552, 30);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(147, 50);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(489, 223);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(474, 30);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(38, 41);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "\r\n";
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(51, 40);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(417, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 22);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // PagePayModeDetail
            // 
            PagePayModeDetail.Controls.Add(BtnCancel);
            PagePayModeDetail.Controls.Add(BtnSave);
            PagePayModeDetail.Controls.Add(TxtPayModeObservation);
            PagePayModeDetail.Controls.Add(label5);
            PagePayModeDetail.Controls.Add(TxtPayModeName);
            PagePayModeDetail.Controls.Add(label4);
            PagePayModeDetail.Controls.Add(TxtPayModeId);
            PagePayModeDetail.Controls.Add(label3);
            PagePayModeDetail.Location = new Point(4, 24);
            PagePayModeDetail.Name = "PagePayModeDetail";
            PagePayModeDetail.Padding = new Padding(3);
            PagePayModeDetail.Size = new Size(789, 351);
            PagePayModeDetail.TabIndex = 1;
            PagePayModeDetail.Text = " Pay Mode Detail";
            PagePayModeDetail.UseVisualStyleBackColor = true;
            PagePayModeDetail.Click += PagePayModeDetail_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(253, 275);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(148, 51);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(37, 275);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(148, 51);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(39, 180);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(362, 68);
            TxtPayModeObservation.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 162);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            label5.Click += label5_Click;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(39, 114);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(362, 23);
            TxtPayModeName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 96);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(39, 50);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(232, 23);
            TxtPayModeId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 27);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "PayModeView";
            Load += PayModeView_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            PagePayModeList.ResumeLayout(false);
            PagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            PagePayModeDetail.ResumeLayout(false);
            PagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage PagePayModeList;
        private TabPage PagePayModeDetail;
        private Label label2;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Button BtnDelete;
        private Button BtnNew;
        private DataGridView dataGridView1;
        private Button BtnCerrar;
        private Button BtnEdit;
        private Label label5;
        private TextBox TxtPayModeName;
        private Label label4;
        private TextBox TxtPayModeId;
        private Label label3;
        private TextBox TxtPayModeObservation;
        private Button BtnCancel;
        private Button BtnSave;
    }
}