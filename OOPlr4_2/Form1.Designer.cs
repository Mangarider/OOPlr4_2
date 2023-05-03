namespace OOPlr4_2
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
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.trackA = new System.Windows.Forms.TrackBar();
            this.trackB = new System.Windows.Forms.TrackBar();
            this.trackC = new System.Windows.Forms.TrackBar();
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.textC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackC)).BeginInit();
            this.SuspendLayout();
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(120, 175);
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(139, 22);
            this.numA.TabIndex = 0;
            this.numA.ValueChanged += new System.EventHandler(this.numA_ValueChanged);
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(379, 175);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(139, 22);
            this.numB.TabIndex = 1;
            this.numB.ValueChanged += new System.EventHandler(this.num2_ValueChanged);
            // 
            // numC
            // 
            this.numC.Location = new System.Drawing.Point(637, 175);
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(139, 22);
            this.numC.TabIndex = 2;
            this.numC.ValueChanged += new System.EventHandler(this.numC_ValueChanged);
            // 
            // trackA
            // 
            this.trackA.Location = new System.Drawing.Point(120, 231);
            this.trackA.Maximum = 100;
            this.trackA.Name = "trackA";
            this.trackA.Size = new System.Drawing.Size(139, 56);
            this.trackA.TabIndex = 3;
            this.trackA.Scroll += new System.EventHandler(this.track1_Scroll);
            // 
            // trackB
            // 
            this.trackB.Location = new System.Drawing.Point(379, 231);
            this.trackB.Maximum = 100;
            this.trackB.Name = "trackB";
            this.trackB.Size = new System.Drawing.Size(139, 56);
            this.trackB.TabIndex = 4;
            this.trackB.Scroll += new System.EventHandler(this.track2_Scroll);
            // 
            // trackC
            // 
            this.trackC.Location = new System.Drawing.Point(637, 231);
            this.trackC.Maximum = 100;
            this.trackC.Name = "trackC";
            this.trackC.Size = new System.Drawing.Size(139, 56);
            this.trackC.TabIndex = 5;
            this.trackC.Scroll += new System.EventHandler(this.track3_Scroll);
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(120, 96);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(139, 22);
            this.textA.TabIndex = 6;
            this.textA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textA_KeyUp);
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(379, 96);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(139, 22);
            this.textB.TabIndex = 7;
            this.textB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textB_KeyUp);
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(637, 96);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(139, 22);
            this.textC.TabIndex = 8;
            this.textC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textC_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 516);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.trackC);
            this.Controls.Add(this.trackB);
            this.Controls.Add(this.trackA);
            this.Controls.Add(this.numC);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.TrackBar trackA;
        private System.Windows.Forms.TrackBar trackB;
        private System.Windows.Forms.TrackBar trackC;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textC;
    }
}

