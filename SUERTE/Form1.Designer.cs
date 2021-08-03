namespace SUERTE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.labelPrimero = new System.Windows.Forms.Label();
            this.labelSegundo = new System.Windows.Forms.Label();
            this.labelSigno = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(210, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 60);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPrimero
            // 
            this.labelPrimero.AutoSize = true;
            this.labelPrimero.BackColor = System.Drawing.Color.Transparent;
            this.labelPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrimero.Location = new System.Drawing.Point(341, 88);
            this.labelPrimero.Name = "labelPrimero";
            this.labelPrimero.Size = new System.Drawing.Size(99, 76);
            this.labelPrimero.TabIndex = 1;
            this.labelPrimero.Text = "n°";
            this.labelPrimero.Visible = false;
            // 
            // labelSegundo
            // 
            this.labelSegundo.AutoSize = true;
            this.labelSegundo.BackColor = System.Drawing.Color.Transparent;
            this.labelSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSegundo.Location = new System.Drawing.Point(215, 88);
            this.labelSegundo.Name = "labelSegundo";
            this.labelSegundo.Size = new System.Drawing.Size(99, 76);
            this.labelSegundo.TabIndex = 2;
            this.labelSegundo.Text = "n°";
            this.labelSegundo.Visible = false;
            // 
            // labelSigno
            // 
            this.labelSigno.AutoSize = true;
            this.labelSigno.BackColor = System.Drawing.Color.Transparent;
            this.labelSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSigno.Location = new System.Drawing.Point(74, 85);
            this.labelSigno.Name = "labelSigno";
            this.labelSigno.Size = new System.Drawing.Size(116, 76);
            this.labelSigno.TabIndex = 3;
            this.labelSigno.Text = "+/-";
            this.labelSigno.Visible = false;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxResultado.Location = new System.Drawing.Point(176, 38);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(148, 31);
            this.textBoxResultado.TabIndex = 4;
            this.textBoxResultado.Text = "TU ULTIMO RESULTADO ES:\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 249);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.labelSigno);
            this.Controls.Add(this.labelSegundo);
            this.Controls.Add(this.labelPrimero);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPrimero;
        private System.Windows.Forms.Label labelSegundo;
        private System.Windows.Forms.Label labelSigno;
        private System.Windows.Forms.TextBox textBoxResultado;
    }
}

