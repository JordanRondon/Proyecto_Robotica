﻿namespace ControlRobot
{
    partial class FormContro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPuertoCOM = new System.Windows.Forms.Panel();
            this.cmbPuertoSerial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVelocidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConectar = new ControlRobot.Recursos.button.ButtonPersonalizado();
            this.btnDesconectar = new ControlRobot.Recursos.button.ButtonPersonalizado();
            this.panelPosicionServo = new System.Windows.Forms.Panel();
            this.lbAnguloBase = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tkbBase = new System.Windows.Forms.TrackBar();
            this.lbAnguloBrazo2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tkbBrazo2 = new System.Windows.Forms.TrackBar();
            this.lbAnguloBrazo1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tkbBrazo1 = new System.Windows.Forms.TrackBar();
            this.lbAnguloGarra = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tkbGarra = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPuertoCOM.SuspendLayout();
            this.panelPosicionServo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrazo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrazo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbGarra)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(893, 571);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panelPuertoCOM);
            this.panel1.Controls.Add(this.btnConectar);
            this.panel1.Controls.Add(this.btnDesconectar);
            this.panel1.Location = new System.Drawing.Point(355, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 136);
            this.panel1.TabIndex = 2;
            // 
            // panelPuertoCOM
            // 
            this.panelPuertoCOM.Controls.Add(this.cmbPuertoSerial);
            this.panelPuertoCOM.Controls.Add(this.label2);
            this.panelPuertoCOM.Controls.Add(this.cmbVelocidad);
            this.panelPuertoCOM.Controls.Add(this.label1);
            this.panelPuertoCOM.Location = new System.Drawing.Point(17, 9);
            this.panelPuertoCOM.Name = "panelPuertoCOM";
            this.panelPuertoCOM.Size = new System.Drawing.Size(286, 117);
            this.panelPuertoCOM.TabIndex = 26;
            // 
            // cmbPuertoSerial
            // 
            this.cmbPuertoSerial.FormattingEnabled = true;
            this.cmbPuertoSerial.Location = new System.Drawing.Point(111, 28);
            this.cmbPuertoSerial.Name = "cmbPuertoSerial";
            this.cmbPuertoSerial.Size = new System.Drawing.Size(154, 21);
            this.cmbPuertoSerial.TabIndex = 0;
            this.cmbPuertoSerial.DropDown += new System.EventHandler(this.cmbPuertoSerial_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Velocidad";
            // 
            // cmbVelocidad
            // 
            this.cmbVelocidad.FormattingEnabled = true;
            this.cmbVelocidad.Location = new System.Drawing.Point(111, 68);
            this.cmbVelocidad.Name = "cmbVelocidad";
            this.cmbVelocidad.Size = new System.Drawing.Size(154, 21);
            this.cmbVelocidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Puerto";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.btnConectar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.btnConectar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.btnConectar.BorderRadius = 20;
            this.btnConectar.BorderSize = 0;
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.Location = new System.Drawing.Point(326, 21);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(156, 41);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextColor = System.Drawing.Color.White;
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.btnDesconectar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.btnDesconectar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.btnDesconectar.BorderRadius = 20;
            this.btnDesconectar.BorderSize = 0;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.ForeColor = System.Drawing.Color.White;
            this.btnDesconectar.Location = new System.Drawing.Point(326, 72);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(156, 41);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.TextColor = System.Drawing.Color.White;
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // panelPosicionServo
            // 
            this.panelPosicionServo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelPosicionServo.Controls.Add(this.lbAnguloBase);
            this.panelPosicionServo.Controls.Add(this.label16);
            this.panelPosicionServo.Controls.Add(this.label17);
            this.panelPosicionServo.Controls.Add(this.label18);
            this.panelPosicionServo.Controls.Add(this.tkbBase);
            this.panelPosicionServo.Controls.Add(this.lbAnguloBrazo2);
            this.panelPosicionServo.Controls.Add(this.label12);
            this.panelPosicionServo.Controls.Add(this.label13);
            this.panelPosicionServo.Controls.Add(this.label14);
            this.panelPosicionServo.Controls.Add(this.tkbBrazo2);
            this.panelPosicionServo.Controls.Add(this.lbAnguloBrazo1);
            this.panelPosicionServo.Controls.Add(this.label8);
            this.panelPosicionServo.Controls.Add(this.label9);
            this.panelPosicionServo.Controls.Add(this.label10);
            this.panelPosicionServo.Controls.Add(this.tkbBrazo1);
            this.panelPosicionServo.Controls.Add(this.lbAnguloGarra);
            this.panelPosicionServo.Controls.Add(this.label5);
            this.panelPosicionServo.Controls.Add(this.label4);
            this.panelPosicionServo.Controls.Add(this.label3);
            this.panelPosicionServo.Controls.Add(this.tkbGarra);
            this.panelPosicionServo.Location = new System.Drawing.Point(355, 176);
            this.panelPosicionServo.Name = "panelPosicionServo";
            this.panelPosicionServo.Size = new System.Drawing.Size(522, 377);
            this.panelPosicionServo.TabIndex = 3;
            // 
            // lbAnguloBase
            // 
            this.lbAnguloBase.AutoSize = true;
            this.lbAnguloBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnguloBase.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnguloBase.Location = new System.Drawing.Point(305, 39);
            this.lbAnguloBase.Name = "lbAnguloBase";
            this.lbAnguloBase.Size = new System.Drawing.Size(23, 20);
            this.lbAnguloBase.TabIndex = 23;
            this.lbAnguloBase.Text = "0°";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(188, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Angulo Base   = ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(466, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 20);
            this.label17.TabIndex = 21;
            this.label17.Text = "180°";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(33, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "0°";
            // 
            // tkbBase
            // 
            this.tkbBase.Location = new System.Drawing.Point(49, 62);
            this.tkbBase.Maximum = 180;
            this.tkbBase.Name = "tkbBase";
            this.tkbBase.Size = new System.Drawing.Size(420, 45);
            this.tkbBase.TabIndex = 19;
            this.tkbBase.Scroll += new System.EventHandler(this.tkbBase_Scroll);
            // 
            // lbAnguloBrazo2
            // 
            this.lbAnguloBrazo2.AutoSize = true;
            this.lbAnguloBrazo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnguloBrazo2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnguloBrazo2.Location = new System.Drawing.Point(305, 196);
            this.lbAnguloBrazo2.Name = "lbAnguloBrazo2";
            this.lbAnguloBrazo2.Size = new System.Drawing.Size(23, 20);
            this.lbAnguloBrazo2.TabIndex = 18;
            this.lbAnguloBrazo2.Text = "0°";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(188, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Angulo Bazo2 = ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(466, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "180°";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(33, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "0°";
            // 
            // tkbBrazo2
            // 
            this.tkbBrazo2.Location = new System.Drawing.Point(49, 219);
            this.tkbBrazo2.Maximum = 180;
            this.tkbBrazo2.Name = "tkbBrazo2";
            this.tkbBrazo2.Size = new System.Drawing.Size(420, 45);
            this.tkbBrazo2.TabIndex = 14;
            this.tkbBrazo2.Scroll += new System.EventHandler(this.tkbBrazo2_Scroll);
            // 
            // lbAnguloBrazo1
            // 
            this.lbAnguloBrazo1.AutoSize = true;
            this.lbAnguloBrazo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnguloBrazo1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnguloBrazo1.Location = new System.Drawing.Point(305, 117);
            this.lbAnguloBrazo1.Name = "lbAnguloBrazo1";
            this.lbAnguloBrazo1.Size = new System.Drawing.Size(23, 20);
            this.lbAnguloBrazo1.TabIndex = 13;
            this.lbAnguloBrazo1.Text = "0°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(188, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Angulo Bazo1 = ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(466, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "180°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(33, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "0°";
            // 
            // tkbBrazo1
            // 
            this.tkbBrazo1.Location = new System.Drawing.Point(49, 140);
            this.tkbBrazo1.Maximum = 180;
            this.tkbBrazo1.Name = "tkbBrazo1";
            this.tkbBrazo1.Size = new System.Drawing.Size(420, 45);
            this.tkbBrazo1.TabIndex = 9;
            this.tkbBrazo1.Scroll += new System.EventHandler(this.tkbBrazo1_Scroll);
            // 
            // lbAnguloGarra
            // 
            this.lbAnguloGarra.AutoSize = true;
            this.lbAnguloGarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnguloGarra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAnguloGarra.Location = new System.Drawing.Point(305, 273);
            this.lbAnguloGarra.Name = "lbAnguloGarra";
            this.lbAnguloGarra.Size = new System.Drawing.Size(23, 20);
            this.lbAnguloGarra.TabIndex = 8;
            this.lbAnguloGarra.Text = "0°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(188, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Angulo Garra  = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(466, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "180°";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(33, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "0°";
            // 
            // tkbGarra
            // 
            this.tkbGarra.Location = new System.Drawing.Point(49, 296);
            this.tkbGarra.Maximum = 180;
            this.tkbGarra.Name = "tkbGarra";
            this.tkbGarra.Size = new System.Drawing.Size(420, 45);
            this.tkbGarra.TabIndex = 0;
            this.tkbGarra.Scroll += new System.EventHandler(this.tkbGarra_Scroll);
            // 
            // FormContro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 565);
            this.Controls.Add(this.panelPosicionServo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(905, 604);
            this.MinimumSize = new System.Drawing.Size(905, 604);
            this.Name = "FormContro";
            this.Text = "CONTROL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContro_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelPuertoCOM.ResumeLayout(false);
            this.panelPuertoCOM.PerformLayout();
            this.panelPosicionServo.ResumeLayout(false);
            this.panelPosicionServo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrazo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrazo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbGarra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Recursos.button.ButtonPersonalizado btnDesconectar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPosicionServo;
        private System.Windows.Forms.TrackBar tkbGarra;
        private Recursos.button.ButtonPersonalizado btnConectar;
        private System.Windows.Forms.ComboBox cmbVelocidad;
        private System.Windows.Forms.ComboBox cmbPuertoSerial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAnguloBrazo1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tkbBrazo1;
        private System.Windows.Forms.Label lbAnguloGarra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAnguloBrazo2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar tkbBrazo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAnguloBase;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar tkbBase;
        private System.Windows.Forms.Panel panelPuertoCOM;
        private System.IO.Ports.SerialPort serialPort1;
    }
}