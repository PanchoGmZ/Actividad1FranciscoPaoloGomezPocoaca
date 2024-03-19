namespace Computadoras.VISTA.ComputadoraVistas
{
    partial class ComputadoraEditarVistas
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
            dateTimePicker1 = new DateTimePicker();
            Cancelar_btn = new Button();
            Guardar_btn = new Button();
            Precio_txt = new TextBox();
            Descripcion_txt = new TextBox();
            Nombre_txt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(171, 220);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(447, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // Cancelar_btn
            // 
            Cancelar_btn.Location = new Point(427, 292);
            Cancelar_btn.Name = "Cancelar_btn";
            Cancelar_btn.Size = new Size(122, 51);
            Cancelar_btn.TabIndex = 19;
            Cancelar_btn.Text = "Cancelar";
            Cancelar_btn.UseVisualStyleBackColor = true;
            // 
            // Guardar_btn
            // 
            Guardar_btn.Location = new Point(107, 292);
            Guardar_btn.Name = "Guardar_btn";
            Guardar_btn.Size = new Size(122, 51);
            Guardar_btn.TabIndex = 18;
            Guardar_btn.Text = "Guardar";
            Guardar_btn.UseVisualStyleBackColor = true;
            // 
            // Precio_txt
            // 
            Precio_txt.Location = new Point(171, 159);
            Precio_txt.Name = "Precio_txt";
            Precio_txt.Size = new Size(447, 23);
            Precio_txt.TabIndex = 17;
            // 
            // Descripcion_txt
            // 
            Descripcion_txt.Location = new Point(171, 97);
            Descripcion_txt.Name = "Descripcion_txt";
            Descripcion_txt.Size = new Size(447, 23);
            Descripcion_txt.TabIndex = 16;
            // 
            // Nombre_txt
            // 
            Nombre_txt.Location = new Point(171, 41);
            Nombre_txt.Name = "Nombre_txt";
            Nombre_txt.Size = new Size(447, 23);
            Nombre_txt.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 221);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 14;
            label4.Text = "Fecha Fabricacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 159);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 13;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 95);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 12;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 11;
            label1.Text = "Nombre";
            // 
            // ComputadoraEditarVistas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 408);
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
            Name = "ComputadoraEditarVistas";
            Text = "ComputadoraEditarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button Cancelar_btn;
        private Button Guardar_btn;
        private TextBox Precio_txt;
        private TextBox Descripcion_txt;
        private TextBox Nombre_txt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}