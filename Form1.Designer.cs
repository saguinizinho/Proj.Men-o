namespace prjProjetoMençao
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.grbPeriodo = new System.Windows.Forms.GroupBox();
            this.rdbNoturno = new System.Windows.Forms.RadioButton();
            this.rdbVespertino = new System.Windows.Forms.RadioButton();
            this.rdbMatutino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRm = new System.Windows.Forms.TextBox();
            this.cboMencao = new System.Windows.Forms.ComboBox();
            this.lblMencao = new System.Windows.Forms.Label();
            this.lblComponente = new System.Windows.Forms.Label();
            this.cboComponenteCurricular = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRm = new System.Windows.Forms.Label();
            this.lblProjeto = new System.Windows.Forms.Label();
            this.grbPeriodo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(455, 330);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(159, 38);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(277, 330);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(159, 38);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(98, 330);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(159, 38);
            this.btnConfirmar.TabIndex = 17;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // grbPeriodo
            // 
            this.grbPeriodo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grbPeriodo.Controls.Add(this.rdbNoturno);
            this.grbPeriodo.Controls.Add(this.rdbVespertino);
            this.grbPeriodo.Controls.Add(this.rdbMatutino);
            this.grbPeriodo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPeriodo.Location = new System.Drawing.Point(455, 78);
            this.grbPeriodo.Name = "grbPeriodo";
            this.grbPeriodo.Size = new System.Drawing.Size(285, 183);
            this.grbPeriodo.TabIndex = 16;
            this.grbPeriodo.TabStop = false;
            this.grbPeriodo.Text = "Período";
            // 
            // rdbNoturno
            // 
            this.rdbNoturno.AutoSize = true;
            this.rdbNoturno.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNoturno.Location = new System.Drawing.Point(6, 127);
            this.rdbNoturno.Name = "rdbNoturno";
            this.rdbNoturno.Size = new System.Drawing.Size(115, 29);
            this.rdbNoturno.TabIndex = 2;
            this.rdbNoturno.TabStop = true;
            this.rdbNoturno.Text = "Noturno";
            this.rdbNoturno.UseVisualStyleBackColor = true;
            // 
            // rdbVespertino
            // 
            this.rdbVespertino.AutoSize = true;
            this.rdbVespertino.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVespertino.Location = new System.Drawing.Point(6, 83);
            this.rdbVespertino.Name = "rdbVespertino";
            this.rdbVespertino.Size = new System.Drawing.Size(139, 29);
            this.rdbVespertino.TabIndex = 1;
            this.rdbVespertino.TabStop = true;
            this.rdbVespertino.Text = "Vespertino";
            this.rdbVespertino.UseVisualStyleBackColor = true;
            // 
            // rdbMatutino
            // 
            this.rdbMatutino.AutoSize = true;
            this.rdbMatutino.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMatutino.Location = new System.Drawing.Point(6, 41);
            this.rdbMatutino.Name = "rdbMatutino";
            this.rdbMatutino.Size = new System.Drawing.Size(124, 29);
            this.rdbMatutino.TabIndex = 0;
            this.rdbMatutino.TabStop = true;
            this.rdbMatutino.Text = "Matutino";
            this.rdbMatutino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtRm);
            this.groupBox1.Controls.Add(this.cboMencao);
            this.groupBox1.Controls.Add(this.lblMencao);
            this.groupBox1.Controls.Add(this.lblComponente);
            this.groupBox1.Controls.Add(this.cboComponenteCurricular);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblRm);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 183);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(100, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(128, 32);
            this.txtNome.TabIndex = 16;
            // 
            // txtRm
            // 
            this.txtRm.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRm.Location = new System.Drawing.Point(100, 20);
            this.txtRm.Name = "txtRm";
            this.txtRm.Size = new System.Drawing.Size(128, 32);
            this.txtRm.TabIndex = 15;
            // 
            // cboMencao
            // 
            this.cboMencao.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMencao.FormattingEnabled = true;
            this.cboMencao.Items.AddRange(new object[] {
            "MB",
            "B",
            "R",
            "I"});
            this.cboMencao.Location = new System.Drawing.Point(111, 127);
            this.cboMencao.Name = "cboMencao";
            this.cboMencao.Size = new System.Drawing.Size(121, 32);
            this.cboMencao.TabIndex = 14;
            // 
            // lblMencao
            // 
            this.lblMencao.AutoSize = true;
            this.lblMencao.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMencao.Location = new System.Drawing.Point(6, 133);
            this.lblMencao.Name = "lblMencao";
            this.lblMencao.Size = new System.Drawing.Size(103, 26);
            this.lblMencao.TabIndex = 13;
            this.lblMencao.Text = "Mençao:";
            // 
            // lblComponente
            // 
            this.lblComponente.AutoSize = true;
            this.lblComponente.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponente.Location = new System.Drawing.Point(6, 93);
            this.lblComponente.Name = "lblComponente";
            this.lblComponente.Size = new System.Drawing.Size(266, 26);
            this.lblComponente.TabIndex = 12;
            this.lblComponente.Text = "Componente Curricular:\r\n";
            // 
            // cboComponenteCurricular
            // 
            this.cboComponenteCurricular.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboComponenteCurricular.FormattingEnabled = true;
            this.cboComponenteCurricular.Items.AddRange(new object[] {
            "Biologia",
            "Aps",
            "Ds",
            "Matemática",
            "Pam"});
            this.cboComponenteCurricular.Location = new System.Drawing.Point(265, 92);
            this.cboComponenteCurricular.Name = "cboComponenteCurricular";
            this.cboComponenteCurricular.Size = new System.Drawing.Size(109, 32);
            this.cboComponenteCurricular.TabIndex = 11;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 58);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(83, 26);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            // 
            // lblRm
            // 
            this.lblRm.AutoSize = true;
            this.lblRm.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRm.Location = new System.Drawing.Point(6, 27);
            this.lblRm.Name = "lblRm";
            this.lblRm.Size = new System.Drawing.Size(55, 26);
            this.lblRm.TabIndex = 9;
            this.lblRm.Text = "RM:";
            // 
            // lblProjeto
            // 
            this.lblProjeto.AutoSize = true;
            this.lblProjeto.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeto.Location = new System.Drawing.Point(272, 36);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(252, 26);
            this.lblProjeto.TabIndex = 14;
            this.lblProjeto.Text = "Projeto para a Menção";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 405);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grbPeriodo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProjeto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbPeriodo.ResumeLayout(false);
            this.grbPeriodo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox grbPeriodo;
        private System.Windows.Forms.RadioButton rdbNoturno;
        private System.Windows.Forms.RadioButton rdbVespertino;
        private System.Windows.Forms.RadioButton rdbMatutino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRm;
        private System.Windows.Forms.ComboBox cboMencao;
        private System.Windows.Forms.Label lblMencao;
        private System.Windows.Forms.Label lblComponente;
        private System.Windows.Forms.ComboBox cboComponenteCurricular;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRm;
        private System.Windows.Forms.Label lblProjeto;
    }
}

