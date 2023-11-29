namespace Queue_4
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.buttonInFront = new System.Windows.Forms.Button();
            this.buttonInRear = new System.Windows.Forms.Button();
            this.buttonDelRear = new System.Windows.Forms.Button();
            this.buttonDelFront = new System.Windows.Forms.Button();
            this.buttonGetRear = new System.Windows.Forms.Button();
            this.buttonGetFront = new System.Windows.Forms.Button();
            this.buttonFull = new System.Windows.Forms.Button();
            this.buttonEmpty = new System.Windows.Forms.Button();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.numericUpDownIn = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIn)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(99, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "MyCircularDeque";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
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
            this.numericUpDownSize.TabIndex = 1;
            this.numericUpDownSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonInFront
            // 
            this.buttonInFront.Location = new System.Drawing.Point(12, 41);
            this.buttonInFront.Name = "buttonInFront";
            this.buttonInFront.Size = new System.Drawing.Size(99, 23);
            this.buttonInFront.TabIndex = 2;
            this.buttonInFront.Text = "insertFront";
            this.buttonInFront.UseVisualStyleBackColor = true;
            this.buttonInFront.Click += new System.EventHandler(this.buttonInFront_Click);
            // 
            // buttonInRear
            // 
            this.buttonInRear.Location = new System.Drawing.Point(12, 70);
            this.buttonInRear.Name = "buttonInRear";
            this.buttonInRear.Size = new System.Drawing.Size(99, 23);
            this.buttonInRear.TabIndex = 3;
            this.buttonInRear.Text = "insertLast";
            this.buttonInRear.UseVisualStyleBackColor = true;
            this.buttonInRear.Click += new System.EventHandler(this.buttonInRear_Click);
            // 
            // buttonDelRear
            // 
            this.buttonDelRear.Location = new System.Drawing.Point(12, 128);
            this.buttonDelRear.Name = "buttonDelRear";
            this.buttonDelRear.Size = new System.Drawing.Size(99, 23);
            this.buttonDelRear.TabIndex = 6;
            this.buttonDelRear.Text = "deleteLast";
            this.buttonDelRear.UseVisualStyleBackColor = true;
            this.buttonDelRear.Click += new System.EventHandler(this.buttonDelRear_Click);
            // 
            // buttonDelFront
            // 
            this.buttonDelFront.Location = new System.Drawing.Point(12, 99);
            this.buttonDelFront.Name = "buttonDelFront";
            this.buttonDelFront.Size = new System.Drawing.Size(99, 23);
            this.buttonDelFront.TabIndex = 5;
            this.buttonDelFront.Text = "deleteFront";
            this.buttonDelFront.UseVisualStyleBackColor = true;
            this.buttonDelFront.Click += new System.EventHandler(this.buttonDelFront_Click);
            // 
            // buttonGetRear
            // 
            this.buttonGetRear.Location = new System.Drawing.Point(12, 186);
            this.buttonGetRear.Name = "buttonGetRear";
            this.buttonGetRear.Size = new System.Drawing.Size(99, 23);
            this.buttonGetRear.TabIndex = 8;
            this.buttonGetRear.Text = "getRear";
            this.buttonGetRear.UseVisualStyleBackColor = true;
            this.buttonGetRear.Click += new System.EventHandler(this.buttonGetRear_Click);
            // 
            // buttonGetFront
            // 
            this.buttonGetFront.Location = new System.Drawing.Point(12, 157);
            this.buttonGetFront.Name = "buttonGetFront";
            this.buttonGetFront.Size = new System.Drawing.Size(99, 23);
            this.buttonGetFront.TabIndex = 7;
            this.buttonGetFront.Text = "getFront";
            this.buttonGetFront.UseVisualStyleBackColor = true;
            this.buttonGetFront.Click += new System.EventHandler(this.buttonGetFront_Click);
            // 
            // buttonFull
            // 
            this.buttonFull.Location = new System.Drawing.Point(12, 244);
            this.buttonFull.Name = "buttonFull";
            this.buttonFull.Size = new System.Drawing.Size(99, 23);
            this.buttonFull.TabIndex = 10;
            this.buttonFull.Text = "isFull";
            this.buttonFull.UseVisualStyleBackColor = true;
            this.buttonFull.Click += new System.EventHandler(this.buttonFull_Click);
            // 
            // buttonEmpty
            // 
            this.buttonEmpty.Location = new System.Drawing.Point(12, 215);
            this.buttonEmpty.Name = "buttonEmpty";
            this.buttonEmpty.Size = new System.Drawing.Size(99, 23);
            this.buttonEmpty.TabIndex = 9;
            this.buttonEmpty.Text = "isEmpty";
            this.buttonEmpty.UseVisualStyleBackColor = true;
            this.buttonEmpty.Click += new System.EventHandler(this.buttonEmpty_Click);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(174, 12);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ReadOnly = true;
            this.textBoxOut.Size = new System.Drawing.Size(51, 255);
            this.textBoxOut.TabIndex = 11;
            // 
            // numericUpDownIn
            // 
            this.numericUpDownIn.Location = new System.Drawing.Point(117, 57);
            this.numericUpDownIn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownIn.Name = "numericUpDownIn";
            this.numericUpDownIn.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownIn.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 280);
            this.Controls.Add(this.numericUpDownIn);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.buttonFull);
            this.Controls.Add(this.buttonEmpty);
            this.Controls.Add(this.buttonGetRear);
            this.Controls.Add(this.buttonGetFront);
            this.Controls.Add(this.buttonDelRear);
            this.Controls.Add(this.buttonDelFront);
            this.Controls.Add(this.buttonInRear);
            this.Controls.Add(this.buttonInFront);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.buttonCreate);
            this.Name = "Form1";
            this.Text = "Queue_4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Button buttonInFront;
        private System.Windows.Forms.Button buttonInRear;
        private System.Windows.Forms.Button buttonDelRear;
        private System.Windows.Forms.Button buttonDelFront;
        private System.Windows.Forms.Button buttonGetRear;
        private System.Windows.Forms.Button buttonGetFront;
        private System.Windows.Forms.Button buttonFull;
        private System.Windows.Forms.Button buttonEmpty;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.NumericUpDown numericUpDownIn;
    }
}

