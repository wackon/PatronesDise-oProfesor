namespace pPatronesDiseño
{
    partial class fDecorator
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
            this.btnDecoratorSin = new System.Windows.Forms.Button();
            this.btnDecoratorCon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDecoratorSin
            // 
            this.btnDecoratorSin.BackColor = System.Drawing.Color.Navy;
            this.btnDecoratorSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecoratorSin.ForeColor = System.Drawing.Color.White;
            this.btnDecoratorSin.Location = new System.Drawing.Point(66, 95);
            this.btnDecoratorSin.Name = "btnDecoratorSin";
            this.btnDecoratorSin.Size = new System.Drawing.Size(231, 105);
            this.btnDecoratorSin.TabIndex = 2;
            this.btnDecoratorSin.Text = "DECORATOR SIN PERMISOS";
            this.btnDecoratorSin.UseVisualStyleBackColor = false;
            this.btnDecoratorSin.Click += new System.EventHandler(this.btnDecoratorSin_Click);
            // 
            // btnDecoratorCon
            // 
            this.btnDecoratorCon.BackColor = System.Drawing.Color.Navy;
            this.btnDecoratorCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecoratorCon.ForeColor = System.Drawing.Color.White;
            this.btnDecoratorCon.Location = new System.Drawing.Point(440, 95);
            this.btnDecoratorCon.Name = "btnDecoratorCon";
            this.btnDecoratorCon.Size = new System.Drawing.Size(231, 105);
            this.btnDecoratorCon.TabIndex = 3;
            this.btnDecoratorCon.Text = "DECORATOR CON PERMISOS";
            this.btnDecoratorCon.UseVisualStyleBackColor = false;
            this.btnDecoratorCon.Click += new System.EventHandler(this.btnDecoratorCon_Click);
            // 
            // fDecorator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecoratorCon);
            this.Controls.Add(this.btnDecoratorSin);
            this.Name = "fDecorator";
            this.Text = "fDecorator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDecoratorSin;
        private System.Windows.Forms.Button btnDecoratorCon;
    }
}