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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            BrnSearch = new Button();
            TxtSearch = new TextBox();
            tabCustomersDetail = new TabPage();
            button7 = new Button();
            button6 = new Button();
            label7 = new Label();
            TxtCategoria = new TextBox();
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
            panel1.Size = new Size(800, 110);
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
            tabControl1.Size = new Size(800, 376);
            tabControl1.TabIndex = 1;
            // 
            // tabCustomersList
            // 
            tabCustomersList.Controls.Add(button5);
            tabCustomersList.Controls.Add(button4);
            tabCustomersList.Controls.Add(button3);
            tabCustomersList.Controls.Add(button2);
            tabCustomersList.Controls.Add(dataGridView1);
            tabCustomersList.Controls.Add(label2);
            tabCustomersList.Controls.Add(BrnSearch);
            tabCustomersList.Controls.Add(TxtSearch);
            tabCustomersList.Location = new Point(4, 24);
            tabCustomersList.Name = "tabCustomersList";
            tabCustomersList.Padding = new Padding(3);
            tabCustomersList.Size = new Size(792, 348);
            tabCustomersList.TabIndex = 0;
            tabCustomersList.Text = "Prudoct List";
            tabCustomersList.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.cerrar;
            button5.Location = new Point(600, 264);
            button5.Name = "button5";
            button5.Size = new Size(170, 52);
            button5.TabIndex = 7;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.delete;
            button4.Location = new Point(600, 197);
            button4.Name = "button4";
            button4.Size = new Size(170, 52);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.edit;
            button3.Location = new Point(600, 129);
            button3.Name = "button3";
            button3.Size = new Size(170, 52);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources._new;
            button2.Location = new Point(600, 49);
            button2.Name = "button2";
            button2.Size = new Size(170, 52);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
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
            // BrnSearch
            // 
            BrnSearch.Image = Properties.Resources.search_small;
            BrnSearch.Location = new Point(326, 28);
            BrnSearch.Name = "BrnSearch";
            BrnSearch.Size = new Size(37, 43);
            BrnSearch.TabIndex = 1;
            BrnSearch.UseVisualStyleBackColor = true;
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
            tabCustomersDetail.Controls.Add(button7);
            tabCustomersDetail.Controls.Add(button6);
            tabCustomersDetail.Controls.Add(label7);
            tabCustomersDetail.Controls.Add(TxtCategoria);
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
            // button7
            // 
            button7.Image = Properties.Resources.cancel;
            button7.Location = new Point(417, 260);
            button7.Name = "button7";
            button7.Size = new Size(111, 53);
            button7.TabIndex = 11;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Image = Properties.Resources.save;
            button6.Location = new Point(237, 260);
            button6.Name = "button6";
            button6.Size = new Size(111, 53);
            button6.TabIndex = 10;
            button6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(555, 142);
            label7.Name = "label7";
            label7.Size = new Size(103, 15);
            label7.TabIndex = 9;
            label7.Text = "Product Categoria";
            // 
            // TxtCategoria
            // 
            TxtCategoria.Location = new Point(555, 160);
            TxtCategoria.Name = "TxtCategoria";
            TxtCategoria.Size = new Size(191, 23);
            TxtCategoria.TabIndex = 8;
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
            ClientSize = new Size(800, 486);
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
        private Button BrnSearch;
        private TextBox TxtSearch;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox TxtName;
        private Label label4;
        private TextBox TxtId;
        private Label label3;
        private Label label6;
        private TextBox TxtPrice;
        private Label label5;
        private Label label7;
        private TextBox TxtCategoria;
        private TextBox TxtStock;
        private Button button7;
        private Button button6;
    }
}