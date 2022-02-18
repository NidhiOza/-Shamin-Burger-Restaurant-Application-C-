
namespace ShaminPart4
{
    partial class frmShamin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShamin));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBasicB = new System.Windows.Forms.Button();
            this.btnHealty = new System.Windows.Forms.Button();
            this.btnDeluxeB = new System.Windows.Forms.Button();
            this.Tomato = new System.Windows.Forms.Button();
            this.Lettuce = new System.Windows.Forms.Button();
            this.Bacon = new System.Windows.Forms.Button();
            this.Egg = new System.Windows.Forms.Button();
            this.Pepper = new System.Windows.Forms.Button();
            this.Pickle = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(318, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Shamin";
            // 
            // btnBasicB
            // 
            this.btnBasicB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBasicB.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasicB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBasicB.Location = new System.Drawing.Point(220, 77);
            this.btnBasicB.Name = "btnBasicB";
            this.btnBasicB.Size = new System.Drawing.Size(119, 53);
            this.btnBasicB.TabIndex = 1;
            this.btnBasicB.Text = "Basic Burguer";
            this.btnBasicB.UseVisualStyleBackColor = false;
            this.btnBasicB.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // btnHealty
            // 
            this.btnHealty.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHealty.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHealty.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHealty.Location = new System.Drawing.Point(390, 77);
            this.btnHealty.Name = "btnHealty";
            this.btnHealty.Size = new System.Drawing.Size(120, 53);
            this.btnHealty.TabIndex = 2;
            this.btnHealty.Text = "Healty Burguer";
            this.btnHealty.UseVisualStyleBackColor = false;
            this.btnHealty.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // btnDeluxeB
            // 
            this.btnDeluxeB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDeluxeB.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeluxeB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeluxeB.Location = new System.Drawing.Point(538, 77);
            this.btnDeluxeB.Name = "btnDeluxeB";
            this.btnDeluxeB.Size = new System.Drawing.Size(120, 53);
            this.btnDeluxeB.TabIndex = 3;
            this.btnDeluxeB.Text = "Deluxe Burguer";
            this.btnDeluxeB.UseVisualStyleBackColor = false;
            this.btnDeluxeB.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // Tomato
            // 
            this.Tomato.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Tomato.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tomato.BackgroundImage")));
            this.Tomato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tomato.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tomato.ForeColor = System.Drawing.Color.Transparent;
            this.Tomato.Location = new System.Drawing.Point(273, 145);
            this.Tomato.Name = "Tomato";
            this.Tomato.Size = new System.Drawing.Size(96, 67);
            this.Tomato.TabIndex = 4;
            this.Tomato.Tag = "";
            this.Tomato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Tomato.UseVisualStyleBackColor = false;
            this.Tomato.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Lettuce
            // 
            this.Lettuce.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lettuce.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Lettuce.BackgroundImage")));
            this.Lettuce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lettuce.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lettuce.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lettuce.Location = new System.Drawing.Point(391, 145);
            this.Lettuce.Name = "Lettuce";
            this.Lettuce.Size = new System.Drawing.Size(96, 67);
            this.Lettuce.TabIndex = 5;
            this.Lettuce.Tag = "";
            this.Lettuce.UseVisualStyleBackColor = false;
            this.Lettuce.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Bacon
            // 
            this.Bacon.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Bacon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bacon.BackgroundImage")));
            this.Bacon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bacon.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bacon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Bacon.Location = new System.Drawing.Point(502, 145);
            this.Bacon.Name = "Bacon";
            this.Bacon.Size = new System.Drawing.Size(96, 67);
            this.Bacon.TabIndex = 6;
            this.Bacon.Tag = "";
            this.Bacon.UseVisualStyleBackColor = false;
            this.Bacon.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Egg
            // 
            this.Egg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Egg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Egg.BackgroundImage")));
            this.Egg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Egg.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Egg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Egg.Location = new System.Drawing.Point(273, 218);
            this.Egg.Name = "Egg";
            this.Egg.Size = new System.Drawing.Size(96, 67);
            this.Egg.TabIndex = 7;
            this.Egg.Tag = "";
            this.Egg.UseVisualStyleBackColor = false;
            this.Egg.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Pepper
            // 
            this.Pepper.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pepper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pepper.BackgroundImage")));
            this.Pepper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pepper.Enabled = false;
            this.Pepper.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pepper.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Pepper.Location = new System.Drawing.Point(391, 218);
            this.Pepper.Name = "Pepper";
            this.Pepper.Size = new System.Drawing.Size(96, 67);
            this.Pepper.TabIndex = 8;
            this.Pepper.Tag = "";
            this.Pepper.UseVisualStyleBackColor = false;
            this.Pepper.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Pickle
            // 
            this.Pickle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pickle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pickle.BackgroundImage")));
            this.Pickle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pickle.Enabled = false;
            this.Pickle.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pickle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Pickle.Location = new System.Drawing.Point(502, 218);
            this.Pickle.Name = "Pickle";
            this.Pickle.Size = new System.Drawing.Size(96, 67);
            this.Pickle.TabIndex = 9;
            this.Pickle.Tag = "";
            this.Pickle.UseVisualStyleBackColor = false;
            this.Pickle.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlaceOrder.Location = new System.Drawing.Point(220, 291);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(438, 39);
            this.btnPlaceOrder.TabIndex = 10;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(287, 417);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 144);
            this.dataGridView1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(293, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Receipt";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(155, 347);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(552, 33);
            this.txtTest.TabIndex = 13;
            // 
            // frmShamin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 622);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.Pickle);
            this.Controls.Add(this.Pepper);
            this.Controls.Add(this.Egg);
            this.Controls.Add(this.Bacon);
            this.Controls.Add(this.Lettuce);
            this.Controls.Add(this.Tomato);
            this.Controls.Add(this.btnDeluxeB);
            this.Controls.Add(this.btnHealty);
            this.Controls.Add(this.btnBasicB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShamin";
            this.Text = "Shamin Burger";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBasicB;
        private System.Windows.Forms.Button btnHealty;
        private System.Windows.Forms.Button btnDeluxeB;
        private System.Windows.Forms.Button Tomato;
        private System.Windows.Forms.Button Lettuce;
        private System.Windows.Forms.Button Bacon;
        private System.Windows.Forms.Button Egg;
        private System.Windows.Forms.Button Pepper;
        private System.Windows.Forms.Button Pickle;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTest;
    }
}

