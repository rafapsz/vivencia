namespace Software.Basico.Telas
{
    partial class frmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.pnBtnSel = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRecursos = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.logo2);
            this.panel1.Controls.Add(this.pnBtnSel);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnOpcoes);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnRecursos);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 652);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logo2
            // 
            this.logo2.Image = global::Software.Basico.Properties.Resources.fgh;
            this.logo2.Location = new System.Drawing.Point(45, 12);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(125, 100);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 0;
            this.logo2.TabStop = false;
            this.logo2.Visible = false;
            this.logo2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pnBtnSel
            // 
            this.pnBtnSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.pnBtnSel.Location = new System.Drawing.Point(-1, 171);
            this.pnBtnSel.Name = "pnBtnSel";
            this.pnBtnSel.Size = new System.Drawing.Size(13, 60);
            this.pnBtnSel.TabIndex = 3;
            this.pnBtnSel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBtnSel_Paint);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::Software.Basico.Properties.Resources.users32;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(11, 351);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(216, 60);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "          Usuários";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            this.btnUsuarios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnUsuarios_MouseMove);
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.FlatAppearance.BorderSize = 0;
            this.btnOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcoes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcoes.ForeColor = System.Drawing.Color.White;
            this.btnOpcoes.Image = global::Software.Basico.Properties.Resources.settings32;
            this.btnOpcoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpcoes.Location = new System.Drawing.Point(11, 291);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(216, 60);
            this.btnOpcoes.TabIndex = 3;
            this.btnOpcoes.Text = "          Opções";
            this.btnOpcoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpcoes.UseVisualStyleBackColor = true;
            this.btnOpcoes.Click += new System.EventHandler(this.btnOpcoes_Click);
            this.btnOpcoes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOpcoes_MouseMove);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(227)))));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 617);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "?";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRecursos
            // 
            this.btnRecursos.FlatAppearance.BorderSize = 0;
            this.btnRecursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecursos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecursos.ForeColor = System.Drawing.Color.White;
            this.btnRecursos.Image = global::Software.Basico.Properties.Resources.options32;
            this.btnRecursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecursos.Location = new System.Drawing.Point(11, 231);
            this.btnRecursos.Name = "btnRecursos";
            this.btnRecursos.Size = new System.Drawing.Size(216, 60);
            this.btnRecursos.TabIndex = 3;
            this.btnRecursos.Text = "          Temas";
            this.btnRecursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecursos.UseVisualStyleBackColor = true;
            this.btnRecursos.Click += new System.EventHandler(this.btnRecursos_Click);
            this.btnRecursos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRecursos_MouseMove);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Software.Basico.Properties.Resources.computer32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(11, 171);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(216, 60);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "          Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnHome_MouseMove);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(228, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(917, 10);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desenvolvendo Softwares Seguros!";
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Location = new System.Drawing.Point(229, 148);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(915, 500);
            this.pnPrincipal.TabIndex = 5;
            this.pnPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPrincipal_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.logo1);
            this.panel2.Location = new System.Drawing.Point(265, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 125);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 10);
            this.panel3.TabIndex = 6;
            // 
            // logo1
            // 
            this.logo1.Image = global::Software.Basico.Properties.Resources.fgh;
            this.logo1.Location = new System.Drawing.Point(22, 13);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(125, 100);
            this.logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo1.TabIndex = 0;
            this.logo1.TabStop = false;
            this.logo1.Visible = false;
            this.logo1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Software.Basico.Properties.Resources.twitter32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(703, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 41);
            this.button3.TabIndex = 3;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Software.Basico.Properties.Resources.instagram32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(657, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 41);
            this.button2.TabIndex = 3;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::Software.Basico.Properties.Resources.close32;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(1103, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 41);
            this.button5.TabIndex = 3;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Close_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Software.Basico.Properties.Resources.facebook32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(611, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 41);
            this.button1.TabIndex = 3;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1145, 652);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnBtnSel;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnOpcoes;
        private System.Windows.Forms.Button btnRecursos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
    }
}