namespace Revisao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSimone = new System.Windows.Forms.RadioButton();
            this.rdbLula = new System.Windows.Forms.RadioButton();
            this.rdbJair = new System.Windows.Forms.RadioButton();
            this.rdbCiro = new System.Windows.Forms.RadioButton();
            this.rdbAndre = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PbCand = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCand)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe seu CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe seu n° do titulo de eleitor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCPF.Location = new System.Drawing.Point(354, 32);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(152, 20);
            this.txtCPF.TabIndex = 2;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(354, 74);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(152, 20);
            this.txtTitulo.TabIndex = 3;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            this.txtTitulo.Leave += new System.EventHandler(this.txtTitulo_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSimone);
            this.groupBox1.Controls.Add(this.rdbLula);
            this.groupBox1.Controls.Add(this.rdbJair);
            this.groupBox1.Controls.Add(this.rdbCiro);
            this.groupBox1.Controls.Add(this.rdbAndre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(102, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 201);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um candidato à presidência:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbSimone
            // 
            this.rdbSimone.AutoSize = true;
            this.rdbSimone.Location = new System.Drawing.Point(26, 154);
            this.rdbSimone.Name = "rdbSimone";
            this.rdbSimone.Size = new System.Drawing.Size(240, 24);
            this.rdbSimone.TabIndex = 4;
            this.rdbSimone.TabStop = true;
            this.rdbSimone.Text = "Simone Tebet (MDB) \"Errado\"";
            this.rdbSimone.UseVisualStyleBackColor = true;
            this.rdbSimone.CheckedChanged += new System.EventHandler(this.rdbSimone_CheckedChanged);
            // 
            // rdbLula
            // 
            this.rdbLula.AutoSize = true;
            this.rdbLula.Location = new System.Drawing.Point(26, 124);
            this.rdbLula.Name = "rdbLula";
            this.rdbLula.Size = new System.Drawing.Size(315, 24);
            this.rdbLula.TabIndex = 3;
            this.rdbLula.TabStop = true;
            this.rdbLula.Text = "Luiz Inácio Lula da Silva (PT) \"ERRADO\"";
            this.rdbLula.UseVisualStyleBackColor = true;
            this.rdbLula.CheckedChanged += new System.EventHandler(this.rdbLula_CheckedChanged);
            // 
            // rdbJair
            // 
            this.rdbJair.AutoSize = true;
            this.rdbJair.Location = new System.Drawing.Point(26, 94);
            this.rdbJair.Name = "rdbJair";
            this.rdbJair.Size = new System.Drawing.Size(216, 24);
            this.rdbJair.TabIndex = 2;
            this.rdbJair.TabStop = true;
            this.rdbJair.Text = "Jair Bolsonaro (PL) \"Certo\"";
            this.rdbJair.UseVisualStyleBackColor = true;
            this.rdbJair.CheckedChanged += new System.EventHandler(this.rdbJair_CheckedChanged);
            // 
            // rdbCiro
            // 
            this.rdbCiro.AutoSize = true;
            this.rdbCiro.Location = new System.Drawing.Point(26, 64);
            this.rdbCiro.Name = "rdbCiro";
            this.rdbCiro.Size = new System.Drawing.Size(220, 24);
            this.rdbCiro.TabIndex = 1;
            this.rdbCiro.TabStop = true;
            this.rdbCiro.Text = "Ciro Gomes (PDT) \"Errado\"";
            this.rdbCiro.UseVisualStyleBackColor = true;
            this.rdbCiro.CheckedChanged += new System.EventHandler(this.rdbCiro_CheckedChanged);
            // 
            // rdbAndre
            // 
            this.rdbAndre.AutoSize = true;
            this.rdbAndre.Location = new System.Drawing.Point(26, 34);
            this.rdbAndre.Name = "rdbAndre";
            this.rdbAndre.Size = new System.Drawing.Size(263, 24);
            this.rdbAndre.TabIndex = 0;
            this.rdbAndre.TabStop = true;
            this.rdbAndre.Text = "André Janones (Avante) \"Errado\"";
            this.rdbAndre.UseVisualStyleBackColor = true;
            this.rdbAndre.CheckedChanged += new System.EventHandler(this.rdbAndre_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(93, 394);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(101, 37);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirmar Voto";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(242, 394);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(101, 37);
            this.btnTotal.TabIndex = 6;
            this.btnTotal.Text = "Total de Votos por Candidato";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(572, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 29);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PbCand
            // 
            this.PbCand.Location = new System.Drawing.Point(484, 162);
            this.PbCand.Name = "PbCand";
            this.PbCand.Size = new System.Drawing.Size(187, 201);
            this.PbCand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCand.TabIndex = 8;
            this.PbCand.TabStop = false;
            this.PbCand.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(683, 463);
            this.ControlBox = false;
            this.Controls.Add(this.PbCand);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Eleição 2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSimone;
        private System.Windows.Forms.RadioButton rdbLula;
        private System.Windows.Forms.RadioButton rdbJair;
        private System.Windows.Forms.RadioButton rdbCiro;
        private System.Windows.Forms.RadioButton rdbAndre;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox PbCand;
    }
}

