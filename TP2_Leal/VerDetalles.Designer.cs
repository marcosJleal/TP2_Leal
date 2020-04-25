namespace TP2_Leal
{
    partial class VerDetalles
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
            this.imagen = new System.Windows.Forms.PictureBox();
            this.txtboxDetalles = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // imagen
            // 
            this.imagen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.imagen.Location = new System.Drawing.Point(260, 12);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(319, 222);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 0;
            this.imagen.TabStop = false;
            // 
            // txtboxDetalles
            // 
            this.txtboxDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDetalles.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtboxDetalles.Location = new System.Drawing.Point(57, 272);
            this.txtboxDetalles.Multiline = true;
            this.txtboxDetalles.Name = "txtboxDetalles";
            this.txtboxDetalles.ReadOnly = true;
            this.txtboxDetalles.Size = new System.Drawing.Size(728, 221);
            this.txtboxDetalles.TabIndex = 1;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDetalles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(54, 253);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(58, 16);
            this.lblDetalles.TabIndex = 2;
            this.lblDetalles.Text = "Detalles";
            // 
            // VerDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(856, 536);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.txtboxDetalles);
            this.Controls.Add(this.imagen);
            this.MinimumSize = new System.Drawing.Size(814, 518);
            this.Name = "VerDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VerDetalles";
            this.Load += new System.EventHandler(this.VerDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.TextBox txtboxDetalles;
        private System.Windows.Forms.Label lblDetalles;
    }
}