namespace pPatronesDiseño
{
    partial class fFacade
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
            this.btnFacade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFacade
            // 
            this.btnFacade.BackColor = System.Drawing.Color.Navy;
            this.btnFacade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacade.ForeColor = System.Drawing.Color.White;
            this.btnFacade.Location = new System.Drawing.Point(279, 48);
            this.btnFacade.Name = "btnFacade";
            this.btnFacade.Size = new System.Drawing.Size(179, 62);
            this.btnFacade.TabIndex = 2;
            this.btnFacade.Text = "FACADE";
            this.btnFacade.UseVisualStyleBackColor = false;
            this.btnFacade.Click += new System.EventHandler(this.btnFacade_Click);
            // 
            // fFacade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFacade);
            this.Name = "fFacade";
            this.Text = "fFacade";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFacade;
    }
}