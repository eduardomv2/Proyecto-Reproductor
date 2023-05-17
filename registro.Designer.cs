namespace Proyecto_Reproductor
{
    partial class registro
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
            this.textFullname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblfullname = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblusern = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textFullname
            // 
            this.textFullname.Location = new System.Drawing.Point(106, 134);
            this.textFullname.Name = "textFullname";
            this.textFullname.Size = new System.Drawing.Size(286, 20);
            this.textFullname.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(106, 312);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(286, 20);
            this.txtPass.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(106, 253);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(286, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.LightGray;
            this.btnRegistrar.Location = new System.Drawing.Point(57, 384);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(194, 40);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.LightGray;
            this.btnBack.Location = new System.Drawing.Point(257, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(194, 40);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Atras";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblfullname
            // 
            this.lblfullname.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.ForeColor = System.Drawing.Color.Black;
            this.lblfullname.Location = new System.Drawing.Point(103, 118);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(120, 13);
            this.lblfullname.TabIndex = 7;
            this.lblfullname.Text = "Nombre:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(103, 172);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(120, 13);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblusern
            // 
            this.lblusern.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusern.ForeColor = System.Drawing.Color.Black;
            this.lblusern.Location = new System.Drawing.Point(103, 237);
            this.lblusern.Name = "lblusern";
            this.lblusern.Size = new System.Drawing.Size(120, 13);
            this.lblusern.TabIndex = 9;
            this.lblusern.Text = "Username:";
            // 
            // lblpass
            // 
            this.lblpass.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.Black;
            this.lblpass.Location = new System.Drawing.Point(103, 296);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(120, 13);
            this.lblpass.TabIndex = 10;
            this.lblpass.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(188, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "REGISTRO";
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(489, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblusern);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.textFullname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registro";
            this.Opacity = 0.87D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFullname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblusern;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label label1;
    }
}