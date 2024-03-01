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
            label1 = new Label();
            btnAlquilardvd = new Button();
            btndevolver = new Button();
            btnpagaralquiler = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 39);
            label1.Name = "label1";
            label1.Size = new Size(153, 33);
            label1.TabIndex = 0;
            label1.Text = "DVD RENT";
            // 
            // btnAlquilardvd
            // 
            btnAlquilardvd.Location = new Point(153, 92);
            btnAlquilardvd.Name = "btnAlquilardvd";
            btnAlquilardvd.Size = new Size(132, 23);
            btnAlquilardvd.TabIndex = 1;
            btnAlquilardvd.Text = "Alquilar DVD's";
            btnAlquilardvd.UseVisualStyleBackColor = true;
            btnAlquilardvd.Click += btnAlquilardvd_Click;
            // 
            // btndevolver
            // 
            btndevolver.Location = new Point(185, 130);
            btndevolver.Name = "btndevolver";
            btndevolver.Size = new Size(75, 23);
            btndevolver.TabIndex = 2;
            btndevolver.Text = "Devolver";
            btndevolver.UseVisualStyleBackColor = true;
            // 
            // btnpagaralquiler
            // 
            btnpagaralquiler.Location = new Point(153, 171);
            btnpagaralquiler.Name = "btnpagaralquiler";
            btnpagaralquiler.Size = new Size(143, 23);
            btnpagaralquiler.TabIndex = 3;
            btnpagaralquiler.Text = "Pagar por el Alquiler";
            btnpagaralquiler.UseVisualStyleBackColor = true;
            btnpagaralquiler.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(185, 215);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 4;
            button1.Text = "Historial Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(311, 256);
            button2.Name = "button2";
            button2.Size = new Size(144, 23);
            button2.TabIndex = 5;
            button2.Text = "Regresar Principal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ClienteMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 307);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnpagaralquiler);
            Controls.Add(btndevolver);
            Controls.Add(btnAlquilardvd);
            Controls.Add(label1);
            Name = "ClienteMenu";
            Text = "ClienteMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAlquilardvd;
        private Button btndevolver;
        private Button btnpagaralquiler;
        private Button button1;
        private Button button2;
    }
}