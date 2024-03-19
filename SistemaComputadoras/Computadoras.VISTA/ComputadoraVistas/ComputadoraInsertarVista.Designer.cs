namespace Computadoras.VISTA.ComputadoraVistas
{
    partial class ComputadoraInsertarVista
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Nombre_txt = new TextBox();
            Descripcion_txt = new TextBox();
            Precio_txt = new TextBox();
            Guardar_btn = new Button();
            Cancelar_btn = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            textBox1 = new TextBox();
            Seleccionar_Btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 76);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 132);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 196);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(35, 258);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 3;
            label4.Text = "Fecha Fabricacion";
            // 
            // Nombre_txt
            // 
            Nombre_txt.Location = new Point(181, 78);
            Nombre_txt.Name = "Nombre_txt";
            Nombre_txt.Size = new Size(447, 23);
            Nombre_txt.TabIndex = 4;
            // 
            // Descripcion_txt
            // 
            Descripcion_txt.Location = new Point(181, 134);
            Descripcion_txt.Name = "Descripcion_txt";
            Descripcion_txt.Size = new Size(447, 23);
            Descripcion_txt.TabIndex = 5;
            // 
            // Precio_txt
            // 
            Precio_txt.Location = new Point(181, 196);
            Precio_txt.Name = "Precio_txt";
            Precio_txt.Size = new Size(447, 23);
            Precio_txt.TabIndex = 6;
            // 
            // Guardar_btn
            // 
            Guardar_btn.Location = new Point(117, 329);
            Guardar_btn.Name = "Guardar_btn";
            Guardar_btn.Size = new Size(122, 51);
            Guardar_btn.TabIndex = 8;
            Guardar_btn.Text = "Guardar";
            Guardar_btn.UseVisualStyleBackColor = true;
            Guardar_btn.Click += Guardar_btn_Click;
            // 
            // Cancelar_btn
            // 
            Cancelar_btn.Location = new Point(437, 329);
            Cancelar_btn.Name = "Cancelar_btn";
            Cancelar_btn.Size = new Size(122, 51);
            Cancelar_btn.TabIndex = 9;
            Cancelar_btn.Text = "Cancelar";
            Cancelar_btn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(181, 257);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(447, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(35, 32);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 11;
            label5.Text = "ID PC";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 23);
            textBox1.TabIndex = 12;
            // 
            // Seleccionar_Btn
            // 
            Seleccionar_Btn.Location = new Point(468, 30);
            Seleccionar_Btn.Name = "Seleccionar_Btn";
            Seleccionar_Btn.Size = new Size(122, 29);
            Seleccionar_Btn.TabIndex = 13;
            Seleccionar_Btn.Text = "Seleccionar";
            Seleccionar_Btn.UseVisualStyleBackColor = true;
            Seleccionar_Btn.Click += Seleccionar_Btn_Click;
            // 
            // ComputadoraInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 457);
            Controls.Add(Seleccionar_Btn);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(Cancelar_btn);
            Controls.Add(Guardar_btn);
            Controls.Add(Precio_txt);
            Controls.Add(Descripcion_txt);
            Controls.Add(Nombre_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ComputadoraInsertarVista";
            Text = "ComputadoraInsertarVista";
            Load += ComputadoraInsertarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nombre_txt;
        private TextBox Descripcion_txt;
        private TextBox Precio_txt;
        private Button Guardar_btn;
        private Button Cancelar_btn;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private TextBox textBox1;
        private Button Seleccionar_Btn;
    }
}