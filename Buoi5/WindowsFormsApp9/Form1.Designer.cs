
namespace WindowsFormsApp9
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Orangebt = new System.Windows.Forms.Button();
            this.Liptonbt = new System.Windows.Forms.Button();
            this.Frenchbt = new System.Windows.Forms.Button();
            this.coffeebt = new System.Windows.Forms.Button();
            this.sevenupbt = new System.Windows.Forms.Button();
            this.TCRbt = new System.Windows.Forms.Button();
            this.FChickenbt = new System.Windows.Forms.Button();
            this.Chickballbt = new System.Windows.Forms.Button();
            this.CheeseFishbt = new System.Windows.Forms.Button();
            this.CheeseShrimpbt = new System.Windows.Forms.Button();
            this.CheeseChickenbt = new System.Windows.Forms.Button();
            this.Cocabt = new System.Windows.Forms.Button();
            this.Pepsibt = new System.Windows.Forms.Button();
            this.Shrimpballbt = new System.Windows.Forms.Button();
            this.CheeseCowbtn = new System.Windows.Forms.Button();
            this.Deletebt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Orderbt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(226, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fastfood Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Orangebt);
            this.groupBox1.Controls.Add(this.Liptonbt);
            this.groupBox1.Controls.Add(this.Frenchbt);
            this.groupBox1.Controls.Add(this.coffeebt);
            this.groupBox1.Controls.Add(this.sevenupbt);
            this.groupBox1.Controls.Add(this.TCRbt);
            this.groupBox1.Controls.Add(this.FChickenbt);
            this.groupBox1.Controls.Add(this.Chickballbt);
            this.groupBox1.Controls.Add(this.CheeseFishbt);
            this.groupBox1.Controls.Add(this.CheeseShrimpbt);
            this.groupBox1.Controls.Add(this.CheeseChickenbt);
            this.groupBox1.Controls.Add(this.Cocabt);
            this.groupBox1.Controls.Add(this.Pepsibt);
            this.groupBox1.Controls.Add(this.Shrimpballbt);
            this.groupBox1.Controls.Add(this.CheeseCowbtn);
            this.groupBox1.Location = new System.Drawing.Point(47, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "God\'s Menu";
            // 
            // Orangebt
            // 
            this.Orangebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orangebt.ForeColor = System.Drawing.Color.Red;
            this.Orangebt.Location = new System.Drawing.Point(402, 99);
            this.Orangebt.Name = "Orangebt";
            this.Orangebt.Size = new System.Drawing.Size(83, 23);
            this.Orangebt.TabIndex = 14;
            this.Orangebt.Text = "Cam";
            this.Orangebt.UseVisualStyleBackColor = true;
            this.Orangebt.Click += new System.EventHandler(this.OrderClick);
            // 
            // Liptonbt
            // 
            this.Liptonbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liptonbt.ForeColor = System.Drawing.Color.Red;
            this.Liptonbt.Location = new System.Drawing.Point(402, 59);
            this.Liptonbt.Name = "Liptonbt";
            this.Liptonbt.Size = new System.Drawing.Size(86, 23);
            this.Liptonbt.TabIndex = 13;
            this.Liptonbt.Text = "Lipton";
            this.Liptonbt.UseVisualStyleBackColor = true;
            this.Liptonbt.Click += new System.EventHandler(this.OrderClick);
            // 
            // Frenchbt
            // 
            this.Frenchbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frenchbt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Frenchbt.Location = new System.Drawing.Point(308, 137);
            this.Frenchbt.Name = "Frenchbt";
            this.Frenchbt.Size = new System.Drawing.Size(177, 23);
            this.Frenchbt.TabIndex = 12;
            this.Frenchbt.Text = "Khoai chien";
            this.Frenchbt.UseVisualStyleBackColor = true;
            this.Frenchbt.Click += new System.EventHandler(this.OrderClick);
            // 
            // coffeebt
            // 
            this.coffeebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeebt.ForeColor = System.Drawing.Color.Red;
            this.coffeebt.Location = new System.Drawing.Point(305, 99);
            this.coffeebt.Name = "coffeebt";
            this.coffeebt.Size = new System.Drawing.Size(88, 23);
            this.coffeebt.TabIndex = 11;
            this.coffeebt.Text = "Cafe";
            this.coffeebt.UseVisualStyleBackColor = true;
            this.coffeebt.Click += new System.EventHandler(this.OrderClick);
            // 
            // sevenupbt
            // 
            this.sevenupbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenupbt.ForeColor = System.Drawing.Color.Red;
            this.sevenupbt.Location = new System.Drawing.Point(305, 59);
            this.sevenupbt.Name = "sevenupbt";
            this.sevenupbt.Size = new System.Drawing.Size(88, 23);
            this.sevenupbt.TabIndex = 10;
            this.sevenupbt.Text = "7 Up";
            this.sevenupbt.UseVisualStyleBackColor = true;
            this.sevenupbt.Click += new System.EventHandler(this.OrderClick);
            // 
            // TCRbt
            // 
            this.TCRbt.ForeColor = System.Drawing.Color.Blue;
            this.TCRbt.Location = new System.Drawing.Point(174, 137);
            this.TCRbt.Name = "TCRbt";
            this.TCRbt.Size = new System.Drawing.Size(117, 23);
            this.TCRbt.TabIndex = 9;
            this.TCRbt.Text = "Tender Chicken Rice";
            this.TCRbt.UseVisualStyleBackColor = true;
            this.TCRbt.Click += new System.EventHandler(this.OrderClick);
            // 
            // FChickenbt
            // 
            this.FChickenbt.ForeColor = System.Drawing.Color.Blue;
            this.FChickenbt.Location = new System.Drawing.Point(174, 99);
            this.FChickenbt.Name = "FChickenbt";
            this.FChickenbt.Size = new System.Drawing.Size(117, 23);
            this.FChickenbt.TabIndex = 8;
            this.FChickenbt.Text = "Fried Chicken ";
            this.FChickenbt.UseVisualStyleBackColor = true;
            this.FChickenbt.Click += new System.EventHandler(this.OrderClick);
            // 
            // Chickballbt
            // 
            this.Chickballbt.ForeColor = System.Drawing.Color.Blue;
            this.Chickballbt.Location = new System.Drawing.Point(174, 59);
            this.Chickballbt.Name = "Chickballbt";
            this.Chickballbt.Size = new System.Drawing.Size(117, 23);
            this.Chickballbt.TabIndex = 7;
            this.Chickballbt.Text = "Chicken ball Coke";
            this.Chickballbt.UseVisualStyleBackColor = true;
            this.Chickballbt.Click += new System.EventHandler(this.OrderClick);
            // 
            // CheeseFishbt
            // 
            this.CheeseFishbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheeseFishbt.ForeColor = System.Drawing.Color.Red;
            this.CheeseFishbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheeseFishbt.Location = new System.Drawing.Point(19, 137);
            this.CheeseFishbt.Name = "CheeseFishbt";
            this.CheeseFishbt.Size = new System.Drawing.Size(130, 23);
            this.CheeseFishbt.TabIndex = 6;
            this.CheeseFishbt.Text = "Burger ca";
            this.CheeseFishbt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheeseFishbt.UseVisualStyleBackColor = true;
            this.CheeseFishbt.Click += new System.EventHandler(this.OrderClick);
            // 
            // CheeseShrimpbt
            // 
            this.CheeseShrimpbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheeseShrimpbt.ForeColor = System.Drawing.Color.Red;
            this.CheeseShrimpbt.Location = new System.Drawing.Point(19, 99);
            this.CheeseShrimpbt.Name = "CheeseShrimpbt";
            this.CheeseShrimpbt.Size = new System.Drawing.Size(130, 23);
            this.CheeseShrimpbt.TabIndex = 5;
            this.CheeseShrimpbt.Text = "Burger tom";
            this.CheeseShrimpbt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheeseShrimpbt.UseVisualStyleBackColor = true;
            this.CheeseShrimpbt.Click += new System.EventHandler(this.OrderClick);
            // 
            // CheeseChickenbt
            // 
            this.CheeseChickenbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheeseChickenbt.ForeColor = System.Drawing.Color.Red;
            this.CheeseChickenbt.Location = new System.Drawing.Point(19, 59);
            this.CheeseChickenbt.Name = "CheeseChickenbt";
            this.CheeseChickenbt.Size = new System.Drawing.Size(130, 23);
            this.CheeseChickenbt.TabIndex = 4;
            this.CheeseChickenbt.Text = "Burger ga";
            this.CheeseChickenbt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheeseChickenbt.UseVisualStyleBackColor = true;
            this.CheeseChickenbt.Click += new System.EventHandler(this.OrderClick);
            // 
            // Cocabt
            // 
            this.Cocabt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cocabt.ForeColor = System.Drawing.Color.Red;
            this.Cocabt.Location = new System.Drawing.Point(402, 20);
            this.Cocabt.Name = "Cocabt";
            this.Cocabt.Size = new System.Drawing.Size(86, 23);
            this.Cocabt.TabIndex = 3;
            this.Cocabt.Text = "Coca Cola";
            this.Cocabt.UseVisualStyleBackColor = true;
            this.Cocabt.Click += new System.EventHandler(this.OrderClick);
            // 
            // Pepsibt
            // 
            this.Pepsibt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pepsibt.ForeColor = System.Drawing.Color.Red;
            this.Pepsibt.Location = new System.Drawing.Point(305, 20);
            this.Pepsibt.Name = "Pepsibt";
            this.Pepsibt.Size = new System.Drawing.Size(88, 23);
            this.Pepsibt.TabIndex = 2;
            this.Pepsibt.Text = "Pepsi";
            this.Pepsibt.UseVisualStyleBackColor = true;
            this.Pepsibt.Click += new System.EventHandler(this.OrderClick);
            // 
            // Shrimpballbt
            // 
            this.Shrimpballbt.ForeColor = System.Drawing.Color.Blue;
            this.Shrimpballbt.Location = new System.Drawing.Point(174, 20);
            this.Shrimpballbt.Name = "Shrimpballbt";
            this.Shrimpballbt.Size = new System.Drawing.Size(117, 23);
            this.Shrimpballbt.TabIndex = 1;
            this.Shrimpballbt.Text = "Shrimp ball Coke";
            this.Shrimpballbt.UseVisualStyleBackColor = true;
            this.Shrimpballbt.Click += new System.EventHandler(this.OrderClick);
            // 
            // CheeseCowbtn
            // 
            this.CheeseCowbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheeseCowbtn.ForeColor = System.Drawing.Color.Red;
            this.CheeseCowbtn.Location = new System.Drawing.Point(19, 20);
            this.CheeseCowbtn.Name = "CheeseCowbtn";
            this.CheeseCowbtn.Size = new System.Drawing.Size(130, 23);
            this.CheeseCowbtn.TabIndex = 0;
            this.CheeseCowbtn.Text = "Burger Pho mai ";
            this.CheeseCowbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheeseCowbtn.UseVisualStyleBackColor = true;
            this.CheeseCowbtn.Click += new System.EventHandler(this.OrderClick);
            // 
            // Deletebt
            // 
            this.Deletebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebt.Image = ((System.Drawing.Image)(resources.GetObject("Deletebt.Image")));
            this.Deletebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deletebt.Location = new System.Drawing.Point(47, 320);
            this.Deletebt.Name = "Deletebt";
            this.Deletebt.Size = new System.Drawing.Size(85, 39);
            this.Deletebt.TabIndex = 3;
            this.Deletebt.Text = "Delete";
            this.Deletebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Deletebt.UseVisualStyleBackColor = true;
            this.Deletebt.Click += new System.EventHandler(this.Deletebt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ten bang:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(301, 329);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Orderbt
            // 
            this.Orderbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orderbt.Image = ((System.Drawing.Image)(resources.GetObject("Orderbt.Image")));
            this.Orderbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Orderbt.Location = new System.Drawing.Point(449, 320);
            this.Orderbt.Name = "Orderbt";
            this.Orderbt.Size = new System.Drawing.Size(86, 34);
            this.Orderbt.TabIndex = 6;
            this.Orderbt.Text = "Order";
            this.Orderbt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Orderbt.UseVisualStyleBackColor = true;
            this.Orderbt.Click += new System.EventHandler(this.Orderbt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 177);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(138, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear all";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Orderbt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Deletebt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Orangebt;
        private System.Windows.Forms.Button Liptonbt;
        private System.Windows.Forms.Button Frenchbt;
        private System.Windows.Forms.Button coffeebt;
        private System.Windows.Forms.Button sevenupbt;
        private System.Windows.Forms.Button TCRbt;
        private System.Windows.Forms.Button FChickenbt;
        private System.Windows.Forms.Button Chickballbt;
        private System.Windows.Forms.Button CheeseFishbt;
        private System.Windows.Forms.Button CheeseShrimpbt;
        private System.Windows.Forms.Button CheeseChickenbt;
        private System.Windows.Forms.Button Cocabt;
        private System.Windows.Forms.Button Pepsibt;
        private System.Windows.Forms.Button Shrimpballbt;
        private System.Windows.Forms.Button CheeseCowbtn;
        private System.Windows.Forms.Button Deletebt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Orderbt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

