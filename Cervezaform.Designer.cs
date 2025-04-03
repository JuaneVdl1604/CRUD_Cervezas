namespace CRUD
{
    partial class Cervezaform
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
            txtID = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtEstilo = new TextBox();
            label3 = new Label();
            txtAlcohol = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            btnCancelar = new Button();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(202, 45);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 45);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(202, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 95);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txtEstilo
            // 
            txtEstilo.Location = new Point(202, 152);
            txtEstilo.Name = "txtEstilo";
            txtEstilo.Size = new Size(150, 31);
            txtEstilo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 152);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 1;
            label3.Text = "Estilo";
            // 
            // txtAlcohol
            // 
            txtAlcohol.Location = new Point(202, 212);
            txtAlcohol.Name = "txtAlcohol";
            txtAlcohol.Size = new Size(150, 31);
            txtAlcohol.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 212);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 1;
            label4.Text = "Alcohol";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(202, 273);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 273);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 1;
            label5.Text = "Precio";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(344, 347);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(70, 347);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Cervezaform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 450);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(txtAlcohol);
            Controls.Add(label3);
            Controls.Add(txtEstilo);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(txtID);
            Name = "Cervezaform";
            Text = "Cervezaform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtEstilo;
        private Label label3;
        private TextBox txtAlcohol;
        private Label label4;
        private TextBox txtPrecio;
        private Label label5;
        private Button btnCancelar;
        private Button btnAgregar;
    }
}