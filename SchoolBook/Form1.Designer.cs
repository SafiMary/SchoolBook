namespace SchoolBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxStud = new System.Windows.Forms.ListBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.maskTextBoxbirthd = new System.Windows.Forms.MaskedTextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSaveSer = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStud
            // 
            this.listBoxStud.FormattingEnabled = true;
            this.listBoxStud.ItemHeight = 20;
            this.listBoxStud.Location = new System.Drawing.Point(525, 48);
            this.listBoxStud.Name = "listBoxStud";
            this.listBoxStud.Size = new System.Drawing.Size(437, 224);
            this.listBoxStud.TabIndex = 0;
            this.listBoxStud.SelectedIndexChanged += new System.EventHandler(this.listBoxStud_SelectedIndexChanged);
            // 
            // textBoxNum
            // 
            this.textBoxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNum.Location = new System.Drawing.Point(41, 48);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(175, 34);
            this.textBoxNum.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(41, 143);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(175, 34);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(41, 217);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 34);
            this.textBoxName.TabIndex = 2;
            // 
            // maskTextBoxbirthd
            // 
            this.maskTextBoxbirthd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskTextBoxbirthd.Location = new System.Drawing.Point(41, 351);
            this.maskTextBoxbirthd.Mask = "00.00.0000";
            this.maskTextBoxbirthd.Name = "maskTextBoxbirthd";
            this.maskTextBoxbirthd.Size = new System.Drawing.Size(175, 34);
            this.maskTextBoxbirthd.TabIndex = 3;
            this.maskTextBoxbirthd.ValidatingType = typeof(System.DateTime);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(41, 26);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(175, 20);
            this.labelNum.TabIndex = 4;
            this.labelNum.Text = "Порядковый Номер";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(45, 121);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(87, 20);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(45, 195);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 20);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Имя";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(45, 316);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(141, 20);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Дата рождения";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(45, 438);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 63);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSaveSer
            // 
            this.buttonSaveSer.Location = new System.Drawing.Point(224, 438);
            this.buttonSaveSer.Name = "buttonSaveSer";
            this.buttonSaveSer.Size = new System.Drawing.Size(137, 63);
            this.buttonSaveSer.TabIndex = 8;
            this.buttonSaveSer.Text = "Сохранить(сериализация)";
            this.buttonSaveSer.UseVisualStyleBackColor = true;
            this.buttonSaveSer.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(415, 438);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(137, 63);
            this.buttonClean.TabIndex = 8;
            this.buttonClean.Text = "Очистить";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(625, 438);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(137, 63);
            this.buttonSort.TabIndex = 8;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonSaveSer);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.maskTextBoxbirthd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.listBoxStud);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Школьный журнал";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStud;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MaskedTextBox maskTextBoxbirthd;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSaveSer;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonSort;
    }
}

