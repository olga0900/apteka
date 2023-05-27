namespace курсовая1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label masterNameLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label label2;
            this.aptekaDataSet1 = new курсовая1.aptekaDataSet();
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.medicineBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medicineBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.deleteB = new System.Windows.Forms.Button();
            this.saveB = new System.Windows.Forms.Button();
            this.InsertB = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.medicineTableAdapter1 = new курсовая1.aptekaDataSetTableAdapters.MedicineTableAdapter();
            this.tableAdapterManager1 = new курсовая1.aptekaDataSetTableAdapters.TableAdapterManager();
            this.button5 = new System.Windows.Forms.Button();
            masterNameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingNavigator)).BeginInit();
            this.medicineBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // aptekaDataSet1
            // 
            this.aptekaDataSet1.DataSetName = "aptekaDataSet";
            this.aptekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataMember = "Medicine";
            this.medicineBindingSource.DataSource = this.aptekaDataSet1;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 33);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // medicineBindingNavigatorSaveItem
            // 
            this.medicineBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicineBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicineBindingNavigatorSaveItem.Image")));
            this.medicineBindingNavigatorSaveItem.Name = "medicineBindingNavigatorSaveItem";
            this.medicineBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.medicineBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.medicineBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicineBindingNavigatorSaveItem_Click);
            // 
            // medicineBindingNavigator
            // 
            this.medicineBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicineBindingNavigator.BindingSource = this.medicineBindingSource;
            this.medicineBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicineBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicineBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.medicineBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.medicineBindingNavigatorSaveItem});
            this.medicineBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicineBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicineBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicineBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicineBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicineBindingNavigator.Name = "medicineBindingNavigator";
            this.medicineBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicineBindingNavigator.Size = new System.Drawing.Size(1028, 33);
            this.medicineBindingNavigator.TabIndex = 0;
            this.medicineBindingNavigator.Text = "bindingNavigator1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(239, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 63);
            this.label1.TabIndex = 10;
            this.label1.Text = "Редактирование товаров";
            // 
            // deleteB
            // 
            this.deleteB.BackColor = System.Drawing.Color.Crimson;
            this.deleteB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.deleteB.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteB.Location = new System.Drawing.Point(370, 480);
            this.deleteB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(244, 54);
            this.deleteB.TabIndex = 33;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = false;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // saveB
            // 
            this.saveB.BackColor = System.Drawing.Color.White;
            this.saveB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveB.FlatAppearance.BorderSize = 0;
            this.saveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.saveB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveB.Location = new System.Drawing.Point(669, 480);
            this.saveB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(196, 54);
            this.saveB.TabIndex = 32;
            this.saveB.Text = "💾 Сохранить";
            this.saveB.UseVisualStyleBackColor = false;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // InsertB
            // 
            this.InsertB.BackColor = System.Drawing.Color.DarkOrange;
            this.InsertB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.InsertB.ForeColor = System.Drawing.SystemColors.Control;
            this.InsertB.Location = new System.Drawing.Point(104, 480);
            this.InsertB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InsertB.Name = "InsertB";
            this.InsertB.Size = new System.Drawing.Size(220, 54);
            this.InsertB.TabIndex = 31;
            this.InsertB.Text = "Вставить";
            this.InsertB.UseVisualStyleBackColor = false;
            this.InsertB.Click += new System.EventHandler(this.InsertB_Click);
            // 
            // masterNameLabel
            // 
            masterNameLabel.AutoSize = true;
            masterNameLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            masterNameLabel.Location = new System.Drawing.Point(94, 211);
            masterNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            masterNameLabel.Name = "masterNameLabel";
            masterNameLabel.Size = new System.Drawing.Size(290, 34);
            masterNameLabel.TabIndex = 34;
            masterNameLabel.Text = "Назание препарата:";
            // 
            // TextBox
            // 
            this.TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicineBindingSource, "MedicinesName", true));
            this.TextBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(403, 217);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(480, 30);
            this.TextBox.TabIndex = 35;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            categoryLabel.Location = new System.Drawing.Point(217, 302);
            categoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(167, 34);
            categoryLabel.TabIndex = 34;
            categoryLabel.Text = "Категория:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicineBindingSource, "Category", true));
            this.textBox1.Location = new System.Drawing.Point(403, 302);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 35);
            this.textBox1.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(290, 375);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 34);
            label2.TabIndex = 37;
            label2.Text = "Цена:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicineBindingSource, "Price", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(403, 382);
            this.maskedTextBox1.Mask = "000.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(242, 26);
            this.maskedTextBox1.TabIndex = 38;
            // 
            // medicineTableAdapter1
            // 
            this.medicineTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientTableAdapter = null;
            this.tableAdapterManager1.LoginsTableAdapter = null;
            this.tableAdapterManager1.MedicineTableAdapter = this.medicineTableAdapter1;
            this.tableAdapterManager1.OrdersTableAdapter = null;
            this.tableAdapterManager1.ServiceservTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = курсовая1.aptekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PeachPuff;
            this.button5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Maroon;
            this.button5.Location = new System.Drawing.Point(787, 586);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 41);
            this.button5.TabIndex = 39;
            this.button5.Text = "Назад";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1028, 655);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(masterNameLabel);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.InsertB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medicineBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Редактирование товаров";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingNavigator)).EndInit();
            this.medicineBindingNavigator.ResumeLayout(false);
            this.medicineBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private aptekaDataSet aptekaDataSet1;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton medicineBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator medicineBindingNavigator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button InsertB;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private aptekaDataSetTableAdapters.MedicineTableAdapter medicineTableAdapter1;
        private aptekaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button5;
    }
}