﻿namespace turagenstvo2
{
    partial class Query
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.turagenstvoDataSet = new turagenstvo2.turagenstvoDataSet();
            this.poezdkiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poezdkiiTableAdapter = new turagenstvo2.turagenstvoDataSetTableAdapters.poezdkiiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.turistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turistTableAdapter = new turagenstvo2.turagenstvoDataSetTableAdapters.turistTableAdapter();
            this.tableAdapterManager = new turagenstvo2.turagenstvoDataSetTableAdapters.TableAdapterManager();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.fKpoezdkiituristBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.poezdkiiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.turagenstvoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poezdkiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKpoezdkiituristBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poezdkiiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Popov";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Arseniy";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Ivanovich";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(91, 262);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 20);
            this.textBox4.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "id",
            "num_putevki",
            "pasp_turista",
            "data",
            "data_vozvrasheniya",
            "status",
            "status_oplati",
            "dop_infa",
            "stoimost"});
            this.comboBox1.Location = new System.Drawing.Point(91, 208);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // turagenstvoDataSet
            // 
            this.turagenstvoDataSet.DataSetName = "turagenstvoDataSet";
            this.turagenstvoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poezdkiiBindingSource
            // 
            this.poezdkiiBindingSource.DataMember = "poezdkii";
            this.poezdkiiBindingSource.DataSource = this.turagenstvoDataSet;
            // 
            // poezdkiiTableAdapter
            // 
            this.poezdkiiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // turistBindingSource
            // 
            this.turistBindingSource.DataMember = "turist";
            this.turistBindingSource.DataSource = this.turagenstvoDataSet;
            // 
            // turistTableAdapter
            // 
            this.turistTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.poezdkiiTableAdapter = this.poezdkiiTableAdapter;
            this.tableAdapterManager.putevkiTableAdapter = null;
            this.tableAdapterManager.turistTableAdapter = this.turistTableAdapter;
            this.tableAdapterManager.UpdateOrder = turagenstvo2.turagenstvoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "familiya",
            "imya",
            "otchestvo",
            "passp_dannye",
            "e_mail",
            "telefon",
            "mesto_raboti"});
            this.comboBox2.Location = new System.Drawing.Point(91, 208);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // fKpoezdkiituristBindingSource
            // 
            this.fKpoezdkiituristBindingSource.DataMember = "FK_poezdkii_turist";
            this.fKpoezdkiituristBindingSource.DataSource = this.turistBindingSource;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "",
            "num",
            "strana",
            "gorod",
            "mesto_projivaniya",
            "stoimost",
            "strahovka",
            "dop_infa",
            "dlitelnost"});
            this.comboBox3.Location = new System.Drawing.Point(91, 208);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 21);
            this.comboBox3.TabIndex = 12;
            // 
            // poezdkiiBindingSource1
            // 
            this.poezdkiiBindingSource1.DataMember = "poezdkii";
            this.poezdkiiBindingSource1.DataSource = this.turagenstvoDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Query";
            this.Text = "Query";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Query_FormClosing);
            this.Load += new System.EventHandler(this.Query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turagenstvoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poezdkiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKpoezdkiituristBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poezdkiiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private turagenstvoDataSet turagenstvoDataSet;
        private System.Windows.Forms.BindingSource poezdkiiBindingSource;
        private turagenstvoDataSetTableAdapters.poezdkiiTableAdapter poezdkiiTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource turistBindingSource;
        private turagenstvoDataSetTableAdapters.turistTableAdapter turistTableAdapter;
        private turagenstvoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource fKpoezdkiituristBindingSource;
        private System.Windows.Forms.BindingSource poezdkiiBindingSource1;
        private System.Windows.Forms.Button button2;
    }
}