namespace Semaphore_hw_WinForm
{
    partial class Form1
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
            this.WorkingThreads = new System.Windows.Forms.ListBox();
            this.WaitingThreads = new System.Windows.Forms.ListBox();
            this.CreatedThreads = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkingThreads
            // 
            this.WorkingThreads.FormattingEnabled = true;
            this.WorkingThreads.Location = new System.Drawing.Point(27, 47);
            this.WorkingThreads.Name = "WorkingThreads";
            this.WorkingThreads.Size = new System.Drawing.Size(198, 173);
            this.WorkingThreads.TabIndex = 0;

            // 
            // WaitingThreads
            // 
            this.WaitingThreads.BackColor = System.Drawing.SystemColors.Window;
            this.WaitingThreads.FormattingEnabled = true;
            this.WaitingThreads.Location = new System.Drawing.Point(266, 47);
            this.WaitingThreads.Name = "WaitingThreads";
            this.WaitingThreads.Size = new System.Drawing.Size(198, 173);
            this.WaitingThreads.TabIndex = 1;
            this.WaitingThreads.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
          //  this.WaitingThreads.DoubleClick += new System.EventHandler(this.WaitingThreads_DoubleClick);
            // 
            // CreatedThreads
            // 
            this.CreatedThreads.FormattingEnabled = true;
            this.CreatedThreads.Location = new System.Drawing.Point(507, 47);
            this.CreatedThreads.Name = "CreatedThreads";
            this.CreatedThreads.Size = new System.Drawing.Size(198, 173);
            this.CreatedThreads.TabIndex = 2;
            this.CreatedThreads.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            this.CreatedThreads.DoubleClick += new System.EventHandler(this.CreatedThreads_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(565, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(27, 253);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(134, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Places in Semaphore";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(740, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.CreatedThreads);
            this.Controls.Add(this.WaitingThreads);
            this.Controls.Add(this.WorkingThreads);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WorkingThreads;
        private System.Windows.Forms.ListBox WaitingThreads;
        private System.Windows.Forms.ListBox CreatedThreads;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Diagnostics.EventLog eventLog1;
    }
}

