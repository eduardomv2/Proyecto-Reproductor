namespace Proyecto_Reproductor
{
    partial class mp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mp4));
            this.ListBoxVideos = new System.Windows.Forms.ListBox();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.labelNombreArchivo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.macTrackBar2 = new XComponent.SliderBar.MACTrackBar();
            this.macTrackBar1 = new XComponent.SliderBar.MACTrackBar();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxVideos
            // 
            this.ListBoxVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.ListBoxVideos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBoxVideos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListBoxVideos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxVideos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ListBoxVideos.FormattingEnabled = true;
            this.ListBoxVideos.HorizontalScrollbar = true;
            this.ListBoxVideos.ItemHeight = 22;
            this.ListBoxVideos.Location = new System.Drawing.Point(0, 393);
            this.ListBoxVideos.Name = "ListBoxVideos";
            this.ListBoxVideos.Size = new System.Drawing.Size(842, 154);
            this.ListBoxVideos.TabIndex = 6;
            this.ListBoxVideos.DoubleClick += new System.EventHandler(this.Videos_DoubleClick);
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vlcControl1.Location = new System.Drawing.Point(0, 0);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(842, 393);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 2;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            this.vlcControl1.PositionChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs>(this.vlcControl1_PositionChanged);
            this.vlcControl1.Click += new System.EventHandler(this.vlcControl1_Click);
            // 
            // panelPlayer
            // 
            this.panelPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.panelPlayer.Controls.Add(this.labelNombreArchivo);
            this.panelPlayer.Controls.Add(this.pictureBox2);
            this.panelPlayer.Controls.Add(this.macTrackBar2);
            this.panelPlayer.Controls.Add(this.macTrackBar1);
            this.panelPlayer.Controls.Add(this.button20);
            this.panelPlayer.Controls.Add(this.button19);
            this.panelPlayer.Controls.Add(this.button18);
            this.panelPlayer.Controls.Add(this.button24);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(0, 547);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(842, 139);
            this.panelPlayer.TabIndex = 5;
            this.panelPlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPlayer_Paint);
            // 
            // labelNombreArchivo
            // 
            this.labelNombreArchivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNombreArchivo.AutoSize = true;
            this.labelNombreArchivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreArchivo.Location = new System.Drawing.Point(34, 56);
            this.labelNombreArchivo.Name = "labelNombreArchivo";
            this.labelNombreArchivo.Size = new System.Drawing.Size(0, 13);
            this.labelNombreArchivo.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Proyecto_Reproductor.Properties.Resources.sonido;
            this.pictureBox2.Location = new System.Drawing.Point(505, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // macTrackBar2
            // 
            this.macTrackBar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.macTrackBar2.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBar2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.macTrackBar2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar2.IndentHeight = 6;
            this.macTrackBar2.Location = new System.Drawing.Point(550, 56);
            this.macTrackBar2.Maximum = 10;
            this.macTrackBar2.Minimum = 0;
            this.macTrackBar2.Name = "macTrackBar2";
            this.macTrackBar2.Size = new System.Drawing.Size(129, 21);
            this.macTrackBar2.TabIndex = 7;
            this.macTrackBar2.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar2.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackBar2.TickHeight = 4;
            this.macTrackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar2.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.macTrackBar2.TrackerSize = new System.Drawing.Size(8, 9);
            this.macTrackBar2.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar2.TrackLineHeight = 3;
            this.macTrackBar2.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar2.Value = 0;
            this.macTrackBar2.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar2_ValueChanged);
            // 
            // macTrackBar1
            // 
            this.macTrackBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.macTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBar1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.macTrackBar1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar1.IndentHeight = 6;
            this.macTrackBar1.Location = new System.Drawing.Point(88, 88);
            this.macTrackBar1.Maximum = 10;
            this.macTrackBar1.Minimum = 0;
            this.macTrackBar1.Name = "macTrackBar1";
            this.macTrackBar1.Size = new System.Drawing.Size(644, 28);
            this.macTrackBar1.TabIndex = 6;
            this.macTrackBar1.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(10)))), ((int)(((byte)(70)))));
            this.macTrackBar1.TickHeight = 4;
            this.macTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar1.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.macTrackBar1.TrackerSize = new System.Drawing.Size(16, 16);
            this.macTrackBar1.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar1.TrackLineHeight = 3;
            this.macTrackBar1.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar1.Value = 0;
            this.macTrackBar1.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar1_ValueChanged);
            // 
            // button20
            // 
            this.button20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button20.BackgroundImage = global::Proyecto_Reproductor.Properties.Resources.siguiente;
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(424, 43);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(43, 45);
            this.button20.TabIndex = 3;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button19.BackgroundImage = global::Proyecto_Reproductor.Properties.Resources.pausa__1_;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(372, 43);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(46, 44);
            this.button19.TabIndex = 2;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button18.BackgroundImage = global::Proyecto_Reproductor.Properties.Resources.atras;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(314, 43);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(47, 45);
            this.button18.TabIndex = 1;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button24
            // 
            this.button24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button24.BackgroundImage = global::Proyecto_Reproductor.Properties.Resources.tocar;
            this.button24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Location = new System.Drawing.Point(373, 46);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(46, 41);
            this.button24.TabIndex = 9;
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mp4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(22)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(842, 686);
            this.Controls.Add(this.vlcControl1);
            this.Controls.Add(this.ListBoxVideos);
            this.Controls.Add(this.panelPlayer);
            this.Name = "mp4";
            this.Text = "mp4";
            this.Load += new System.EventHandler(this.mp4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxVideos;
        public Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button24;
        private XComponent.SliderBar.MACTrackBar macTrackBar2;
        private XComponent.SliderBar.MACTrackBar macTrackBar1;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label labelNombreArchivo;
        private System.Windows.Forms.Timer timer1;
    }
}