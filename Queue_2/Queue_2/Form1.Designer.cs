namespace Queue_2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPush = new System.Windows.Forms.TextBox();
            this.buttonPush = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonTop = new System.Windows.Forms.Button();
            this.buttonPop = new System.Windows.Forms.Button();
            this.buttonEmpty = new System.Windows.Forms.Button();
            this.buttonCreateStack = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPush);
            this.groupBox2.Location = new System.Drawing.Point(93, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(69, 52);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // textBoxPush
            // 
            this.textBoxPush.Location = new System.Drawing.Point(6, 19);
            this.textBoxPush.Name = "textBoxPush";
            this.textBoxPush.Size = new System.Drawing.Size(56, 20);
            this.textBoxPush.TabIndex = 2;
            // 
            // buttonPush
            // 
            this.buttonPush.Location = new System.Drawing.Point(12, 41);
            this.buttonPush.Name = "buttonPush";
            this.buttonPush.Size = new System.Drawing.Size(75, 23);
            this.buttonPush.TabIndex = 9;
            this.buttonPush.Text = "Push";
            this.buttonPush.UseVisualStyleBackColor = true;
            this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxOut);
            this.groupBox1.Location = new System.Drawing.Point(93, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(73, 52);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(6, 19);
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(56, 20);
            this.textBoxOut.TabIndex = 6;
            // 
            // buttonTop
            // 
            this.buttonTop.Location = new System.Drawing.Point(12, 99);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(75, 23);
            this.buttonTop.TabIndex = 11;
            this.buttonTop.Text = "Top";
            this.buttonTop.UseVisualStyleBackColor = true;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // buttonPop
            // 
            this.buttonPop.Location = new System.Drawing.Point(12, 70);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(75, 23);
            this.buttonPop.TabIndex = 10;
            this.buttonPop.Text = "Pop";
            this.buttonPop.UseVisualStyleBackColor = true;
            this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
            // 
            // buttonEmpty
            // 
            this.buttonEmpty.Location = new System.Drawing.Point(12, 128);
            this.buttonEmpty.Name = "buttonEmpty";
            this.buttonEmpty.Size = new System.Drawing.Size(75, 23);
            this.buttonEmpty.TabIndex = 13;
            this.buttonEmpty.Text = "Empty";
            this.buttonEmpty.UseVisualStyleBackColor = true;
            this.buttonEmpty.Click += new System.EventHandler(this.buttonEmpty_Click);
            // 
            // buttonCreateStack
            // 
            this.buttonCreateStack.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateStack.Name = "buttonCreateStack";
            this.buttonCreateStack.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateStack.TabIndex = 8;
            this.buttonCreateStack.Text = "MyStack";
            this.buttonCreateStack.UseVisualStyleBackColor = true;
            this.buttonCreateStack.Click += new System.EventHandler(this.buttonCreateStack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 162);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonPush);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTop);
            this.Controls.Add(this.buttonPop);
            this.Controls.Add(this.buttonEmpty);
            this.Controls.Add(this.buttonCreateStack);
            this.Name = "Form1";
            this.Text = "Queue_2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPush;
        private System.Windows.Forms.Button buttonPush;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.Button buttonPop;
        private System.Windows.Forms.Button buttonEmpty;
        private System.Windows.Forms.Button buttonCreateStack;
    }
}

