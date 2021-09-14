
namespace Pila
{
    partial class frmPila
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnEstaVacia = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblElemento = new System.Windows.Forms.Label();
            this.lblPrimero = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.ItemHeight = 15;
            this.lstElementos.Location = new System.Drawing.Point(28, 54);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(196, 229);
            this.lstElementos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(28, 289);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(75, 23);
            this.btnExtraer.TabIndex = 2;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(149, 289);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnPrimero.TabIndex = 3;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnEstaVacia
            // 
            this.btnEstaVacia.Location = new System.Drawing.Point(243, 54);
            this.btnEstaVacia.Name = "btnEstaVacia";
            this.btnEstaVacia.Size = new System.Drawing.Size(75, 23);
            this.btnEstaVacia.TabIndex = 4;
            this.btnEstaVacia.Text = "Estado";
            this.btnEstaVacia.UseVisualStyleBackColor = false;
            this.btnEstaVacia.Click += new System.EventHandler(this.btnEstaVacia_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(124, 26);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 23);
            this.txtElemento.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(243, 91);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(87, 15);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Click en estado";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // lblElemento
            // 
            this.lblElemento.AutoSize = true;
            this.lblElemento.Location = new System.Drawing.Point(230, 25);
            this.lblElemento.Name = "lblElemento";
            this.lblElemento.Size = new System.Drawing.Size(132, 15);
            this.lblElemento.TabIndex = 8;
            this.lblElemento.Text = "Cantidad de elementos:";
            // 
            // lblPrimero
            // 
            this.lblPrimero.AutoSize = true;
            this.lblPrimero.Location = new System.Drawing.Point(149, 330);
            this.lblPrimero.Name = "lblPrimero";
            this.lblPrimero.Size = new System.Drawing.Size(0, 15);
            this.lblPrimero.TabIndex = 9;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 354);
            this.Controls.Add(this.lblPrimero);
            this.Controls.Add(this.lblElemento);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.btnEstaVacia);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstElementos);
            this.Name = "frmPila";
            this.Text = "Pila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstElementos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnEstaVacia;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblElemento;
        private System.Windows.Forms.Label lblPrimero;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

