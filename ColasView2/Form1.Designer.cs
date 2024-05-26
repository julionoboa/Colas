namespace ColasView2
{
    partial class Form1
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
            this.carnetTxt = new System.Windows.Forms.TextBox();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.salarioTxt = new System.Windows.Forms.TextBox();
            this.registrarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.salirBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datosGroupBox = new System.Windows.Forms.GroupBox();
            this.carnetLbl = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.salarioLbl = new System.Windows.Forms.Label();
            this.fechaLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.datosGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // carnetTxt
            // 
            this.carnetTxt.Location = new System.Drawing.Point(118, 29);
            this.carnetTxt.Name = "carnetTxt";
            this.carnetTxt.Size = new System.Drawing.Size(100, 20);
            this.carnetTxt.TabIndex = 0;
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(118, 55);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(100, 20);
            this.nombreTxt.TabIndex = 1;
            // 
            // salarioTxt
            // 
            this.salarioTxt.Location = new System.Drawing.Point(118, 81);
            this.salarioTxt.Name = "salarioTxt";
            this.salarioTxt.Size = new System.Drawing.Size(100, 20);
            this.salarioTxt.TabIndex = 2;
            // 
            // registrarBtn
            // 
            this.registrarBtn.Location = new System.Drawing.Point(443, 44);
            this.registrarBtn.Name = "registrarBtn";
            this.registrarBtn.Size = new System.Drawing.Size(75, 23);
            this.registrarBtn.TabIndex = 3;
            this.registrarBtn.Text = "Registrar";
            this.registrarBtn.UseVisualStyleBackColor = true;
            this.registrarBtn.Click += new System.EventHandler(this.registrarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(443, 74);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 4;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // salirBtn
            // 
            this.salirBtn.Location = new System.Drawing.Point(443, 106);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(75, 23);
            this.salirBtn.TabIndex = 5;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Location = new System.Drawing.Point(118, 111);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 7;
            // 
            // datosGroupBox
            // 
            this.datosGroupBox.Controls.Add(this.fechaLbl);
            this.datosGroupBox.Controls.Add(this.carnetTxt);
            this.datosGroupBox.Controls.Add(this.salarioLbl);
            this.datosGroupBox.Controls.Add(this.nombreTxt);
            this.datosGroupBox.Controls.Add(this.nombreLbl);
            this.datosGroupBox.Controls.Add(this.salarioTxt);
            this.datosGroupBox.Controls.Add(this.carnetLbl);
            this.datosGroupBox.Controls.Add(this.fechaDateTimePicker);
            this.datosGroupBox.Location = new System.Drawing.Point(84, 22);
            this.datosGroupBox.Name = "datosGroupBox";
            this.datosGroupBox.Size = new System.Drawing.Size(353, 156);
            this.datosGroupBox.TabIndex = 8;
            this.datosGroupBox.TabStop = false;
            this.datosGroupBox.Text = "Datos";
            // 
            // carnetLbl
            // 
            this.carnetLbl.AutoSize = true;
            this.carnetLbl.Location = new System.Drawing.Point(65, 32);
            this.carnetLbl.Name = "carnetLbl";
            this.carnetLbl.Size = new System.Drawing.Size(38, 13);
            this.carnetLbl.TabIndex = 9;
            this.carnetLbl.Text = "Carnet";
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Location = new System.Drawing.Point(65, 58);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(44, 13);
            this.nombreLbl.TabIndex = 10;
            this.nombreLbl.Text = "Nombre";
            // 
            // salarioLbl
            // 
            this.salarioLbl.AutoSize = true;
            this.salarioLbl.Location = new System.Drawing.Point(65, 84);
            this.salarioLbl.Name = "salarioLbl";
            this.salarioLbl.Size = new System.Drawing.Size(39, 13);
            this.salarioLbl.TabIndex = 11;
            this.salarioLbl.Text = "Salario";
            this.salarioLbl.Click += new System.EventHandler(this.salarioLbl_Click);
            // 
            // fechaLbl
            // 
            this.fechaLbl.AutoSize = true;
            this.fechaLbl.Location = new System.Drawing.Point(65, 111);
            this.fechaLbl.Name = "fechaLbl";
            this.fechaLbl.Size = new System.Drawing.Size(37, 13);
            this.fechaLbl.TabIndex = 12;
            this.fechaLbl.Text = "Fecha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 404);
            this.Controls.Add(this.datosGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.registrarBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.datosGroupBox.ResumeLayout(false);
            this.datosGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox carnetTxt;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox salarioTxt;
        private System.Windows.Forms.Button registrarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.GroupBox datosGroupBox;
        private System.Windows.Forms.Label carnetLbl;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label salarioLbl;
        private System.Windows.Forms.Label fechaLbl;
    }
}

