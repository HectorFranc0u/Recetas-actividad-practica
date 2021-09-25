
namespace Recetas_actividad_practica
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.txbprecio = new System.Windows.Forms.TextBox();
            this.txbtipo = new System.Windows.Forms.TextBox();
            this.txbautor = new System.Windows.Forms.TextBox();
            this.dgvrecetas = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbingredientes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(40, 49);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(160, 21);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre de la receta";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(521, 49);
            this.lblprecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(147, 21);
            this.lblprecio.TabIndex = 1;
            this.lblprecio.Text = "Precio de la receta";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(40, 104);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(117, 21);
            this.lbltipo.TabIndex = 2;
            this.lbltipo.Text = "Tipo de receta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor de la receta";
            // 
            // txtbname
            // 
            this.txtbname.Location = new System.Drawing.Point(242, 46);
            this.txtbname.Margin = new System.Windows.Forms.Padding(4);
            this.txtbname.Name = "txtbname";
            this.txtbname.Size = new System.Drawing.Size(178, 28);
            this.txtbname.TabIndex = 4;
            // 
            // txbprecio
            // 
            this.txbprecio.Location = new System.Drawing.Point(699, 46);
            this.txbprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txbprecio.Name = "txbprecio";
            this.txbprecio.Size = new System.Drawing.Size(178, 28);
            this.txbprecio.TabIndex = 5;
            // 
            // txbtipo
            // 
            this.txbtipo.Location = new System.Drawing.Point(242, 101);
            this.txbtipo.Margin = new System.Windows.Forms.Padding(4);
            this.txbtipo.Name = "txbtipo";
            this.txbtipo.Size = new System.Drawing.Size(178, 28);
            this.txbtipo.TabIndex = 6;
            // 
            // txbautor
            // 
            this.txbautor.Location = new System.Drawing.Point(699, 101);
            this.txbautor.Margin = new System.Windows.Forms.Padding(4);
            this.txbautor.Name = "txbautor";
            this.txbautor.Size = new System.Drawing.Size(178, 28);
            this.txbautor.TabIndex = 7;
            // 
            // dgvrecetas
            // 
            this.dgvrecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrecetas.Location = new System.Drawing.Point(44, 217);
            this.dgvrecetas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvrecetas.Name = "dgvrecetas";
            this.dgvrecetas.RowHeadersWidth = 51;
            this.dgvrecetas.RowTemplate.Height = 24;
            this.dgvrecetas.Size = new System.Drawing.Size(833, 224);
            this.dgvrecetas.TabIndex = 8;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(699, 140);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(178, 51);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "AGREGAR";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingredientes de la receta";
            // 
            // txbingredientes
            // 
            this.txbingredientes.Location = new System.Drawing.Point(242, 152);
            this.txbingredientes.Margin = new System.Windows.Forms.Padding(4);
            this.txbingredientes.Name = "txbingredientes";
            this.txbingredientes.Size = new System.Drawing.Size(178, 28);
            this.txbingredientes.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 458);
            this.Controls.Add(this.txbingredientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvrecetas);
            this.Controls.Add(this.txbautor);
            this.Controls.Add(this.txbtipo);
            this.Controls.Add(this.txbprecio);
            this.Controls.Add(this.txtbname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblnombre);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrecetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.TextBox txbprecio;
        private System.Windows.Forms.TextBox txbtipo;
        private System.Windows.Forms.TextBox txbautor;
        private System.Windows.Forms.DataGridView dgvrecetas;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbingredientes;
    }
}

