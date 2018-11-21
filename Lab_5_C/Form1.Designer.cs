namespace Lab_5_C
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGetUserName = new System.Windows.Forms.Button();
            this.lblGetUserName = new System.Windows.Forms.Label();
            this.btnABORTRETRYIGNORE = new System.Windows.Forms.Button();
            this.btnYESNOCANCEL = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnYESNO = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnMi = new System.Windows.Forms.Button();
            this.btnFa = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnLya = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnAW_BLEND = new System.Windows.Forms.Button();
            this.btnHOR_AW_SLIDE = new System.Windows.Forms.Button();
            this.btnCenter_AW_SLIDE = new System.Windows.Forms.Button();
            this.btnTurnOff = new System.Windows.Forms.Button();
            this.btnUserOut = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuOpen = new System.Windows.Forms.MenuItem();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetUserName
            // 
            this.btnGetUserName.Location = new System.Drawing.Point(90, 139);
            this.btnGetUserName.Name = "btnGetUserName";
            this.btnGetUserName.Size = new System.Drawing.Size(75, 23);
            this.btnGetUserName.TabIndex = 0;
            this.btnGetUserName.Text = "Получить!";
            this.btnGetUserName.UseVisualStyleBackColor = true;
            this.btnGetUserName.Click += new System.EventHandler(this.btnGetUserName_Click);
            // 
            // lblGetUserName
            // 
            this.lblGetUserName.AutoSize = true;
            this.lblGetUserName.Location = new System.Drawing.Point(12, 87);
            this.lblGetUserName.Name = "lblGetUserName";
            this.lblGetUserName.Size = new System.Drawing.Size(109, 13);
            this.lblGetUserName.TabIndex = 1;
            this.lblGetUserName.Text = "Имя пользователя: ";
            // 
            // btnABORTRETRYIGNORE
            // 
            this.btnABORTRETRYIGNORE.BackColor = System.Drawing.SystemColors.Info;
            this.btnABORTRETRYIGNORE.Location = new System.Drawing.Point(88, 20);
            this.btnABORTRETRYIGNORE.Name = "btnABORTRETRYIGNORE";
            this.btnABORTRETRYIGNORE.Size = new System.Drawing.Size(124, 48);
            this.btnABORTRETRYIGNORE.TabIndex = 2;
            this.btnABORTRETRYIGNORE.Text = "Прервать Повторить Пропустить";
            this.btnABORTRETRYIGNORE.UseVisualStyleBackColor = false;
            this.btnABORTRETRYIGNORE.Click += new System.EventHandler(this.btnABORTRETRYIGNORE_Click);
            // 
            // btnYESNOCANCEL
            // 
            this.btnYESNOCANCEL.BackColor = System.Drawing.SystemColors.Info;
            this.btnYESNOCANCEL.Location = new System.Drawing.Point(88, 67);
            this.btnYESNOCANCEL.Name = "btnYESNOCANCEL";
            this.btnYESNOCANCEL.Size = new System.Drawing.Size(124, 48);
            this.btnYESNOCANCEL.TabIndex = 2;
            this.btnYESNOCANCEL.Text = "Да Нет Отмена";
            this.btnYESNOCANCEL.UseVisualStyleBackColor = false;
            this.btnYESNOCANCEL.Click += new System.EventHandler(this.btnYESNOCANCEL_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Info;
            this.btnOK.Location = new System.Drawing.Point(88, 114);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(124, 48);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnYESNO
            // 
            this.btnYESNO.BackColor = System.Drawing.SystemColors.Info;
            this.btnYESNO.Location = new System.Drawing.Point(88, 162);
            this.btnYESNO.Name = "btnYESNO";
            this.btnYESNO.Size = new System.Drawing.Size(124, 48);
            this.btnYESNO.TabIndex = 2;
            this.btnYESNO.Text = "Да Нет";
            this.btnYESNO.UseVisualStyleBackColor = false;
            this.btnYESNO.Click += new System.EventHandler(this.btnYESNO_Click);
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnDo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDo.Location = new System.Drawing.Point(39, 29);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(52, 148);
            this.btnDo.TabIndex = 0;
            this.btnDo.Text = "До";
            this.btnDo.UseVisualStyleBackColor = false;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnRe
            // 
            this.btnRe.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnRe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRe.Location = new System.Drawing.Point(91, 29);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(52, 148);
            this.btnRe.TabIndex = 0;
            this.btnRe.Text = "Ре";
            this.btnRe.UseVisualStyleBackColor = false;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // btnMi
            // 
            this.btnMi.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnMi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMi.Location = new System.Drawing.Point(143, 29);
            this.btnMi.Name = "btnMi";
            this.btnMi.Size = new System.Drawing.Size(52, 148);
            this.btnMi.TabIndex = 0;
            this.btnMi.Text = "Ми";
            this.btnMi.UseVisualStyleBackColor = false;
            this.btnMi.Click += new System.EventHandler(this.btnMi_Click);
            // 
            // btnFa
            // 
            this.btnFa.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnFa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnFa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFa.Location = new System.Drawing.Point(195, 29);
            this.btnFa.Name = "btnFa";
            this.btnFa.Size = new System.Drawing.Size(52, 148);
            this.btnFa.TabIndex = 0;
            this.btnFa.Text = "Фа";
            this.btnFa.UseVisualStyleBackColor = false;
            this.btnFa.Click += new System.EventHandler(this.btnFa_Click);
            // 
            // btnSol
            // 
            this.btnSol.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSol.Location = new System.Drawing.Point(244, 29);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(52, 148);
            this.btnSol.TabIndex = 0;
            this.btnSol.Text = "Соль";
            this.btnSol.UseVisualStyleBackColor = false;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnLya
            // 
            this.btnLya.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnLya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnLya.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLya.Location = new System.Drawing.Point(292, 29);
            this.btnLya.Name = "btnLya";
            this.btnLya.Size = new System.Drawing.Size(52, 148);
            this.btnLya.TabIndex = 0;
            this.btnLya.Text = "Ля";
            this.btnLya.UseVisualStyleBackColor = false;
            this.btnLya.Click += new System.EventHandler(this.btnLya_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnC.Location = new System.Drawing.Point(341, 29);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(52, 148);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "Cи";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnAW_BLEND
            // 
            this.btnAW_BLEND.Location = new System.Drawing.Point(21, 20);
            this.btnAW_BLEND.Name = "btnAW_BLEND";
            this.btnAW_BLEND.Size = new System.Drawing.Size(232, 48);
            this.btnAW_BLEND.TabIndex = 0;
            this.btnAW_BLEND.Text = "Проявление";
            this.btnAW_BLEND.Click += new System.EventHandler(this.btnAW_BLEND_Click);
            // 
            // btnHOR_AW_SLIDE
            // 
            this.btnHOR_AW_SLIDE.Location = new System.Drawing.Point(21, 76);
            this.btnHOR_AW_SLIDE.Name = "btnHOR_AW_SLIDE";
            this.btnHOR_AW_SLIDE.Size = new System.Drawing.Size(232, 48);
            this.btnHOR_AW_SLIDE.TabIndex = 0;
            this.btnHOR_AW_SLIDE.Text = "Горизонтальное появление";
            this.btnHOR_AW_SLIDE.Click += new System.EventHandler(this.btnHOR_AW_SLIDE_Click);
            // 
            // btnCenter_AW_SLIDE
            // 
            this.btnCenter_AW_SLIDE.Location = new System.Drawing.Point(21, 130);
            this.btnCenter_AW_SLIDE.Name = "btnCenter_AW_SLIDE";
            this.btnCenter_AW_SLIDE.Size = new System.Drawing.Size(232, 48);
            this.btnCenter_AW_SLIDE.TabIndex = 0;
            this.btnCenter_AW_SLIDE.Text = "Появление из центра";
            this.btnCenter_AW_SLIDE.Click += new System.EventHandler(this.btnCenter_AW_SLIDE_Click);
            // 
            // btnTurnOff
            // 
            this.btnTurnOff.AutoEllipsis = true;
            this.btnTurnOff.BackColor = System.Drawing.SystemColors.Menu;
            this.btnTurnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnTurnOff.Image")));
            this.btnTurnOff.Location = new System.Drawing.Point(58, 88);
            this.btnTurnOff.Name = "btnTurnOff";
            this.btnTurnOff.Size = new System.Drawing.Size(48, 50);
            this.btnTurnOff.TabIndex = 0;
            this.btnTurnOff.UseVisualStyleBackColor = false;
            this.btnTurnOff.Click += new System.EventHandler(this.btnTurnOff_Click);
            // 
            // btnUserOut
            // 
            this.btnUserOut.Image = ((System.Drawing.Image)(resources.GetObject("btnUserOut.Image")));
            this.btnUserOut.Location = new System.Drawing.Point(169, 88);
            this.btnUserOut.Name = "btnUserOut";
            this.btnUserOut.Size = new System.Drawing.Size(52, 50);
            this.btnUserOut.TabIndex = 0;
            this.btnUserOut.Click += new System.EventHandler(this.btnUserOut_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Image = ((System.Drawing.Image)(resources.GetObject("btnRestart.Image")));
            this.btnRestart.Location = new System.Drawing.Point(112, 88);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(51, 50);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(58, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 22);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGetUserName);
            this.panel1.Controls.Add(this.lblGetUserName);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 219);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Задание 1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnABORTRETRYIGNORE);
            this.panel2.Controls.Add(this.btnYESNO);
            this.panel2.Controls.Add(this.btnYESNOCANCEL);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Location = new System.Drawing.Point(319, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 219);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Задание 2";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnDo);
            this.panel3.Controls.Add(this.btnC);
            this.panel3.Controls.Add(this.btnLya);
            this.panel3.Controls.Add(this.btnRe);
            this.panel3.Controls.Add(this.btnSol);
            this.panel3.Controls.Add(this.btnMi);
            this.panel3.Controls.Add(this.btnFa);
            this.panel3.Location = new System.Drawing.Point(650, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 221);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Задание 3";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnTurnOff);
            this.panel4.Controls.Add(this.btnRestart);
            this.panel4.Controls.Add(this.btnUserOut);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Location = new System.Drawing.Point(12, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 187);
            this.panel4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(1, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Задание 4";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btnAW_BLEND);
            this.panel5.Controls.Add(this.btnCenter_AW_SLIDE);
            this.panel5.Controls.Add(this.btnHOR_AW_SLIDE);
            this.panel5.Location = new System.Drawing.Point(319, 239);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(308, 187);
            this.panel5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(1, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Задание 5";
            // 
            // btnCreate
            // 
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.Location = new System.Drawing.Point(83, 54);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 92);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.btnCreate);
            this.panel6.Location = new System.Drawing.Point(650, 239);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(278, 187);
            this.panel6.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(1, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Задание 8";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOpen});
            this.mnuFile.Text = "&Файл";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Index = 0;
            this.mnuOpen.Shortcut = System.Windows.Forms.Shortcut.Ctrl0;
            this.mnuOpen.Text = "&Открыть";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(12, 432);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(916, 238);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 682);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetUserName;
        private System.Windows.Forms.Label lblGetUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}

