namespace Proyecto
{
    partial class Historial_del_Cliente
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
            textBox1 = new TextBox();
            dataHistorial = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            Limpiar = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataHistorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 67);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar por Id";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(450, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 10;
            // 
            // dataHistorial
            // 
            dataHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataHistorial.Location = new Point(96, 131);
            dataHistorial.Name = "dataHistorial";
            dataHistorial.RowTemplate.Height = 25;
            dataHistorial.Size = new Size(738, 216);
            dataHistorial.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(759, 643);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(611, 67);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(692, 67);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 24;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(96, 409);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(738, 203);
            dataGridView1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 103);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 26;
            label2.Text = "LISTADON DE CLIENTES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 381);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 27;
            label3.Text = "PELICULAS ALQUILADAS";
            // 
            // Historial_del_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 713);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(Limpiar);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(dataHistorial);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Historial_del_Cliente";
            Text = "Historial_del_Cliente";
            ((System.ComponentModel.ISupportInitialize)dataHistorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DataGridView dataHistorial;
        private Button button2;
        private Button button1;
        private Button Limpiar;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
    }
}