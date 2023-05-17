namespace Proyecto_Reproductor
{
    partial class Reproductor
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
            this.lbluser = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.imagenesPerfiles1 = new Proyecto_Reproductor.ImagenesPerfiles();
            ((System.ComponentModel.ISupportInitialize)(this.imagenesPerfiles1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.LightGray;
            this.lbluser.Location = new System.Drawing.Point(869, 59);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(44, 21);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "User";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(516, 593);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(130, 45);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click_1);
            // 
            // imagenesPerfiles1
            // 
            this.imagenesPerfiles1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.imagenesPerfiles1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.imagenesPerfiles1.BorderColor2 = System.Drawing.Color.DeepPink;
            this.imagenesPerfiles1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.imagenesPerfiles1.Bordersize = 3;
            this.imagenesPerfiles1.GradientAngle = 50F;
            this.imagenesPerfiles1.Image = global::Proyecto_Reproductor.Properties.Resources.Eduardo_Alejandro_Martinez_Villalobos;
            this.imagenesPerfiles1.Location = new System.Drawing.Point(995, 23);
            this.imagenesPerfiles1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.imagenesPerfiles1.Name = "imagenesPerfiles1";
            this.imagenesPerfiles1.Size = new System.Drawing.Size(134, 126);
            this.imagenesPerfiles1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenesPerfiles1.TabIndex = 1;
            this.imagenesPerfiles1.TabStop = false;
            this.imagenesPerfiles1.Click += new System.EventHandler(this.imagenesPerfiles1_Click);
            this.imagenesPerfiles1.DoubleClick += new System.EventHandler(this.imagenesPerfiles1_DoubleClick);
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1174, 717);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.imagenesPerfiles1);
            this.Controls.Add(this.lbluser);
            this.Name = "Reproductor";
            this.Text = "Reproductor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reproductor_FormClosed);
            this.Load += new System.EventHandler(this.Reproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenesPerfiles1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private ImagenesPerfiles imagenesPerfiles1;
        private System.Windows.Forms.Button btnsalir;
    }
}