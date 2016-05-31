
namespace Kurs.Views
{
    partial class PrisonerForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PersInfoTabPage = new System.Windows.Forms.TabPage();
            this.CityBornTB = new System.Windows.Forms.TextBox();
            this.birthdayDTP = new System.Windows.Forms.DateTimePicker();
            this.FamilyCB = new System.Windows.Forms.ComboBox();
            this.MiddleNameTB = new System.Windows.Forms.TextBox();
            this.SecondNameTB = new System.Windows.Forms.TextBox();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ImprisInfoTabPage = new System.Windows.Forms.TabPage();
            this.JailingMonthsNUD = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.PrisCellNUD = new System.Windows.Forms.NumericUpDown();
            this.ImprCountNUD = new System.Windows.Forms.NumericUpDown();
            this.JailingYearsNUD = new System.Windows.Forms.NumericUpDown();
            this.JailedDTP = new System.Windows.Forms.DateTimePicker();
            this.prisonCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.writableBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.PersInfoTabPage.SuspendLayout();
            this.ImprisInfoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JailingMonthsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrisCellNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImprCountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JailingYearsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelBtn.Location = new System.Drawing.Point(410, 321);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(105, 36);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "Закрыть";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.okBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okBtn.Location = new System.Drawing.Point(299, 321);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(105, 36);
            this.okBtn.TabIndex = 18;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PersInfoTabPage);
            this.tabControl1.Controls.Add(this.ImprisInfoTabPage);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 315);
            this.tabControl1.TabIndex = 21;
            // 
            // PersInfoTabPage
            // 
            this.PersInfoTabPage.Controls.Add(this.CityBornTB);
            this.PersInfoTabPage.Controls.Add(this.birthdayDTP);
            this.PersInfoTabPage.Controls.Add(this.FamilyCB);
            this.PersInfoTabPage.Controls.Add(this.MiddleNameTB);
            this.PersInfoTabPage.Controls.Add(this.SecondNameTB);
            this.PersInfoTabPage.Controls.Add(this.FirstNameTB);
            this.PersInfoTabPage.Controls.Add(this.label7);
            this.PersInfoTabPage.Controls.Add(this.label8);
            this.PersInfoTabPage.Controls.Add(this.label9);
            this.PersInfoTabPage.Controls.Add(this.label10);
            this.PersInfoTabPage.Controls.Add(this.label11);
            this.PersInfoTabPage.Controls.Add(this.label12);
            this.PersInfoTabPage.Location = new System.Drawing.Point(4, 22);
            this.PersInfoTabPage.Name = "PersInfoTabPage";
            this.PersInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PersInfoTabPage.Size = new System.Drawing.Size(525, 289);
            this.PersInfoTabPage.TabIndex = 0;
            this.PersInfoTabPage.Text = "Персональная информация";
            this.PersInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // CityBornTB
            // 
            this.CityBornTB.Location = new System.Drawing.Point(294, 114);
            this.CityBornTB.Name = "CityBornTB";
            this.CityBornTB.Size = new System.Drawing.Size(138, 20);
            this.CityBornTB.TabIndex = 20;
            // 
            // birthdayDTP
            // 
            this.birthdayDTP.Location = new System.Drawing.Point(294, 190);
            this.birthdayDTP.Name = "birthdayDTP";
            this.birthdayDTP.Size = new System.Drawing.Size(138, 20);
            this.birthdayDTP.TabIndex = 19;
            this.birthdayDTP.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // FamilyCB
            // 
            this.FamilyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FamilyCB.FormattingEnabled = true;
            this.FamilyCB.Items.AddRange(new object[] {
            "Женат",
            "Не женат",
            "В разводе"});
            this.FamilyCB.Location = new System.Drawing.Point(295, 44);
            this.FamilyCB.Name = "FamilyCB";
            this.FamilyCB.Size = new System.Drawing.Size(137, 21);
            this.FamilyCB.TabIndex = 15;
            // 
            // MiddleNameTB
            // 
            this.MiddleNameTB.Location = new System.Drawing.Point(26, 190);
            this.MiddleNameTB.Name = "MiddleNameTB";
            this.MiddleNameTB.Size = new System.Drawing.Size(138, 20);
            this.MiddleNameTB.TabIndex = 14;
            // 
            // SecondNameTB
            // 
            this.SecondNameTB.Location = new System.Drawing.Point(26, 114);
            this.SecondNameTB.Name = "SecondNameTB";
            this.SecondNameTB.Size = new System.Drawing.Size(138, 20);
            this.SecondNameTB.TabIndex = 13;
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(29, 44);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(135, 20);
            this.FirstNameTB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(290, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Дата рождения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(269, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Семейное положение";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(38, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Фамилия";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(290, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 22);
            this.label10.TabIndex = 8;
            this.label10.Text = "Родной город";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(37, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "Отчество";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(73, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 22);
            this.label12.TabIndex = 6;
            this.label12.Text = "Имя";
            // 
            // ImprisInfoTabPage
            // 
            this.ImprisInfoTabPage.AutoScroll = true;
            this.ImprisInfoTabPage.Controls.Add(this.JailingMonthsNUD);
            this.ImprisInfoTabPage.Controls.Add(this.label13);
            this.ImprisInfoTabPage.Controls.Add(this.PrisCellNUD);
            this.ImprisInfoTabPage.Controls.Add(this.ImprCountNUD);
            this.ImprisInfoTabPage.Controls.Add(this.JailingYearsNUD);
            this.ImprisInfoTabPage.Controls.Add(this.JailedDTP);
            this.ImprisInfoTabPage.Controls.Add(this.prisonCB);
            this.ImprisInfoTabPage.Controls.Add(this.label6);
            this.ImprisInfoTabPage.Controls.Add(this.label5);
            this.ImprisInfoTabPage.Controls.Add(this.label4);
            this.ImprisInfoTabPage.Controls.Add(this.label3);
            this.ImprisInfoTabPage.Controls.Add(this.label2);
            this.ImprisInfoTabPage.Controls.Add(this.label1);
            this.ImprisInfoTabPage.Location = new System.Drawing.Point(4, 22);
            this.ImprisInfoTabPage.Name = "ImprisInfoTabPage";
            this.ImprisInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ImprisInfoTabPage.Size = new System.Drawing.Size(525, 289);
            this.ImprisInfoTabPage.TabIndex = 1;
            this.ImprisInfoTabPage.Text = "Информация о заключении";
            this.ImprisInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // JailingMonthsNUD
            // 
            this.JailingMonthsNUD.Location = new System.Drawing.Point(30, 146);
            this.JailingMonthsNUD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.JailingMonthsNUD.Name = "JailingMonthsNUD";
            this.JailingMonthsNUD.Size = new System.Drawing.Size(47, 20);
            this.JailingMonthsNUD.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(83, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 22);
            this.label13.TabIndex = 11;
            this.label13.Text = "месяц(ев)";
            // 
            // PrisCellNUD
            // 
            this.PrisCellNUD.DecimalPlaces = 1;
            this.PrisCellNUD.Hexadecimal = true;
            this.PrisCellNUD.Location = new System.Drawing.Point(321, 46);
            this.PrisCellNUD.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.PrisCellNUD.Name = "PrisCellNUD";
            this.PrisCellNUD.Size = new System.Drawing.Size(82, 20);
            this.PrisCellNUD.TabIndex = 10;
            this.PrisCellNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ImprCountNUD
            // 
            this.ImprCountNUD.DecimalPlaces = 1;
            this.ImprCountNUD.Hexadecimal = true;
            this.ImprCountNUD.Location = new System.Drawing.Point(321, 120);
            this.ImprCountNUD.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ImprCountNUD.Name = "ImprCountNUD";
            this.ImprCountNUD.Size = new System.Drawing.Size(82, 20);
            this.ImprCountNUD.TabIndex = 9;
            this.ImprCountNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // JailingYearsNUD
            // 
            this.JailingYearsNUD.Location = new System.Drawing.Point(30, 120);
            this.JailingYearsNUD.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.JailingYearsNUD.Name = "JailingYearsNUD";
            this.JailingYearsNUD.Size = new System.Drawing.Size(47, 20);
            this.JailingYearsNUD.TabIndex = 8;
            // 
            // JailedDTP
            // 
            this.JailedDTP.Location = new System.Drawing.Point(30, 208);
            this.JailedDTP.Name = "JailedDTP";
            this.JailedDTP.Size = new System.Drawing.Size(154, 20);
            this.JailedDTP.TabIndex = 7;
            this.JailedDTP.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // prisonCB
            // 
            this.prisonCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prisonCB.FormattingEnabled = true;
            this.prisonCB.Items.AddRange(new object[] {
            "БутырскаяТюрьма",
            "Кресты",
            "ЛефортовскаяТюрьма",
            "МатросскаяТюрьма",
            "BlackDolphin",
            "ВладимирскийЦентрал",
            "БелыйЛебедь"});
            this.prisonCB.Location = new System.Drawing.Point(30, 45);
            this.prisonCB.Name = "prisonCB";
            this.prisonCB.Size = new System.Drawing.Size(154, 21);
            this.prisonCB.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(83, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "год(а)/лет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Срок заключения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(270, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер тюремной камеры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(270, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество заключений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата заключения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тюрьма";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.Location = new System.Drawing.Point(130, 322);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(119, 35);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // writableBtn
            // 
            this.writableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writableBtn.Location = new System.Drawing.Point(5, 322);
            this.writableBtn.Name = "writableBtn";
            this.writableBtn.Size = new System.Drawing.Size(119, 35);
            this.writableBtn.TabIndex = 23;
            this.writableBtn.Text = "Изменить";
            this.writableBtn.UseVisualStyleBackColor = true;
            this.writableBtn.Click += new System.EventHandler(this.writableBtn_Click);
            // 
            // PrisonerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(532, 365);
            this.Controls.Add(this.writableBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrisonerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление заключенного";
            this.tabControl1.ResumeLayout(false);
            this.PersInfoTabPage.ResumeLayout(false);
            this.PersInfoTabPage.PerformLayout();
            this.ImprisInfoTabPage.ResumeLayout(false);
            this.ImprisInfoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JailingMonthsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrisCellNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImprCountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JailingYearsNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PersInfoTabPage;
        private System.Windows.Forms.TabPage ImprisInfoTabPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox prisonCB;
        private System.Windows.Forms.TextBox MiddleNameTB;
        private System.Windows.Forms.TextBox SecondNameTB;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.DateTimePicker birthdayDTP;
        private System.Windows.Forms.ComboBox FamilyCB;
        private System.Windows.Forms.TextBox CityBornTB;
        private System.Windows.Forms.NumericUpDown PrisCellNUD;
        private System.Windows.Forms.NumericUpDown ImprCountNUD;
        private System.Windows.Forms.NumericUpDown JailingYearsNUD;
        private System.Windows.Forms.DateTimePicker JailedDTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button writableBtn;
        private System.Windows.Forms.NumericUpDown JailingMonthsNUD;
        private System.Windows.Forms.Label label13;
    }
}