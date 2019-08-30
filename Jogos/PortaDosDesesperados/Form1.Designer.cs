namespace PortaDosDesesperados
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
            this.btnPorta1 = new System.Windows.Forms.Button();
            this.btnPorta2 = new System.Windows.Forms.Button();
            this.btnPorta3 = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.imgPorta3 = new System.Windows.Forms.PictureBox();
            this.imgPorta2 = new System.Windows.Forms.PictureBox();
            this.imgPorta1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorta1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPorta1
            // 
            this.btnPorta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorta1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPorta1.Location = new System.Drawing.Point(12, 214);
            this.btnPorta1.Name = "btnPorta1";
            this.btnPorta1.Size = new System.Drawing.Size(100, 40);
            this.btnPorta1.TabIndex = 3;
            this.btnPorta1.Text = "1";
            this.btnPorta1.UseVisualStyleBackColor = true;
            this.btnPorta1.Click += new System.EventHandler(this.btnPorta1_Click);
            // 
            // btnPorta2
            // 
            this.btnPorta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorta2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPorta2.Location = new System.Drawing.Point(118, 214);
            this.btnPorta2.Name = "btnPorta2";
            this.btnPorta2.Size = new System.Drawing.Size(100, 40);
            this.btnPorta2.TabIndex = 4;
            this.btnPorta2.Text = "2";
            this.btnPorta2.UseVisualStyleBackColor = true;
            this.btnPorta2.Click += new System.EventHandler(this.btnPorta2_Click);
            // 
            // btnPorta3
            // 
            this.btnPorta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorta3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPorta3.Location = new System.Drawing.Point(224, 214);
            this.btnPorta3.Name = "btnPorta3";
            this.btnPorta3.Size = new System.Drawing.Size(100, 40);
            this.btnPorta3.TabIndex = 5;
            this.btnPorta3.Text = "3";
            this.btnPorta3.UseVisualStyleBackColor = true;
            this.btnPorta3.Click += new System.EventHandler(this.btnPorta3_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnReiniciar.Location = new System.Drawing.Point(12, 260);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(311, 45);
            this.btnReiniciar.TabIndex = 6;
            this.btnReiniciar.Text = "Jogar Novamente";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // imgPorta3
            // 
            this.imgPorta3.BackColor = System.Drawing.Color.White;
            this.imgPorta3.Image = ((System.Drawing.Image)(resources.GetObject("imgPorta3.Image")));
            this.imgPorta3.Location = new System.Drawing.Point(224, 12);
            this.imgPorta3.Name = "imgPorta3";
            this.imgPorta3.Size = new System.Drawing.Size(99, 196);
            this.imgPorta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPorta3.TabIndex = 2;
            this.imgPorta3.TabStop = false;
            this.imgPorta3.Click += new System.EventHandler(this.btnPorta3_Click);
            // 
            // imgPorta2
            // 
            this.imgPorta2.Image = ((System.Drawing.Image)(resources.GetObject("imgPorta2.Image")));
            this.imgPorta2.Location = new System.Drawing.Point(118, 12);
            this.imgPorta2.Name = "imgPorta2";
            this.imgPorta2.Size = new System.Drawing.Size(100, 196);
            this.imgPorta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPorta2.TabIndex = 1;
            this.imgPorta2.TabStop = false;
            this.imgPorta2.Click += new System.EventHandler(this.btnPorta2_Click);
            // 
            // imgPorta1
            // 
            this.imgPorta1.Image = ((System.Drawing.Image)(resources.GetObject("imgPorta1.Image")));
            this.imgPorta1.Location = new System.Drawing.Point(12, 12);
            this.imgPorta1.Name = "imgPorta1";
            this.imgPorta1.Size = new System.Drawing.Size(100, 196);
            this.imgPorta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPorta1.TabIndex = 0;
            this.imgPorta1.TabStop = false;
            this.imgPorta1.Click += new System.EventHandler(this.btnPorta1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 314);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnPorta3);
            this.Controls.Add(this.btnPorta2);
            this.Controls.Add(this.btnPorta1);
            this.Controls.Add(this.imgPorta3);
            this.Controls.Add(this.imgPorta2);
            this.Controls.Add(this.imgPorta1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgPorta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPorta1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPorta1;
        private System.Windows.Forms.PictureBox imgPorta2;
        private System.Windows.Forms.PictureBox imgPorta3;
        private System.Windows.Forms.Button btnPorta1;
        private System.Windows.Forms.Button btnPorta2;
        private System.Windows.Forms.Button btnPorta3;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

