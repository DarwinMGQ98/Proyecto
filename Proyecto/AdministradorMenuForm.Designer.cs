namespace Proyecto
{
    partial class AdministradorMenuForm
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
            this.btnIngresardvds = new System.Windows.Forms.Button();
            this.btneliminardvd = new System.Windows.Forms.Button();
            this.btnlistadodirector = new System.Windows.Forms.Button();
            this.btnordenadogenero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(137, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "DVD RENT";
            // 
            // btnIngresardvds
            // 
            this.btnIngresardvds.Location = new System.Drawing.Point(146, 116);
            this.btnIngresardvds.Name = "btnIngresardvds";
            this.btnIngresardvds.Size = new System.Drawing.Size(125, 23);
            this.btnIngresardvds.TabIndex = 1;
            this.btnIngresardvds.Text = "Ingresar DVD\'s";
            this.btnIngresardvds.UseVisualStyleBackColor = true;
            this.btnIngresardvds.Click += new System.EventHandler(this.btnIngresardvds_Click);
            // 
            // btneliminardvd
            // 
            this.btneliminardvd.Location = new System.Drawing.Point(146, 167);
            this.btneliminardvd.Name = "btneliminardvd";
            this.btneliminardvd.Size = new System.Drawing.Size(117, 23);
            this.btneliminardvd.TabIndex = 2;
            this.btneliminardvd.Text = "Eliminar DVD\'s";
            this.btneliminardvd.UseVisualStyleBackColor = true;
            this.btneliminardvd.Click += new System.EventHandler(this.btneliminardvd_Click);
            // 
            // btnlistadodirector
            // 
            this.btnlistadodirector.Location = new System.Drawing.Point(146, 231);
            this.btnlistadodirector.Name = "btnlistadodirector";
            this.btnlistadodirector.Size = new System.Drawing.Size(127, 23);
            this.btnlistadodirector.TabIndex = 3;
            this.btnlistadodirector.Text = "Listo Por Director";
            this.btnlistadodirector.UseVisualStyleBackColor = true;
            this.btnlistadodirector.Click += new System.EventHandler(this.btnlistadodirector_Click);
            // 
            // btnordenadogenero
            // 
            this.btnordenadogenero.Location = new System.Drawing.Point(137, 302);
            this.btnordenadogenero.Name = "btnordenadogenero";
            this.btnordenadogenero.Size = new System.Drawing.Size(144, 23);
            this.btnordenadogenero.TabIndex = 4;
            this.btnordenadogenero.Text = "Ordenado Por Genero";
            this.btnordenadogenero.UseVisualStyleBackColor = true;
            this.btnordenadogenero.Click += new System.EventHandler(this.btnordenadogenero_Click);
            // 
            // AdministradorMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 429);
            this.Controls.Add(this.btnordenadogenero);
            this.Controls.Add(this.btnlistadodirector);
            this.Controls.Add(this.btneliminardvd);
            this.Controls.Add(this.btnIngresardvds);
            this.Controls.Add(this.label1);
            this.Name = "AdministradorMenuForm";
            this.Text = "AdministradorMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnIngresardvds;
        private Button btneliminardvd;
        private Button btnlistadodirector;
        private Button btnordenadogenero;
    }
}