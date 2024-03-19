namespace Computadoras.VISTA.ComputadoraVistas
{
    partial class ComputadoraListarVista
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
            dataGridView1 = new DataGridView();
            Agregar_Btn = new Button();
            Editar_btn = new Button();
            Eliminar_btn = new Button();
            Seleccionar_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(643, 336);
            dataGridView1.TabIndex = 0;
            // 
            // Agregar_Btn
            // 
            Agregar_Btn.Location = new Point(46, 383);
            Agregar_Btn.Name = "Agregar_Btn";
            Agregar_Btn.Size = new Size(111, 34);
            Agregar_Btn.TabIndex = 1;
            Agregar_Btn.Text = "Agregar";
            Agregar_Btn.UseVisualStyleBackColor = true;
            Agregar_Btn.Click += Agregar_Btn_Click;
            // 
            // Editar_btn
            // 
            Editar_btn.Location = new Point(194, 383);
            Editar_btn.Name = "Editar_btn";
            Editar_btn.Size = new Size(112, 34);
            Editar_btn.TabIndex = 2;
            Editar_btn.Text = "Editar";
            Editar_btn.UseVisualStyleBackColor = true;
            Editar_btn.Click += Editar_btn_Click;
            // 
            // Eliminar_btn
            // 
            Eliminar_btn.Location = new Point(351, 383);
            Eliminar_btn.Name = "Eliminar_btn";
            Eliminar_btn.Size = new Size(112, 34);
            Eliminar_btn.TabIndex = 3;
            Eliminar_btn.Text = "Eliminar";
            Eliminar_btn.UseVisualStyleBackColor = true;
            // 
            // Seleccionar_btn
            // 
            Seleccionar_btn.Location = new Point(514, 383);
            Seleccionar_btn.Name = "Seleccionar_btn";
            Seleccionar_btn.Size = new Size(112, 34);
            Seleccionar_btn.TabIndex = 4;
            Seleccionar_btn.Text = "Seleccionar";
            Seleccionar_btn.UseVisualStyleBackColor = true;
            Seleccionar_btn.Click += Seleccionar_btn_Click;
            // 
            // ComputadoraListarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 465);
            Controls.Add(Seleccionar_btn);
            Controls.Add(Eliminar_btn);
            Controls.Add(Editar_btn);
            Controls.Add(Agregar_Btn);
            Controls.Add(dataGridView1);
            Name = "ComputadoraListarVista";
            Text = "ComputadoraListarVista";
            Load += ComputadoraListarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Agregar_Btn;
        private Button Editar_btn;
        private Button Eliminar_btn;
        private Button Seleccionar_btn;
    }
}