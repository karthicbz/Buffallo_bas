namespace DonkeyGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Buffallo = new System.Windows.Forms.PictureBox();
            this.Car = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.crashed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buffallo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buffallo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(153, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 485);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Driver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Font = new System.Drawing.Font("Stencil Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(435, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 54);
            this.label5.TabIndex = 6;
            this.label5.Text = "Press Left/Right \r\nKeys To Switch \r\nLanes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Press Q to Exit";
            // 
            // Buffallo
            // 
            this.Buffallo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Buffallo.Image = ((System.Drawing.Image)(resources.GetObject("Buffallo.Image")));
            this.Buffallo.Location = new System.Drawing.Point(153, -45);
            this.Buffallo.Name = "Buffallo";
            this.Buffallo.Size = new System.Drawing.Size(100, 91);
            this.Buffallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Buffallo.TabIndex = 8;
            this.Buffallo.TabStop = false;
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(319, 381);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(100, 105);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 9;
            this.Car.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // crashed
            // 
            this.crashed.AutoSize = true;
            this.crashed.BackColor = System.Drawing.Color.Red;
            this.crashed.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crashed.Location = new System.Drawing.Point(109, 259);
            this.crashed.Name = "crashed";
            this.crashed.Size = new System.Drawing.Size(354, 79);
            this.crashed.TabIndex = 10;
            this.crashed.Text = "Crashed!";
            this.crashed.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(581, 487);
            this.Controls.Add(this.crashed);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.Buffallo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Buffallo bas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buffallo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Buffallo;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label crashed;
    }
}

