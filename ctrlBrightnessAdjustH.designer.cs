namespace Elsoft.Screen
{
    partial class ctrlBrightnessAdjustH
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlBrightnessAdjustH));
            this.pbVol = new System.Windows.Forms.PictureBox();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.btnAdj = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.lblLevelPct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVol
            // 
            this.pbVol.BackColor = System.Drawing.Color.Transparent;
            this.pbVol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbVol.Image = ((System.Drawing.Image)(resources.GetObject("pbVol.Image")));
            this.pbVol.Location = new System.Drawing.Point(0, 0);
            this.pbVol.Name = "pbVol";
            this.pbVol.Size = new System.Drawing.Size(224, 53);
            this.pbVol.TabIndex = 0;
            this.pbVol.TabStop = false;
            this.pbVol.Click += new System.EventHandler(this.pbVol_Click);
            // 
            // tmrMove
            // 
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // btnAdj
            // 
            this.btnAdj.BackColor = System.Drawing.Color.Gray;
            this.btnAdj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdj.Image = ((System.Drawing.Image)(resources.GetObject("btnAdj.Image")));
            this.btnAdj.Location = new System.Drawing.Point(140, 0);
            this.btnAdj.Name = "btnAdj";
            this.btnAdj.Size = new System.Drawing.Size(18, 52);
            this.btnAdj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdj.TabIndex = 1;
            this.btnAdj.TabStop = false;
            this.btnAdj.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdj_MouseDown);
            this.btnAdj.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAdj_MouseUp);
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(0, 0);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(224, 53);
            this.pbBack.TabIndex = 2;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // lblLevelPct
            // 
            this.lblLevelPct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelPct.Location = new System.Drawing.Point(224, 0);
            this.lblLevelPct.Name = "lblLevelPct";
            this.lblLevelPct.Size = new System.Drawing.Size(60, 53);
            this.lblLevelPct.TabIndex = 3;
            this.lblLevelPct.Text = "100%";
            this.lblLevelPct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlBrightnessAdjustH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.lblLevelPct);
            this.Controls.Add(this.btnAdj);
            this.Controls.Add(this.pbVol);
            this.Controls.Add(this.pbBack);
            this.DoubleBuffered = true;
            this.Name = "ctrlBrightnessAdjustH";
            this.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.Size = new System.Drawing.Size(284, 53);
            ((System.ComponentModel.ISupportInitialize)(this.pbVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVol;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.PictureBox btnAdj;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Label lblLevelPct;
    }
}
