namespace Supermarket_mvp.view
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            panel1 = new Panel();
            BtnCustomers = new Button();
            BtnNew = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCustomers);
            panel1.Controls.Add(BtnNew);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 564);
            panel1.TabIndex = 0;
            // 
            // BtnCustomers
            // 
            BtnCustomers.BackgroundImage = (Image)resources.GetObject("BtnCustomers.BackgroundImage");
            BtnCustomers.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCustomers.Location = new Point(1, 170);
            BtnCustomers.Name = "BtnCustomers";
            BtnCustomers.Size = new Size(179, 89);
            BtnCustomers.TabIndex = 3;
            BtnCustomers.UseVisualStyleBackColor = true;
            BtnCustomers.Click += BtnCustomers_Click;
            // 
            // BtnNew
            // 
            BtnNew.BackgroundImage = Properties.Resources.cerrar_con_llave;
            BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNew.Dock = DockStyle.Bottom;
            BtnNew.Location = new Point(0, 486);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(183, 78);
            BtnNew.TabIndex = 2;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.Click += BtnNew_Click;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(1, 75);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(179, 89);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 564);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            Load += MainView_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button BtnPayMode;
        private Button BtnNew;
        private Button BtnCustomers;
    }
}