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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            PagePayModeList = new TabPage();
            PagePayModeDetail = new TabPage();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            BtnNew = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnCerrar = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            PagePayModeList.SuspendLayout();
            PagePayModeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // label1
            // 
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(181, 24);
            label1.Name = "label1";
            label1.Size = new Size(203, 50);
            label1.TabIndex = 1;
            label1.Text = "Pay Mode";
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
            PagePayModeList.Controls.Add(button1);
            PagePayModeList.Controls.Add(textBox1);
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
            // PagePayModeDetail
            // 
            PagePayModeDetail.Controls.Add(button3);
            PagePayModeDetail.Controls.Add(button2);
            PagePayModeDetail.Controls.Add(textBox4);
            PagePayModeDetail.Controls.Add(label5);
            PagePayModeDetail.Controls.Add(textBox3);
            PagePayModeDetail.Controls.Add(label4);
            PagePayModeDetail.Controls.Add(textBox2);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 22);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.search_small;
            button1.Location = new Point(474, 30);
            button1.Name = "button1";
            button1.Size = new Size(38, 41);
            button1.TabIndex = 2;
            button1.Text = "\r\n";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(489, 223);
            dataGridView1.TabIndex = 3;
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
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(552, 174);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(147, 50);
            BtnDelete.TabIndex = 5;
            BtnDelete.UseVisualStyleBackColor = true;
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
            // BtnCerrar
            // 
            BtnCerrar.Image = Properties.Resources.cerrar;
            BtnCerrar.Location = new Point(552, 243);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(147, 50);
            BtnCerrar.TabIndex = 7;
            BtnCerrar.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            textBox2.Location = new Point(39, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 1;
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
            // textBox3
            // 
            textBox3.Location = new Point(39, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(362, 23);
            textBox3.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 162);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Name";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(39, 180);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(362, 68);
            textBox4.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(37, 275);
            button2.Name = "button2";
            button2.Size = new Size(148, 51);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(253, 275);
            button3.Name = "button3";
            button3.Size = new Size(148, 51);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
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
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            PagePayModeList.ResumeLayout(false);
            PagePayModeList.PerformLayout();
            PagePayModeDetail.ResumeLayout(false);
            PagePayModeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button button1;
        private TextBox textBox1;
        private Button BtnDelete;
        private Button BtnNew;
        private DataGridView dataGridView1;
        private Button BtnCerrar;
        private Button BtnEdit;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox4;
        private Button button3;
        private Button button2;
    }
}