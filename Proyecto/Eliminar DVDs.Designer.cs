namespace Proyecto
{
    partial class Eliminar_DVDs
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
            this.dataEliminar = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegresarEli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEliminar
            // 
            this.dataEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEliminar.Location = new System.Drawing.Point(52, 33);
            this.dataEliminar.Name = "dataEliminar";
            this.dataEliminar.RowTemplate.Height = 25;
            this.dataEliminar.Size = new System.Drawing.Size(692, 254);
            this.dataEliminar.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(225, 346);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRegresarEli
            // 
            this.btnRegresarEli.Location = new System.Drawing.Point(424, 346);
            this.btnRegresarEli.Name = "btnRegresarEli";
            this.btnRegresarEli.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarEli.TabIndex = 2;
            this.btnRegresarEli.Text = "Regresar";
            this.btnRegresarEli.UseVisualStyleBackColor = true;
            // 
            // Eliminar_DVDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresarEli);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataEliminar);
            this.Name = "Eliminar_DVDs";
            this.Text = "Eliminar_DVDs";
            ((System.ComponentModel.ISupportInitialize)(this.dataEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataEliminar;
        private Button btnEliminar;
        private Button btnRegresarEli;
    }
}