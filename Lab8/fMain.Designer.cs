﻿namespace Lab8
{
    partial class fMain
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
            this.btnAddProcessor = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbProcessorInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddProcessor
            // 
            this.btnAddProcessor.Location = new System.Drawing.Point(666, 5);
            this.btnAddProcessor.Name = "btnAddProcessor";
            this.btnAddProcessor.Size = new System.Drawing.Size(129, 23);
            this.btnAddProcessor.TabIndex = 1;
            this.btnAddProcessor.Text = "Додати процессор";
            this.btnAddProcessor.UseVisualStyleBackColor = true;
            this.btnAddProcessor.Click += new System.EventHandler(this.btnAddProcessor_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(666, 221);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbProcessorInfo
            // 
            this.lbProcessorInfo.FormattingEnabled = true;
            this.lbProcessorInfo.Location = new System.Drawing.Point(12, 6);
            this.lbProcessorInfo.Name = "lbProcessorInfo";
            this.lbProcessorInfo.Size = new System.Drawing.Size(648, 238);
            this.lbProcessorInfo.TabIndex = 3;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.Controls.Add(this.lbProcessorInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddProcessor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №8";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddProcessor;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbProcessorInfo;
    }
}

