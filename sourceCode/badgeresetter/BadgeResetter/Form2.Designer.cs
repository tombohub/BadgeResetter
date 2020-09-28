namespace BadgeResetter
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.datePickerNoFap = new System.Windows.Forms.DateTimePicker();
            this.datePickerPornFree = new System.Windows.Forms.DateTimePicker();
            this.checkboxNoFap = new System.Windows.Forms.CheckBox();
            this.checkboxStopSmoking = new System.Windows.Forms.CheckBox();
            this.resetBadge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datePickerNofap
            // 
            this.datePickerNoFap.Location = new System.Drawing.Point(31, 80);
            this.datePickerNoFap.Name = "datePickerNofap";
            this.datePickerNoFap.Size = new System.Drawing.Size(142, 20);
            this.datePickerNoFap.TabIndex = 0;
            // 
            // datePickerPornfree
            // 
            this.datePickerPornFree.Location = new System.Drawing.Point(31, 173);
            this.datePickerPornFree.Name = "datePickerPornfree";
            this.datePickerPornFree.Size = new System.Drawing.Size(142, 20);
            this.datePickerPornFree.TabIndex = 1;
            // 
            // checkboxNofap
            // 
            this.checkboxNoFap.AutoSize = true;
            this.checkboxNoFap.Location = new System.Drawing.Point(31, 57);
            this.checkboxNoFap.Name = "checkboxNofap";
            this.checkboxNoFap.Size = new System.Drawing.Size(125, 17);
            this.checkboxNoFap.TabIndex = 2;
            this.checkboxNoFap.Text = "reset r/NoFap badge";
            this.checkboxNoFap.UseVisualStyleBackColor = true;
            // 
            // checkboxPornfree
            // 
            this.checkboxStopSmoking.AutoSize = true;
            this.checkboxStopSmoking.Location = new System.Drawing.Point(31, 150);
            this.checkboxStopSmoking.Name = "checkboxPornfree";
            this.checkboxStopSmoking.Size = new System.Drawing.Size(132, 17);
            this.checkboxStopSmoking.TabIndex = 3;
            this.checkboxStopSmoking.Text = "reset r/pornfree badge";
            this.checkboxStopSmoking.UseVisualStyleBackColor = true;
            // 
            // resetBadge
            // 
            this.resetBadge.Location = new System.Drawing.Point(56, 239);
            this.resetBadge.Name = "resetBadge";
            this.resetBadge.Size = new System.Drawing.Size(75, 23);
            this.resetBadge.TabIndex = 4;
            this.resetBadge.Text = "Reset :(";
            this.resetBadge.UseVisualStyleBackColor = true;
            this.resetBadge.Click += new System.EventHandler(this.resetBadge_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.resetBadge;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(214, 298);
            this.Controls.Add(this.resetBadge);
            this.Controls.Add(this.checkboxStopSmoking);
            this.Controls.Add(this.checkboxNoFap);
            this.Controls.Add(this.datePickerPornFree);
            this.Controls.Add(this.datePickerNoFap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BadgeResetter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePickerNoFap;
        private System.Windows.Forms.DateTimePicker datePickerPornFree;
        private System.Windows.Forms.CheckBox checkboxNoFap;
        private System.Windows.Forms.CheckBox checkboxPornFree;
        private System.Windows.Forms.Button resetBadge;
    }
}