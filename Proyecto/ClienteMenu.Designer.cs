namespace Proyecto
{
    partial class ClienteMenu
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
            this.btnAlquilardvd = new System.Windows.Forms.Button();
            this.btndevolver = new System.Windows.Forms.Button();
            this.btnpagaralquiler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "DVD RENT";
            // 
            // btnAlquilardvd
            // 
            this.btnAlquilardvd.Location = new System.Drawing.Point(152, 105);
            this.btnAlquilardvd.Name = "btnAlquilardvd";
            this.btnAlquilardvd.Size = new System.Drawing.Size(132, 23);
            this.btnAlquilardvd.TabIndex = 1;
            this.btnAlquilardvd.Text = "Alquilar DVD\'s";
            this.btnAlquilardvd.UseVisualStyleBackColor = true;
            this.btnAlquilardvd.Click += new System.EventHandler(this.btnAlquilardvd_Click);
            // 
            // btndevolver
            // 
            this.btndevolver.Location = new System.Drawing.Point(176, 155);
            this.btndevolver.Name = "btndevolver";
            this.btndevolver.Size = new System.Drawing.Size(75, 23);
            this.btndevolver.TabIndex = 2;
            this.btndevolver.Text = "Devolver";
            this.btndevolver.UseVisualStyleBackColor = true;
            // 
            // btnpagaralquiler
            // 
            this.btnpagaralquiler.Location = new System.Drawing.Point(142, 208);
            this.btnpagaralquiler.Name = "btnpagaralquiler";
            this.btnpagaralquiler.Size = new System.Drawing.Size(143, 23);
            this.btnpagaralquiler.TabIndex = 3;
            this.btnpagaralquiler.Text = "Pagar por el Alquiler";
            this.btnpagaralquiler.UseVisualStyleBackColor = true;
            this.btnpagaralquiler.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClienteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 307);
            this.Controls.Add(this.btnpagaralquiler);
            this.Controls.Add(this.btndevolver);
            this.Controls.Add(this.btnAlquilardvd);
            this.Controls.Add(this.label1);
            this.Name = "ClienteMenu";
            this.Text = "ClienteMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnAlquilardvd;
        private Button btndevolver;
        private Button btnpagaralquiler;
    }
}