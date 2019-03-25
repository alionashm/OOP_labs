namespace laba2
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
            this.buttonInfo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxAuto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumofCyl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEngine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSeats = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAxles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLoad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRoutes = new System.Windows.Forms.TextBox();
            this.textBoxApp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxLen = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(12, 393);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(235, 31);
            this.buttonInfo.TabIndex = 63;
            this.buttonInfo.Text = "Получить инф-цию об автопарке";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 240);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 147);
            this.listBox1.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(247, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 60;
            this.label12.Text = "Вид авто:";
            // 
            // comboBoxAuto
            // 
            this.comboBoxAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuto.FormattingEnabled = true;
            this.comboBoxAuto.Items.AddRange(new object[] {
            "Автомобиль",
            "Легковой автомобиль",
            "Грузовой автомобиль",
            "Автобус",
            "Маршрутное такси"});
            this.comboBoxAuto.Location = new System.Drawing.Point(250, 23);
            this.comboBoxAuto.Name = "comboBoxAuto";
            this.comboBoxAuto.Size = new System.Drawing.Size(175, 21);
            this.comboBoxAuto.TabIndex = 59;
            this.comboBoxAuto.Tag = "";
            this.comboBoxAuto.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Мощность:";
            // 
            // textBoxPower
            // 
            this.textBoxPower.Location = new System.Drawing.Point(12, 205);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(145, 20);
            this.textBoxPower.TabIndex = 46;
            this.textBoxPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPower_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Количество цилиндров:";
            // 
            // textBoxNumofCyl
            // 
            this.textBoxNumofCyl.Location = new System.Drawing.Point(12, 166);
            this.textBoxNumofCyl.Name = "textBoxNumofCyl";
            this.textBoxNumofCyl.Size = new System.Drawing.Size(145, 20);
            this.textBoxNumofCyl.TabIndex = 43;
            this.textBoxNumofCyl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumofCyl_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Год выпуска:";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(12, 63);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(145, 20);
            this.textBoxModel.TabIndex = 41;
            this.textBoxModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxModel_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Модель:";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(12, 24);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(145, 20);
            this.textBoxBrand.TabIndex = 39;
            this.textBoxBrand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBrand_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Марка:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(703, 10);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(99, 47);
            this.buttonEdit.TabIndex = 36;
            this.buttonEdit.Text = "Изменить авто";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(598, 10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 47);
            this.buttonDelete.TabIndex = 35;
            this.buttonDelete.Text = "Удалить авто";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(493, 10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(99, 47);
            this.buttonAdd.TabIndex = 34;
            this.buttonAdd.Text = "Добавить авто";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBrand,
            this.ColumnModel,
            this.ColumnYear,
            this.ColumnEngine});
            this.dataGridView1.Location = new System.Drawing.Point(274, 199);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.Size = new System.Drawing.Size(528, 224);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ColumnBrand
            // 
            this.ColumnBrand.HeaderText = "Марка";
            this.ColumnBrand.Name = "ColumnBrand";
            this.ColumnBrand.ReadOnly = true;
            // 
            // ColumnModel
            // 
            this.ColumnModel.HeaderText = "Модель";
            this.ColumnModel.Name = "ColumnModel";
            this.ColumnModel.ReadOnly = true;
            // 
            // ColumnYear
            // 
            this.ColumnYear.HeaderText = "Год выпуска";
            this.ColumnYear.Name = "ColumnYear";
            this.ColumnYear.ReadOnly = true;
            // 
            // ColumnEngine
            // 
            this.ColumnEngine.HeaderText = "Двигатель";
            this.ColumnEngine.Name = "ColumnEngine";
            this.ColumnEngine.ReadOnly = true;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(12, 102);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(145, 20);
            this.textBoxYear.TabIndex = 64;
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(250, 141);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(145, 20);
            this.textBoxCategory.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Категория:";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(250, 102);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(145, 20);
            this.textBoxType.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Тип кузова:";
            // 
            // textBoxSeats
            // 
            this.textBoxSeats.Location = new System.Drawing.Point(250, 63);
            this.textBoxSeats.Name = "textBoxSeats";
            this.textBoxSeats.Size = new System.Drawing.Size(145, 20);
            this.textBoxSeats.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Места:";
            // 
            // textBoxAxles
            // 
            this.textBoxAxles.Location = new System.Drawing.Point(249, 102);
            this.textBoxAxles.Name = "textBoxAxles";
            this.textBoxAxles.Size = new System.Drawing.Size(146, 20);
            this.textBoxAxles.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Количество осей:";
            // 
            // textBoxLoad
            // 
            this.textBoxLoad.Location = new System.Drawing.Point(249, 63);
            this.textBoxLoad.Name = "textBoxLoad";
            this.textBoxLoad.Size = new System.Drawing.Size(146, 20);
            this.textBoxLoad.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Грузоподъемность:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 77;
            this.label11.Text = "Длина маршрута:";
            // 
            // textBoxRoutes
            // 
            this.textBoxRoutes.Location = new System.Drawing.Point(250, 150);
            this.textBoxRoutes.Name = "textBoxRoutes";
            this.textBoxRoutes.Size = new System.Drawing.Size(144, 20);
            this.textBoxRoutes.TabIndex = 76;
            // 
            // textBoxApp
            // 
            this.textBoxApp.Location = new System.Drawing.Point(251, 109);
            this.textBoxApp.Name = "textBoxApp";
            this.textBoxApp.Size = new System.Drawing.Size(145, 20);
            this.textBoxApp.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 80;
            this.label13.Text = "Назначение:";
            // 
            // textBoxLen
            // 
            this.textBoxLen.Location = new System.Drawing.Point(251, 63);
            this.textBoxLen.Name = "textBoxLen";
            this.textBoxLen.Size = new System.Drawing.Size(145, 20);
            this.textBoxLen.TabIndex = 79;
            this.textBoxLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLen_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(248, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 78;
            this.label14.Text = "Вместимость:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(9, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(216, 17);
            this.label15.TabIndex = 82;
            this.label15.Text = "Характеристики двигателя:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 435);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxApp);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxLen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxRoutes);
            this.Controls.Add(this.textBoxAxles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLoad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSeats);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxAuto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPower);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNumofCyl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxAuto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumofCyl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEngine;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSeats;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAxles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLoad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRoutes;
        private System.Windows.Forms.TextBox textBoxApp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxLen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

