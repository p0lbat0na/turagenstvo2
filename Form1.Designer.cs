namespace turagenstvo2
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путевкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пездкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.туристыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сколькоТуристовПосетилоАнглиюВТекущемГодуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стоимостьПутевкиВТуристическийЛагерьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.естьЛиПутевкиВЕгипетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вКакомОтелеОстановилсяТуристToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.другойЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поСтранеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поСтоимостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поОтеллюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.туристыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поездкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путевкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.путевкиToolStripMenuItem,
            this.пездкиToolStripMenuItem,
            this.туристыToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            this.данныеToolStripMenuItem.Click += new System.EventHandler(this.данныеToolStripMenuItem_Click);
            // 
            // путевкиToolStripMenuItem
            // 
            this.путевкиToolStripMenuItem.Name = "путевкиToolStripMenuItem";
            this.путевкиToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.путевкиToolStripMenuItem.Text = "Путевки";
            this.путевкиToolStripMenuItem.Click += new System.EventHandler(this.путевкиToolStripMenuItem_Click);
            // 
            // пездкиToolStripMenuItem
            // 
            this.пездкиToolStripMenuItem.Name = "пездкиToolStripMenuItem";
            this.пездкиToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.пездкиToolStripMenuItem.Text = "Поездки";
            this.пездкиToolStripMenuItem.Click += new System.EventHandler(this.пездкиToolStripMenuItem_Click);
            // 
            // туристыToolStripMenuItem
            // 
            this.туристыToolStripMenuItem.Name = "туристыToolStripMenuItem";
            this.туристыToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.туристыToolStripMenuItem.Text = "Туристы";
            this.туристыToolStripMenuItem.Click += new System.EventHandler(this.туристыToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сколькоТуристовПосетилоАнглиюВТекущемГодуToolStripMenuItem,
            this.стоимостьПутевкиВТуристическийЛагерьToolStripMenuItem,
            this.естьЛиПутевкиВЕгипетToolStripMenuItem,
            this.вКакомОтелеОстановилсяТуристToolStripMenuItem,
            this.другойЗапросToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // сколькоТуристовПосетилоАнглиюВТекущемГодуToolStripMenuItem
            // 
            this.сколькоТуристовПосетилоАнглиюВТекущемГодуToolStripMenuItem.Name = "сколькоТуристовПосетилоАнглиюВТекущемГодуToolStripMenuItem";
            this.сколькоТуристовПосетилоАнглиюВТекущемГодуToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.сколькоТуристовПосетилоАнглиюВТекущемГодуToolStripMenuItem.Text = "Сколько туристов посетило Англию в текущем году";
            this.сколькоТуристовПосетилоАнглиюВТекущемГодуToolStripMenuItem.Click += new System.EventHandler(this.сколькоТуристовПосетилоАнглиюВТекущемГодуToolStripMenuItem_Click);
            // 
            // стоимостьПутевкиВТуристическийЛагерьToolStripMenuItem
            // 
            this.стоимостьПутевкиВТуристическийЛагерьToolStripMenuItem.Name = "стоимостьПутевкиВТуристическийЛагерьToolStripMenuItem";
            this.стоимостьПутевкиВТуристическийЛагерьToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.стоимостьПутевкиВТуристическийЛагерьToolStripMenuItem.Text = "Стоимость путевки в туристический лагерь";
            this.стоимостьПутевкиВТуристическийЛагерьToolStripMenuItem.Click += new System.EventHandler(this.стоимостьПутевкиВТуристическийЛагерьToolStripMenuItem_Click);
            // 
            // естьЛиПутевкиВЕгипетToolStripMenuItem
            // 
            this.естьЛиПутевкиВЕгипетToolStripMenuItem.Name = "естьЛиПутевкиВЕгипетToolStripMenuItem";
            this.естьЛиПутевкиВЕгипетToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.естьЛиПутевкиВЕгипетToolStripMenuItem.Text = "Есть ли путевки в Египет";
            this.естьЛиПутевкиВЕгипетToolStripMenuItem.Click += new System.EventHandler(this.естьЛиПутевкиВЕгипетToolStripMenuItem_Click);
            // 
            // вКакомОтелеОстановилсяТуристToolStripMenuItem
            // 
            this.вКакомОтелеОстановилсяТуристToolStripMenuItem.Name = "вКакомОтелеОстановилсяТуристToolStripMenuItem";
            this.вКакомОтелеОстановилсяТуристToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.вКакомОтелеОстановилсяТуристToolStripMenuItem.Text = "В каком отеле остановился турист...";
            this.вКакомОтелеОстановилсяТуристToolStripMenuItem.Click += new System.EventHandler(this.вКакомОтелеОстановилсяТуристToolStripMenuItem_Click);
            // 
            // другойЗапросToolStripMenuItem
            // 
            this.другойЗапросToolStripMenuItem.Name = "другойЗапросToolStripMenuItem";
            this.другойЗапросToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.другойЗапросToolStripMenuItem.Text = "Другой запрос";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поСтранеToolStripMenuItem,
            this.поСтоимостиToolStripMenuItem,
            this.поОтеллюToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поСтранеToolStripMenuItem
            // 
            this.поСтранеToolStripMenuItem.Name = "поСтранеToolStripMenuItem";
            this.поСтранеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поСтранеToolStripMenuItem.Text = "В путевках";
            this.поСтранеToolStripMenuItem.Click += new System.EventHandler(this.поСтранеToolStripMenuItem_Click);
            // 
            // поСтоимостиToolStripMenuItem
            // 
            this.поСтоимостиToolStripMenuItem.Name = "поСтоимостиToolStripMenuItem";
            this.поСтоимостиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поСтоимостиToolStripMenuItem.Text = "В поездках";
            this.поСтоимостиToolStripMenuItem.Click += new System.EventHandler(this.поСтоимостиToolStripMenuItem_Click);
            // 
            // поОтеллюToolStripMenuItem
            // 
            this.поОтеллюToolStripMenuItem.Name = "поОтеллюToolStripMenuItem";
            this.поОтеллюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поОтеллюToolStripMenuItem.Text = "В туристах";
            this.поОтеллюToolStripMenuItem.Click += new System.EventHandler(this.поОтеллюToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.туристыToolStripMenuItem1,
            this.поездкиToolStripMenuItem,
            this.путевкиToolStripMenuItem1});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // туристыToolStripMenuItem1
            // 
            this.туристыToolStripMenuItem1.Name = "туристыToolStripMenuItem1";
            this.туристыToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.туристыToolStripMenuItem1.Text = "Туристы";
            this.туристыToolStripMenuItem1.Click += new System.EventHandler(this.туристыToolStripMenuItem1_Click);
            // 
            // поездкиToolStripMenuItem
            // 
            this.поездкиToolStripMenuItem.Name = "поездкиToolStripMenuItem";
            this.поездкиToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.поездкиToolStripMenuItem.Text = "Поездки";
            this.поездкиToolStripMenuItem.Click += new System.EventHandler(this.поездкиToolStripMenuItem_Click);
            // 
            // путевкиToolStripMenuItem1
            // 
            this.путевкиToolStripMenuItem1.Name = "путевкиToolStripMenuItem1";
            this.путевкиToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.путевкиToolStripMenuItem1.Text = "Путевки";
            this.путевкиToolStripMenuItem1.Click += new System.EventHandler(this.путевкиToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 294);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путевкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пездкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem туристыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сколькоТуристовПосетилоАнглиюВТекущемГодуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стоимостьПутевкиВТуристическийЛагерьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem естьЛиПутевкиВЕгипетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вКакомОтелеОстановилсяТуристToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem другойЗапросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поСтранеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поСтоимостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поОтеллюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem туристыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поездкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путевкиToolStripMenuItem1;
    }
}

