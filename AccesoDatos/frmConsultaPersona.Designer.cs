
namespace AccesoDatos
{
    partial class frmConsultaPersona
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
            this.txtMostrarCe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMostrarNoyAp = new System.Windows.Forms.TextBox();
            this.datotiempos = new System.Windows.Forms.DateTimePicker();
            this.txtMostrarPe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMostrarCe
            // 
            this.txtMostrarCe.Location = new System.Drawing.Point(182, 91);
            this.txtMostrarCe.Name = "txtMostrarCe";
            this.txtMostrarCe.Size = new System.Drawing.Size(150, 20);
            this.txtMostrarCe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres completos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Peso:";
            // 
            // txtMostrarNoyAp
            // 
            this.txtMostrarNoyAp.Location = new System.Drawing.Point(182, 180);
            this.txtMostrarNoyAp.Name = "txtMostrarNoyAp";
            this.txtMostrarNoyAp.Size = new System.Drawing.Size(150, 20);
            this.txtMostrarNoyAp.TabIndex = 5;
            // 
            // datotiempos
            // 
            this.datotiempos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datotiempos.Location = new System.Drawing.Point(182, 262);
            this.datotiempos.MaxDate = new System.DateTime(2022, 1, 9, 0, 0, 0, 0);
            this.datotiempos.MinDate = new System.DateTime(1855, 7, 12, 0, 0, 0, 0);
            this.datotiempos.Name = "datotiempos";
            this.datotiempos.Size = new System.Drawing.Size(150, 20);
            this.datotiempos.TabIndex = 6;
            this.datotiempos.Value = new System.DateTime(2022, 1, 9, 0, 0, 0, 0);
            // 
            // txtMostrarPe
            // 
            this.txtMostrarPe.Location = new System.Drawing.Point(182, 352);
            this.txtMostrarPe.Name = "txtMostrarPe";
            this.txtMostrarPe.Size = new System.Drawing.Size(150, 20);
            this.txtMostrarPe.TabIndex = 7;
            // 
            // frmConsultaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMostrarPe);
            this.Controls.Add(this.datotiempos);
            this.Controls.Add(this.txtMostrarNoyAp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMostrarCe);
            this.Name = "frmConsultaPersona";
            this.Text = "Consulta de persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMostrarCe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMostrarNoyAp;
        private System.Windows.Forms.DateTimePicker datotiempos;
        private System.Windows.Forms.TextBox txtMostrarPe;
    }
}