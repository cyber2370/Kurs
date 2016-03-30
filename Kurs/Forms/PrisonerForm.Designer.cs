namespace Kurs.Forms
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPrison = new System.Windows.Forms.Label();
            this.lblPrisonCell = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.lblRelations = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(37, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.Location = new System.Drawing.Point(37, 94);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(82, 22);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblPrison
            // 
            this.lblPrison.AutoSize = true;
            this.lblPrison.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrison.Location = new System.Drawing.Point(37, 137);
            this.lblPrison.Name = "lblPrison";
            this.lblPrison.Size = new System.Drawing.Size(61, 22);
            this.lblPrison.TabIndex = 2;
            this.lblPrison.Text = "Prison";
            // 
            // lblPrisonCell
            // 
            this.lblPrisonCell.AutoSize = true;
            this.lblPrisonCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrisonCell.Location = new System.Drawing.Point(37, 177);
            this.lblPrisonCell.Name = "lblPrisonCell";
            this.lblPrisonCell.Size = new System.Drawing.Size(92, 22);
            this.lblPrisonCell.TabIndex = 3;
            this.lblPrisonCell.Text = "PrisonCell";
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArticle.Location = new System.Drawing.Point(37, 214);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(60, 22);
            this.lblArticle.TabIndex = 4;
            this.lblArticle.Text = "Article";
            // 
            // lblRelations
            // 
            this.lblRelations.AutoSize = true;
            this.lblRelations.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRelations.Location = new System.Drawing.Point(215, 59);
            this.lblRelations.Name = "lblRelations";
            this.lblRelations.Size = new System.Drawing.Size(85, 22);
            this.lblRelations.TabIndex = 5;
            this.lblRelations.Text = "Relations";
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCharacter.Location = new System.Drawing.Point(215, 161);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(89, 22);
            this.lblCharacter.TabIndex = 6;
            this.lblCharacter.Text = "Character";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(336, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 41);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.Location = new System.Drawing.Point(223, 321);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(107, 41);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(110, 321);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 41);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // PrisonerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 374);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCharacter);
            this.Controls.Add(this.lblRelations);
            this.Controls.Add(this.lblArticle);
            this.Controls.Add(this.lblPrisonCell);
            this.Controls.Add(this.lblPrison);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "PrisonerForm";
            this.Text = "Подробная информация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPrison;
        private System.Windows.Forms.Label lblPrisonCell;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label lblRelations;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
    }
}