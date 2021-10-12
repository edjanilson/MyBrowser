namespace MyBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnIR = new System.Windows.Forms.Button();
            this.btnHOME = new System.Windows.Forms.Button();
            this.btnVOLTAR = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPROXIMO = new System.Windows.Forms.Button();
            this.btnATUALIZAR = new System.Windows.Forms.Button();
            this.btnDEFINIRHOME = new System.Windows.Forms.Button();
            this.btnPESQUISAR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 91);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(704, 367);
            this.webBrowser1.TabIndex = 0;
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(11, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(398, 26);
            this.txtURL.TabIndex = 1;
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // btnIR
            // 
            this.btnIR.Location = new System.Drawing.Point(11, 44);
            this.btnIR.Name = "btnIR";
            this.btnIR.Size = new System.Drawing.Size(75, 23);
            this.btnIR.TabIndex = 2;
            this.btnIR.Text = "Ir";
            this.btnIR.UseVisualStyleBackColor = true;
            this.btnIR.Click += new System.EventHandler(this.btnIR_Click);
            // 
            // btnHOME
            // 
            this.btnHOME.Location = new System.Drawing.Point(91, 44);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(75, 23);
            this.btnHOME.TabIndex = 2;
            this.btnHOME.Text = "Home";
            this.btnHOME.UseVisualStyleBackColor = true;
            // 
            // btnVOLTAR
            // 
            this.btnVOLTAR.Location = new System.Drawing.Point(172, 44);
            this.btnVOLTAR.Name = "btnVOLTAR";
            this.btnVOLTAR.Size = new System.Drawing.Size(75, 23);
            this.btnVOLTAR.TabIndex = 2;
            this.btnVOLTAR.Text = "Voltar";
            this.btnVOLTAR.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(334, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnPROXIMO
            // 
            this.btnPROXIMO.Location = new System.Drawing.Point(253, 44);
            this.btnPROXIMO.Name = "btnPROXIMO";
            this.btnPROXIMO.Size = new System.Drawing.Size(75, 23);
            this.btnPROXIMO.TabIndex = 2;
            this.btnPROXIMO.Text = "Próximo";
            this.btnPROXIMO.UseVisualStyleBackColor = true;
            // 
            // btnATUALIZAR
            // 
            this.btnATUALIZAR.Location = new System.Drawing.Point(415, 44);
            this.btnATUALIZAR.Name = "btnATUALIZAR";
            this.btnATUALIZAR.Size = new System.Drawing.Size(75, 23);
            this.btnATUALIZAR.TabIndex = 2;
            this.btnATUALIZAR.Text = "Atualizar";
            this.btnATUALIZAR.UseVisualStyleBackColor = true;
            // 
            // btnDEFINIRHOME
            // 
            this.btnDEFINIRHOME.Location = new System.Drawing.Point(577, 44);
            this.btnDEFINIRHOME.Name = "btnDEFINIRHOME";
            this.btnDEFINIRHOME.Size = new System.Drawing.Size(75, 23);
            this.btnDEFINIRHOME.TabIndex = 3;
            this.btnDEFINIRHOME.Text = "Definir home";
            this.btnDEFINIRHOME.UseVisualStyleBackColor = true;
            // 
            // btnPESQUISAR
            // 
            this.btnPESQUISAR.Location = new System.Drawing.Point(496, 44);
            this.btnPESQUISAR.Name = "btnPESQUISAR";
            this.btnPESQUISAR.Size = new System.Drawing.Size(75, 23);
            this.btnPESQUISAR.TabIndex = 4;
            this.btnPESQUISAR.Text = "Pesquisar";
            this.btnPESQUISAR.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 81);
            this.panel1.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 458);
            this.Controls.Add(this.btnPESQUISAR);
            this.Controls.Add(this.btnDEFINIRHOME);
            this.Controls.Add(this.btnATUALIZAR);
            this.Controls.Add(this.btnPROXIMO);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnVOLTAR);
            this.Controls.Add(this.btnHOME);
            this.Controls.Add(this.btnIR);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBrowser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnIR;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.Button btnVOLTAR;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPROXIMO;
        private System.Windows.Forms.Button btnATUALIZAR;
        private System.Windows.Forms.Button btnDEFINIRHOME;
        private System.Windows.Forms.Button btnPESQUISAR;
        private System.Windows.Forms.Panel panel1;
    }
}