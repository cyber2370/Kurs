namespace Kurs.Views
{
    partial class MainForm
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заключенныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсехЗаключенныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обобщенныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разработчикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CityBornTB = new System.Windows.Forms.TextBox();
            this.BirthdayDTP = new System.Windows.Forms.DateTimePicker();
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
            this.JailingMonthsNUD = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.PrisCellNUD = new System.Windows.Forms.NumericUpDown();
            this.ImprCountNUD = new System.Windows.Forms.NumericUpDown();
            this.JailingYearsNUD = new System.Windows.Forms.NumericUpDown();
            this.JailedDTP = new System.Windows.Forms.DateTimePicker();
            this.PrisonCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prison = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprisonmentInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisonerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JailingMonthsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrisCellNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImprCountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JailingYearsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.Location = new System.Drawing.Point(685, 281);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(97, 40);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Найти";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoGenerateColumns = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.personalInfoDataGridViewTextBoxColumn,
            this.imprisonmentInfoDataGridViewTextBoxColumn,
            this.MiddleName,
            this.Prison});
            this.DGV.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV.DataSource = this.prisonerBindingSource;
            this.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV.Location = new System.Drawing.Point(1, 327);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(810, 227);
            this.DGV.TabIndex = 4;
            this.DGV.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.DGV_CellContextMenuStripNeeded);
            this.DGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTMSI,
            this.changeTMSI,
            this.deleteTMSI});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 70);
            // 
            // showTMSI
            // 
            this.showTMSI.Name = "showTMSI";
            this.showTMSI.Size = new System.Drawing.Size(148, 22);
            this.showTMSI.Text = "Просмотреть";
            // 
            // changeTMSI
            // 
            this.changeTMSI.Name = "changeTMSI";
            this.changeTMSI.Size = new System.Drawing.Size(148, 22);
            this.changeTMSI.Text = "Изменить";
            this.changeTMSI.Click += new System.EventHandler(this.changeTMSI_Click);
            // 
            // deleteTMSI
            // 
            this.deleteTMSI.Name = "deleteTMSI";
            this.deleteTMSI.Size = new System.Drawing.Size(148, 22);
            this.deleteTMSI.Text = "Удалить";
            this.deleteTMSI.Click += new System.EventHandler(this.deleteTMSI_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.заключенныеToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // заключенныеToolStripMenuItem
            // 
            this.заключенныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.просмотретьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.удалитьВсехЗаключенныхToolStripMenuItem,
            this.обобщенныеДанныеToolStripMenuItem});
            this.заключенныеToolStripMenuItem.Name = "заключенныеToolStripMenuItem";
            this.заключенныеToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.заключенныеToolStripMenuItem.Text = "Заключенные";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // просмотретьToolStripMenuItem
            // 
            this.просмотретьToolStripMenuItem.Name = "просмотретьToolStripMenuItem";
            this.просмотретьToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.просмотретьToolStripMenuItem.Text = "Просмотреть";
            this.просмотретьToolStripMenuItem.Click += new System.EventHandler(this.просмотретьToolStripMenuItem_Click_1);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // удалитьВсехЗаключенныхToolStripMenuItem
            // 
            this.удалитьВсехЗаключенныхToolStripMenuItem.Name = "удалитьВсехЗаключенныхToolStripMenuItem";
            this.удалитьВсехЗаключенныхToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.удалитьВсехЗаключенныхToolStripMenuItem.Text = "Удалить всех";
            this.удалитьВсехЗаключенныхToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсехЗаключенныхToolStripMenuItem_Click);
            // 
            // обобщенныеДанныеToolStripMenuItem
            // 
            this.обобщенныеДанныеToolStripMenuItem.Name = "обобщенныеДанныеToolStripMenuItem";
            this.обобщенныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.обобщенныеДанныеToolStripMenuItem.Text = "Обобщенная информация";
            this.обобщенныеДанныеToolStripMenuItem.Click += new System.EventHandler(this.обобщенныеДанныеToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разработчикиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.помощьToolStripMenuItem.Text = "Справка";
            // 
            // разработчикиToolStripMenuItem
            // 
            this.разработчикиToolStripMenuItem.Name = "разработчикиToolStripMenuItem";
            this.разработчикиToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.разработчикиToolStripMenuItem.Text = "Разработчики";
            this.разработчикиToolStripMenuItem.Click += new System.EventHandler(this.разработчикиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // CityBornTB
            // 
            this.CityBornTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CityBornTB.Location = new System.Drawing.Point(213, 209);
            this.CityBornTB.Name = "CityBornTB";
            this.CityBornTB.Size = new System.Drawing.Size(138, 20);
            this.CityBornTB.TabIndex = 32;
            // 
            // BirthdayDTP
            // 
            this.BirthdayDTP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BirthdayDTP.Location = new System.Drawing.Point(213, 172);
            this.BirthdayDTP.Name = "BirthdayDTP";
            this.BirthdayDTP.Size = new System.Drawing.Size(138, 20);
            this.BirthdayDTP.TabIndex = 31;
            this.BirthdayDTP.Value = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            // 
            // FamilyCB
            // 
            this.FamilyCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FamilyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FamilyCB.FormattingEnabled = true;
            this.FamilyCB.Items.AddRange(new object[] {
            "Неизвестно",
            "Женат",
            "Не Женат",
            "Разведен"});
            this.FamilyCB.Location = new System.Drawing.Point(213, 245);
            this.FamilyCB.Name = "FamilyCB";
            this.FamilyCB.Size = new System.Drawing.Size(137, 21);
            this.FamilyCB.TabIndex = 30;
            // 
            // MiddleNameTB
            // 
            this.MiddleNameTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MiddleNameTB.Location = new System.Drawing.Point(213, 139);
            this.MiddleNameTB.Name = "MiddleNameTB";
            this.MiddleNameTB.Size = new System.Drawing.Size(138, 20);
            this.MiddleNameTB.TabIndex = 29;
            // 
            // SecondNameTB
            // 
            this.SecondNameTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SecondNameTB.Location = new System.Drawing.Point(213, 101);
            this.SecondNameTB.Name = "SecondNameTB";
            this.SecondNameTB.Size = new System.Drawing.Size(138, 20);
            this.SecondNameTB.TabIndex = 28;
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstNameTB.Location = new System.Drawing.Point(213, 65);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(138, 20);
            this.FirstNameTB.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Дата рождения";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Семейное положение";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 24;
            this.label9.Text = "Фамилия";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Родной город";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Отчество";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 22);
            this.label12.TabIndex = 21;
            this.label12.Text = "Имя";
            // 
            // JailingMonthsNUD
            // 
            this.JailingMonthsNUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JailingMonthsNUD.Location = new System.Drawing.Point(622, 245);
            this.JailingMonthsNUD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.JailingMonthsNUD.Name = "JailingMonthsNUD";
            this.JailingMonthsNUD.Size = new System.Drawing.Size(47, 20);
            this.JailingMonthsNUD.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(681, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 22);
            this.label13.TabIndex = 44;
            this.label13.Text = "месяц(ев)";
            // 
            // PrisCellNUD
            // 
            this.PrisCellNUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PrisCellNUD.DecimalPlaces = 1;
            this.PrisCellNUD.Hexadecimal = true;
            this.PrisCellNUD.Location = new System.Drawing.Point(694, 100);
            this.PrisCellNUD.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.PrisCellNUD.Name = "PrisCellNUD";
            this.PrisCellNUD.Size = new System.Drawing.Size(82, 20);
            this.PrisCellNUD.TabIndex = 43;
            // 
            // ImprCountNUD
            // 
            this.ImprCountNUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImprCountNUD.DecimalPlaces = 1;
            this.ImprCountNUD.Hexadecimal = true;
            this.ImprCountNUD.Location = new System.Drawing.Point(694, 138);
            this.ImprCountNUD.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ImprCountNUD.Name = "ImprCountNUD";
            this.ImprCountNUD.Size = new System.Drawing.Size(82, 20);
            this.ImprCountNUD.TabIndex = 42;
            // 
            // JailingYearsNUD
            // 
            this.JailingYearsNUD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JailingYearsNUD.Location = new System.Drawing.Point(622, 211);
            this.JailingYearsNUD.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.JailingYearsNUD.Name = "JailingYearsNUD";
            this.JailingYearsNUD.Size = new System.Drawing.Size(47, 20);
            this.JailingYearsNUD.TabIndex = 41;
            // 
            // JailedDTP
            // 
            this.JailedDTP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JailedDTP.Location = new System.Drawing.Point(622, 171);
            this.JailedDTP.Name = "JailedDTP";
            this.JailedDTP.Size = new System.Drawing.Size(154, 20);
            this.JailedDTP.TabIndex = 40;
            this.JailedDTP.Value = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            // 
            // PrisonCB
            // 
            this.PrisonCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PrisonCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrisonCB.FormattingEnabled = true;
            this.PrisonCB.Items.AddRange(new object[] {
            "Неизвестно",
            "Бутырская Тюрьма",
            "Кресты",
            "Лефортовская Тюрьма",
            "Матросская Тюрьма",
            "Владимирский Централ",
            "Белый Лебедь"});
            this.PrisonCB.Location = new System.Drawing.Point(622, 62);
            this.PrisonCB.Name = "PrisonCB";
            this.PrisonCB.Size = new System.Drawing.Size(154, 21);
            this.PrisonCB.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(683, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 38;
            this.label6.Text = "год(а)/лет";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(433, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Срок заключения";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(433, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 22);
            this.label4.TabIndex = 36;
            this.label4.Text = "Номер тюремной камеры";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(433, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Количество заключений";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(433, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Дата заключения";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(433, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Тюрьма";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(311, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 20);
            this.label14.TabIndex = 46;
            this.label14.Text = "Поиск заключенных";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(557, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 47;
            this.button1.Text = "Сброс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "MiddleName";
            this.MiddleName.HeaderText = "Отчество";
            this.MiddleName.MinimumWidth = 150;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // Prison
            // 
            this.Prison.DataPropertyName = "Prison";
            this.Prison.FillWeight = 82.23203F;
            this.Prison.HeaderText = "Тюрьма";
            this.Prison.MinimumWidth = 150;
            this.Prison.Name = "Prison";
            this.Prison.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 72.17101F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalInfoDataGridViewTextBoxColumn
            // 
            this.personalInfoDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.personalInfoDataGridViewTextBoxColumn.FillWeight = 134.7716F;
            this.personalInfoDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.personalInfoDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.personalInfoDataGridViewTextBoxColumn.Name = "personalInfoDataGridViewTextBoxColumn";
            this.personalInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imprisonmentInfoDataGridViewTextBoxColumn
            // 
            this.imprisonmentInfoDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            this.imprisonmentInfoDataGridViewTextBoxColumn.FillWeight = 110.8254F;
            this.imprisonmentInfoDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.imprisonmentInfoDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.imprisonmentInfoDataGridViewTextBoxColumn.Name = "imprisonmentInfoDataGridViewTextBoxColumn";
            this.imprisonmentInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prisonerBindingSource
            // 
            this.prisonerBindingSource.DataSource = typeof(Kurs.Model.Prisoner);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.JailingMonthsNUD);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PrisCellNUD);
            this.Controls.Add(this.ImprCountNUD);
            this.Controls.Add(this.JailingYearsNUD);
            this.Controls.Add(this.JailedDTP);
            this.Controls.Add(this.PrisonCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CityBornTB);
            this.Controls.Add(this.BirthdayDTP);
            this.Controls.Add(this.FamilyCB);
            this.Controls.Add(this.MiddleNameTB);
            this.Controls.Add(this.SecondNameTB);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник начальника тюрьмы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JailingMonthsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrisCellNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImprCountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JailingYearsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.BindingSource prisonerBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заключенныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсехЗаключенныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разработчикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обобщенныеДанныеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showTMSI;
        private System.Windows.Forms.ToolStripMenuItem changeTMSI;
        private System.Windows.Forms.ToolStripMenuItem deleteTMSI;
        private System.Windows.Forms.TextBox CityBornTB;
        private System.Windows.Forms.DateTimePicker BirthdayDTP;
        private System.Windows.Forms.ComboBox FamilyCB;
        private System.Windows.Forms.TextBox MiddleNameTB;
        private System.Windows.Forms.TextBox SecondNameTB;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown JailingMonthsNUD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown PrisCellNUD;
        private System.Windows.Forms.NumericUpDown ImprCountNUD;
        private System.Windows.Forms.NumericUpDown JailingYearsNUD;
        private System.Windows.Forms.DateTimePicker JailedDTP;
        private System.Windows.Forms.ComboBox PrisonCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imprisonmentInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prison;
    }
}