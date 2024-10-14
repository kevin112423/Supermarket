namespace Supermarket_mvp.view
{
    partial class CategoriesView
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
            tabCategoriesList = new TabPage();
            tabCategoriesDetail = new TabPage();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnCerrar = new Button();
            TxtId = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            TxtDescription = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabCategoriesList.SuspendLayout();
            tabCategoriesDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 112);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categoria;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(156, 39);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 1;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCategoriesList);
            tabControl1.Controls.Add(tabCategoriesDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 112);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 378);
            tabControl1.TabIndex = 1;
            // 
            // tabCategoriesList
            // 
            tabCategoriesList.Controls.Add(BtnCerrar);
            tabCategoriesList.Controls.Add(BtnDelete);
            tabCategoriesList.Controls.Add(BtnEdit);
            tabCategoriesList.Controls.Add(BtnNew);
            tabCategoriesList.Controls.Add(dataGridView1);
            tabCategoriesList.Controls.Add(label2);
            tabCategoriesList.Controls.Add(BtnSearch);
            tabCategoriesList.Controls.Add(TxtSearch);
            tabCategoriesList.Location = new Point(4, 24);
            tabCategoriesList.Name = "tabCategoriesList";
            tabCategoriesList.Padding = new Padding(3);
            tabCategoriesList.Size = new Size(792, 350);
            tabCategoriesList.TabIndex = 0;
            tabCategoriesList.Text = " Categories List";
            tabCategoriesList.UseVisualStyleBackColor = true;
            // 
            // tabCategoriesDetail
            // 
            tabCategoriesDetail.Controls.Add(BtnCancel);
            tabCategoriesDetail.Controls.Add(BtnSave);
            tabCategoriesDetail.Controls.Add(TxtDescription);
            tabCategoriesDetail.Controls.Add(label5);
            tabCategoriesDetail.Controls.Add(textBox1);
            tabCategoriesDetail.Controls.Add(label4);
            tabCategoriesDetail.Controls.Add(label3);
            tabCategoriesDetail.Controls.Add(TxtId);
            tabCategoriesDetail.Location = new Point(4, 24);
            tabCategoriesDetail.Name = "tabCategoriesDetail";
            tabCategoriesDetail.Padding = new Padding(3);
            tabCategoriesDetail.Size = new Size(792, 350);
            tabCategoriesDetail.TabIndex = 1;
            tabCategoriesDetail.Text = "Categories Detail";
            tabCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(17, 44);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(412, 23);
            TxtSearch.TabIndex = 0;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(441, 37);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(38, 37);
            BtnSearch.TabIndex = 1;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 23);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Categoria";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(522, 251);
            dataGridView1.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(594, 52);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(165, 49);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(594, 107);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(165, 49);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(594, 162);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(165, 49);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Image = Properties.Resources.cerrar;
            BtnCerrar.Location = new Point(594, 217);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(165, 49);
            BtnCerrar.TabIndex = 7;
            BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(49, 38);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(247, 23);
            TxtId.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 20);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 1;
            label3.Text = "Categorias id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 73);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 2;
            label4.Text = "Categories name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 126);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 4;
            label5.Text = "Categories Description";
            // 
            // TxtDescription
            // 
            TxtDescription.Location = new Point(53, 144);
            TxtDescription.Multiline = true;
            TxtDescription.Name = "TxtDescription";
            TxtDescription.Size = new Size(247, 96);
            TxtDescription.TabIndex = 5;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(49, 266);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(115, 62);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(185, 266);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(115, 62);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "CategoriesView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabCategoriesList.ResumeLayout(false);
            tabCategoriesList.PerformLayout();
            tabCategoriesDetail.ResumeLayout(false);
            tabCategoriesDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabCategoriesList;
        private Label label2;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private TabPage tabCategoriesDetail;
        private Button BtnCerrar;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private TextBox TxtId;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtDescription;
        private Label label5;
    }
}