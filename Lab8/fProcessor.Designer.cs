namespace Lab8
{
    partial class fProcessor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFamily = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbSocket = new System.Windows.Forms.TextBox();
            this.tbCores = new System.Windows.Forms.TextBox();
            this.tbFreq = new System.Windows.Forms.TextBox();
            this.chbHasGraphics = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chbHasMultiplier = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFreq);
            this.groupBox1.Controls.Add(this.tbCores);
            this.groupBox1.Controls.Add(this.tbSocket);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.tbFamily);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHasMultiplier);
            this.groupBox2.Controls.Add(this.chbHasGraphics);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додатково";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сімейство процесор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип роз\'єму";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кількість ядер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тактова частота";
            // 
            // tbFamily
            // 
            this.tbFamily.Location = new System.Drawing.Point(141, 31);
            this.tbFamily.Name = "tbFamily";
            this.tbFamily.Size = new System.Drawing.Size(100, 20);
            this.tbFamily.TabIndex = 5;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(141, 59);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 20);
            this.tbModel.TabIndex = 6;
            // 
            // tbSocket
            // 
            this.tbSocket.Location = new System.Drawing.Point(141, 87);
            this.tbSocket.Name = "tbSocket";
            this.tbSocket.Size = new System.Drawing.Size(100, 20);
            this.tbSocket.TabIndex = 7;
            // 
            // tbCores
            // 
            this.tbCores.Location = new System.Drawing.Point(141, 114);
            this.tbCores.Name = "tbCores";
            this.tbCores.Size = new System.Drawing.Size(100, 20);
            this.tbCores.TabIndex = 8;
            this.tbCores.TextChanged += new System.EventHandler(this.tbCores_TextChanged);
            // 
            // tbFreq
            // 
            this.tbFreq.Location = new System.Drawing.Point(141, 140);
            this.tbFreq.Name = "tbFreq";
            this.tbFreq.Size = new System.Drawing.Size(100, 20);
            this.tbFreq.TabIndex = 9;
            this.tbFreq.TextChanged += new System.EventHandler(this.tbFreq_TextChanged);
            // 
            // chbHasGraphics
            // 
            this.chbHasGraphics.AutoSize = true;
            this.chbHasGraphics.Location = new System.Drawing.Point(19, 24);
            this.chbHasGraphics.Name = "chbHasGraphics";
            this.chbHasGraphics.Size = new System.Drawing.Size(95, 17);
            this.chbHasGraphics.TabIndex = 6;
            this.chbHasGraphics.Text = "Карта наявна";
            this.chbHasGraphics.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(274, 17);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(274, 51);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chbHasMultiplier
            // 
            this.chbHasMultiplier.AutoSize = true;
            this.chbHasMultiplier.Location = new System.Drawing.Point(19, 47);
            this.chbHasMultiplier.Name = "chbHasMultiplier";
            this.chbHasMultiplier.Size = new System.Drawing.Size(171, 17);
            this.chbHasMultiplier.TabIndex = 7;
            this.chbHasMultiplier.Text = "Помножувач розблокований";
            this.chbHasMultiplier.UseVisualStyleBackColor = true;
            // 
            // fProcessor
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(365, 274);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fProcessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про новий процесор";
            this.Load += new System.EventHandler(this.fProcessor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFreq;
        private System.Windows.Forms.TextBox tbCores;
        private System.Windows.Forms.TextBox tbSocket;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbFamily;
        private System.Windows.Forms.CheckBox chbHasGraphics;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chbHasMultiplier;
    }
}