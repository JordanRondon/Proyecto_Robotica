namespace ControlRobot
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAnguloGarra = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tkbGarra = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbAnguloBrazo2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tkbBrazo2 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbAnguloBrazo1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tkbBrazo1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbAnguloBase = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tkbBase = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.cmbVelocidad = new System.Windows.Forms.ComboBox();
            this.cmbPuertoSerial = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbGarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrazo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrazo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBase)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 456);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAnguloGarra);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tkbGarra);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lbAnguloBrazo2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tkbBrazo2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbAnguloBrazo1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tkbBrazo1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbAnguloBase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tkbBase);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(285, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posición de ServoMotor";
            // 
            // lbAnguloGarra
            // 
            this.lbAnguloGarra.AutoSize = true;
            this.lbAnguloGarra.Location = new System.Drawing.Point(275, 246);
            this.lbAnguloGarra.Name = "lbAnguloGarra";
            this.lbAnguloGarra.Size = new System.Drawing.Size(17, 13);
            this.lbAnguloGarra.TabIndex = 19;
            this.lbAnguloGarra.Text = "0°";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(178, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Angulo de Garra =";
            // 
            // tkbGarra
            // 
            this.tkbGarra.Location = new System.Drawing.Point(67, 262);
            this.tkbGarra.Maximum = 180;
            this.tkbGarra.Name = "tkbGarra";
            this.tkbGarra.Size = new System.Drawing.Size(360, 45);
            this.tkbGarra.TabIndex = 17;
            this.tkbGarra.Scroll += new System.EventHandler(this.tkbGarra_Scroll);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(433, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "180°";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "0°";
            // 
            // lbAnguloBrazo2
            // 
            this.lbAnguloBrazo2.AutoSize = true;
            this.lbAnguloBrazo2.Location = new System.Drawing.Point(275, 179);
            this.lbAnguloBrazo2.Name = "lbAnguloBrazo2";
            this.lbAnguloBrazo2.Size = new System.Drawing.Size(17, 13);
            this.lbAnguloBrazo2.TabIndex = 14;
            this.lbAnguloBrazo2.Text = "0°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Angulo de Brazo 2 =";
            // 
            // tkbBrazo2
            // 
            this.tkbBrazo2.Location = new System.Drawing.Point(67, 195);
            this.tkbBrazo2.Maximum = 180;
            this.tkbBrazo2.Name = "tkbBrazo2";
            this.tkbBrazo2.Size = new System.Drawing.Size(360, 45);
            this.tkbBrazo2.TabIndex = 12;
            this.tkbBrazo2.Scroll += new System.EventHandler(this.tkbBrazo2_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(433, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "180°";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "0°";
            // 
            // lbAnguloBrazo1
            // 
            this.lbAnguloBrazo1.AutoSize = true;
            this.lbAnguloBrazo1.Location = new System.Drawing.Point(275, 113);
            this.lbAnguloBrazo1.Name = "lbAnguloBrazo1";
            this.lbAnguloBrazo1.Size = new System.Drawing.Size(17, 13);
            this.lbAnguloBrazo1.TabIndex = 9;
            this.lbAnguloBrazo1.Text = "0°";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Angulo de Brazo 1 =";
            // 
            // tkbBrazo1
            // 
            this.tkbBrazo1.Location = new System.Drawing.Point(67, 129);
            this.tkbBrazo1.Maximum = 180;
            this.tkbBrazo1.Name = "tkbBrazo1";
            this.tkbBrazo1.Size = new System.Drawing.Size(360, 45);
            this.tkbBrazo1.TabIndex = 7;
            this.tkbBrazo1.Scroll += new System.EventHandler(this.tkbBrazo1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "180°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "0°";
            // 
            // lbAnguloBase
            // 
            this.lbAnguloBase.AutoSize = true;
            this.lbAnguloBase.Location = new System.Drawing.Point(275, 48);
            this.lbAnguloBase.Name = "lbAnguloBase";
            this.lbAnguloBase.Size = new System.Drawing.Size(17, 13);
            this.lbAnguloBase.TabIndex = 4;
            this.lbAnguloBase.Text = "0°";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Angulo de Base =";
            // 
            // tkbBase
            // 
            this.tkbBase.Location = new System.Drawing.Point(67, 64);
            this.tkbBase.Maximum = 180;
            this.tkbBase.Name = "tkbBase";
            this.tkbBase.Size = new System.Drawing.Size(360, 45);
            this.tkbBase.TabIndex = 2;
            this.tkbBase.Scroll += new System.EventHandler(this.tkbBase_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "180°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "0°";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDesconectar);
            this.groupBox2.Controls.Add(this.btnConectar);
            this.groupBox2.Controls.Add(this.cmbVelocidad);
            this.groupBox2.Controls.Add(this.cmbPuertoSerial);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(286, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 105);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Puerto COM";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(251, 71);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(113, 28);
            this.btnDesconectar.TabIndex = 5;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(112, 71);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(113, 28);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // cmbVelocidad
            // 
            this.cmbVelocidad.FormattingEnabled = true;
            this.cmbVelocidad.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.cmbVelocidad.Location = new System.Drawing.Point(341, 39);
            this.cmbVelocidad.Name = "cmbVelocidad";
            this.cmbVelocidad.Size = new System.Drawing.Size(132, 21);
            this.cmbVelocidad.TabIndex = 3;
            this.cmbVelocidad.Text = "9600";
            // 
            // cmbPuertoSerial
            // 
            this.cmbPuertoSerial.FormattingEnabled = true;
            this.cmbPuertoSerial.Location = new System.Drawing.Point(72, 39);
            this.cmbPuertoSerial.Name = "cmbPuertoSerial";
            this.cmbPuertoSerial.Size = new System.Drawing.Size(132, 21);
            this.cmbPuertoSerial.TabIndex = 2;
            this.cmbPuertoSerial.DropDown += new System.EventHandler(this.cmbPuertoSerial_DropDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(273, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Velocidad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Puerto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbGarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrazo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrazo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBase)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tkbBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAnguloGarra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar tkbGarra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbAnguloBrazo2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tkbBrazo2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbAnguloBrazo1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tkbBrazo1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbAnguloBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox cmbVelocidad;
        private System.Windows.Forms.ComboBox cmbPuertoSerial;
        private System.Windows.Forms.Label label18;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

