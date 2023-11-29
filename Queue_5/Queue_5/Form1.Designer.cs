namespace Queue_5
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
            this.numericUpDownIn = new System.Windows.Forms.NumericUpDown();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonFull = new System.Windows.Forms.Button();
            this.buttonEmpty = new System.Windows.Forms.Button();
            this.buttonRear = new System.Windows.Forms.Button();
            this.buttonFront = new System.Windows.Forms.Button();
            this.buttonDequeue = new System.Windows.Forms.Button();
            this.buttonEnqueue = new System.Windows.Forms.Button();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.buttonCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownIn
            // 
            this.numericUpDownIn.Location = new System.Drawing.Point(117, 44);
            this.numericUpDownIn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownIn.Name = "numericUpDownIn";
            this.numericUpDownIn.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownIn.TabIndex = 24;
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(174, 12);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(51, 197);
            this.textBoxOut.TabIndex = 23;
            // 
            // buttonFull
            // 
            this.buttonFull.Location = new System.Drawing.Point(12, 186);
            this.buttonFull.Name = "buttonFull";
            this.buttonFull.Size = new System.Drawing.Size(99, 23);
            this.buttonFull.TabIndex = 22;
            this.buttonFull.Text = "isFull";
            this.buttonFull.UseVisualStyleBackColor = true;
            this.buttonFull.Click += new System.EventHandler(this.buttonFull_Click);
            // 
            // buttonEmpty
            // 
            this.buttonEmpty.Location = new System.Drawing.Point(12, 157);
            this.buttonEmpty.Name = "buttonEmpty";
            this.buttonEmpty.Size = new System.Drawing.Size(99, 23);
            this.buttonEmpty.TabIndex = 21;
            this.buttonEmpty.Text = "isEmpty";
            this.buttonEmpty.UseVisualStyleBackColor = true;
            this.buttonEmpty.Click += new System.EventHandler(this.buttonEmpty_Click);
            // 
            // buttonRear
            // 
            this.buttonRear.Location = new System.Drawing.Point(12, 128);
            this.buttonRear.Name = "buttonRear";
            this.buttonRear.Size = new System.Drawing.Size(99, 23);
            this.buttonRear.TabIndex = 18;
            this.buttonRear.Text = "Rear";
            this.buttonRear.UseVisualStyleBackColor = true;
            this.buttonRear.Click += new System.EventHandler(this.buttonRear_Click);
            // 
            // buttonFront
            // 
            this.buttonFront.Location = new System.Drawing.Point(12, 99);
            this.buttonFront.Name = "buttonFront";
            this.buttonFront.Size = new System.Drawing.Size(99, 23);
            this.buttonFront.TabIndex = 17;
            this.buttonFront.Text = "Front";
            this.buttonFront.UseVisualStyleBackColor = true;
            this.buttonFront.Click += new System.EventHandler(this.buttonFront_Click);
            // 
            // buttonDequeue
            // 
            this.buttonDequeue.Location = new System.Drawing.Point(12, 70);
            this.buttonDequeue.Name = "buttonDequeue";
            this.buttonDequeue.Size = new System.Drawing.Size(99, 23);
            this.buttonDequeue.TabIndex = 16;
            this.buttonDequeue.Text = "deQueue";
            this.buttonDequeue.UseVisualStyleBackColor = true;
            this.buttonDequeue.Click += new System.EventHandler(this.buttonDequeue_Click);
            // 
            // buttonEnqueue
            // 
            this.buttonEnqueue.Location = new System.Drawing.Point(12, 41);
            this.buttonEnqueue.Name = "buttonEnqueue";
            this.buttonEnqueue.Size = new System.Drawing.Size(99, 23);
            this.buttonEnqueue.TabIndex = 15;
            this.buttonEnqueue.Text = "enQueue";
            this.buttonEnqueue.UseVisualStyleBackColor = true;
            this.buttonEnqueue.Click += new System.EventHandler(this.buttonEnqueue_Click);
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(117, 15);
            this.numericUpDownSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownSize.TabIndex = 14;
            this.numericUpDownSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(99, 23);
            this.buttonCreate.TabIndex = 13;
            this.buttonCreate.Text = "MyCircularDeque";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 217);
            this.Controls.Add(this.numericUpDownIn);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.buttonFull);
            this.Controls.Add(this.buttonEmpty);
            this.Controls.Add(this.buttonRear);
            this.Controls.Add(this.buttonFront);
            this.Controls.Add(this.buttonDequeue);
            this.Controls.Add(this.buttonEnqueue);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Form1";
            this.Text = "Queue_5";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonFull;
        private System.Windows.Forms.Button buttonEmpty;
        private System.Windows.Forms.Button buttonRear;
        private System.Windows.Forms.Button buttonFront;
        private System.Windows.Forms.Button buttonDequeue;
        private System.Windows.Forms.Button buttonEnqueue;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Button buttonCreate;
    }
}

