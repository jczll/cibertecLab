namespace Chinook.UI.Windows
{
    partial class FrmTracks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarTrack = new System.Windows.Forms.TextBox();
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ClmTrackId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAlbumTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRACK NAME  :  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txtBuscarTrack
            // 
            this.txtBuscarTrack.Location = new System.Drawing.Point(102, 11);
            this.txtBuscarTrack.Name = "txtBuscarTrack";
            this.txtBuscarTrack.Size = new System.Drawing.Size(279, 20);
            this.txtBuscarTrack.TabIndex = 2;
            // 
            // dgvTracks
            // 
            this.dgvTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmTrackId,
            this.ClmAlbumTitle,
            this.ClmArtistName,
            this.ClmTrackName,
            this.ClmUnitPrice});
            this.dgvTracks.Location = new System.Drawing.Point(9, 43);
            this.dgvTracks.Name = "dgvTracks";
            this.dgvTracks.Size = new System.Drawing.Size(566, 150);
            this.dgvTracks.TabIndex = 4;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.Green;
            this.btnSeleccionar.Location = new System.Drawing.Point(437, 201);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(131, 26);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "SELECCIONAR ";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(387, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "BUSCAR ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClmTrackId
            // 
            this.ClmTrackId.DataPropertyName = "TrackId";
            this.ClmTrackId.HeaderText = "Track Id";
            this.ClmTrackId.Name = "ClmTrackId";
            this.ClmTrackId.Width = 40;
            // 
            // ClmAlbumTitle
            // 
            this.ClmAlbumTitle.DataPropertyName = "Album_title";
            this.ClmAlbumTitle.HeaderText = "Titulo del Album";
            this.ClmAlbumTitle.Name = "ClmAlbumTitle";
            // 
            // ClmArtistName
            // 
            this.ClmArtistName.DataPropertyName = "Artist_name";
            this.ClmArtistName.HeaderText = "Artista";
            this.ClmArtistName.Name = "ClmArtistName";
            // 
            // ClmTrackName
            // 
            this.ClmTrackName.DataPropertyName = "Track_name";
            this.ClmTrackName.HeaderText = "Nombre del Track";
            this.ClmTrackName.Name = "ClmTrackName";
            this.ClmTrackName.Width = 200;
            // 
            // ClmUnitPrice
            // 
            this.ClmUnitPrice.DataPropertyName = "UnitPrice";
            this.ClmUnitPrice.HeaderText = "Precio Unitario";
            this.ClmUnitPrice.Name = "ClmUnitPrice";
            this.ClmUnitPrice.Width = 80;
            // 
            // FrmTracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvTracks);
            this.Controls.Add(this.txtBuscarTrack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTracks";
            this.Text = "SELECCIONAR TRACKS";
            this.Load += new System.EventHandler(this.FrmTracks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarTrack;
        private System.Windows.Forms.DataGridView dgvTracks;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTrackId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmAlbumTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmArtistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTrackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmUnitPrice;
    }
}