namespace PequenosGuardianes
{
    partial class FormDatosAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosAlumno));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtDomicilio = new TextBox();
            label5 = new Label();
            btnCancelar = new Button();
            btnSiguiente = new Button();
            User = new PictureBox();
            pictureBox1 = new PictureBox();
            txtEdad = new TextBox();
            pictureBox2 = new PictureBox();
            dtpFechaNacimiento = new DateTimePicker();
            label4 = new Label();
            groupBox1 = new GroupBox();
            rbMasculino = new RadioButton();
            rbFemenino = new RadioButton();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)User).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai Medium", 10F);
            label1.Location = new Point(244, 65);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 0;
            label1.Text = "Nombre completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Dubai Medium", 10F);
            label2.Location = new Point(244, 104);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 1;
            label2.Text = "Domicilio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Dubai Medium", 10F);
            label3.Location = new Point(244, 143);
            label3.Name = "label3";
            label3.Size = new Size(54, 30);
            label3.TabIndex = 2;
            label3.Text = "Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Dubai Medium", 9.5F);
            txtNombre.Location = new Point(390, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(222, 35);
            txtNombre.TabIndex = 6;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Font = new Font("Dubai Medium", 9.5F);
            txtDomicilio.Location = new Point(390, 98);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(222, 35);
            txtDomicilio.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 20.16F, FontStyle.Bold);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(244, 3);
            label5.Name = "label5";
            label5.Size = new Size(293, 42);
            label5.TabIndex = 8;
            label5.Text = "Datos personales";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightGray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Dubai Medium", 10F);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(611, 406);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 40);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.ForestGreen;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Dubai Medium", 10F);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(464, 406);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(124, 40);
            btnSiguiente.TabIndex = 12;
            btnSiguiente.Text = "Siguiente ▶";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // User
            // 
            User.Image = (Image)resources.GetObject("User.Image");
            User.Location = new Point(127, 65);
            User.Name = "User";
            User.Size = new Size(111, 109);
            User.SizeMode = PictureBoxSizeMode.Zoom;
            User.TabIndex = 13;
            User.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Dubai Medium", 9.5F);
            txtEdad.Location = new Point(390, 137);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(222, 35);
            txtEdad.TabIndex = 15;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(661, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Dubai Medium", 9.5F);
            dtpFechaNacimiento.Location = new Point(389, 215);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(293, 35);
            dtpFechaNacimiento.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Dubai Medium", 10F);
            label4.Location = new Point(214, 214);
            label4.Name = "label4";
            label4.Size = new Size(169, 30);
            label4.TabIndex = 18;
            label4.Text = "Fecha de nacimiento:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMasculino);
            groupBox1.Controls.Add(rbFemenino);
            groupBox1.Font = new Font("Dubai Medium", 10F);
            groupBox1.Location = new Point(127, 273);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 83);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecciona tu genero:";
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(337, 38);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(109, 34);
            rbMasculino.TabIndex = 1;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(96, 38);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(106, 34);
            rbFemenino.TabIndex = 0;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(673, 342);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(112, 113);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // FormDatosAlumno
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 452);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(pictureBox2);
            Controls.Add(txtEdad);
            Controls.Add(User);
            Controls.Add(btnSiguiente);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(txtDomicilio);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Name = "FormDatosAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDatosAlumno";
            ((System.ComponentModel.ISupportInitialize)User).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNumControl;
        private TextBox txtGrupo;
        private TextBox txtNombre;
        private TextBox txtDomicilio;
        private Label label5;
        private Button button1;
        private Button btnCancelar;
        private Button btnSiguiente;
        private PictureBox User;
        private PictureBox pictureBox1;
        private TextBox txtEdad;
        private PictureBox pictureBox2;
        private DateTimePicker dtpFechaNacimiento;
        private GroupBox groupBox1;
        private RadioButton rbMasculino;
        private RadioButton rbFemenino;
        public PictureBox pictureBox5;
    }
}