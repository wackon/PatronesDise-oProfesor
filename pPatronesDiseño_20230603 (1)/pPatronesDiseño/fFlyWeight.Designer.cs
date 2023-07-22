namespace pPatronesDiseño
{
    partial class fFlyWeight
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
            this.btnFlyWeight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFlyWeight
            // 
            this.btnFlyWeight.BackColor = System.Drawing.Color.Navy;
            this.btnFlyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlyWeight.ForeColor = System.Drawing.Color.White;
            this.btnFlyWeight.Location = new System.Drawing.Point(290, 33);
            this.btnFlyWeight.Name = "btnFlyWeight";
            this.btnFlyWeight.Size = new System.Drawing.Size(179, 62);
            this.btnFlyWeight.TabIndex = 4;
            this.btnFlyWeight.Text = "FLY WEIGHT";
            this.btnFlyWeight.UseVisualStyleBackColor = false;
            this.btnFlyWeight.Click += new System.EventHandler(this.btnFlyWeight_Click);
            // 
            // fFlyWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFlyWeight);
            this.Name = "fFlyWeight";
            this.Text = "fFlyWeight";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFlyWeight;
    }
}