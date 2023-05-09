namespace polyAndInheriatanceTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.inputMilk = new System.Windows.Forms.TextBox();
            this.inputVac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputMilk
            // 
            this.inputMilk.Location = new System.Drawing.Point(42, 49);
            this.inputMilk.Multiline = true;
            this.inputMilk.Name = "inputMilk";
            this.inputMilk.Size = new System.Drawing.Size(157, 242);
            this.inputMilk.TabIndex = 1;
            // 
            // inputVac
            // 
            this.inputVac.Location = new System.Drawing.Point(333, 49);
            this.inputVac.Multiline = true;
            this.inputVac.Name = "inputVac";
            this.inputVac.Size = new System.Drawing.Size(157, 242);
            this.inputVac.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 375);
            this.Controls.Add(this.inputVac);
            this.Controls.Add(this.inputMilk);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox inputMilk;
        private TextBox inputVac;
    }
}