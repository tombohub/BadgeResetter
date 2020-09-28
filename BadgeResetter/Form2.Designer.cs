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
            this.datePickerStopSmoking = new System.Windows.Forms.DateTimePicker();
            this.datePickerStopDrinking = new System.Windows.Forms.DateTimePicker();
            this.checkboxStopSmoking = new System.Windows.Forms.CheckBox();
            this.checkboxStopDrinking = new System.Windows.Forms.CheckBox();
            this.resetBadge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datePickerStopSmoking
            // 
            this.datePickerStopSmoking.Location = new System.Drawing.Point(41, 98);
            this.datePickerStopSmoking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datePickerStopSmoking.Name = "datePickerStopSmoking";
            this.datePickerStopSmoking.Size = new System.Drawing.Size(188, 22);
            this.datePickerStopSmoking.TabIndex = 0;
            // 
            // datePickerStopDrinking
            // 
            this.datePickerStopDrinking.Location = new System.Drawing.Point(41, 213);
            this.datePickerStopDrinking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datePickerStopDrinking.Name = "datePickerStopDrinking";
            this.datePickerStopDrinking.Size = new System.Drawing.Size(188, 22);
            this.datePickerStopDrinking.TabIndex = 1;
            // 
            // checkboxStopSmoking
            // 
            this.checkboxStopSmoking.AutoSize = true;
            this.checkboxStopSmoking.Location = new System.Drawing.Point(41, 70);
            this.checkboxStopSmoking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkboxStopSmoking.Name = "checkboxStopSmoking";
            this.checkboxStopSmoking.Size = new System.Drawing.Size(198, 21);
            this.checkboxStopSmoking.TabIndex = 2;
            this.checkboxStopSmoking.Text = "reset r/stopsmoking badge";
            this.checkboxStopSmoking.UseVisualStyleBackColor = true;
            // 
            // checkboxStopDrinking
            // 
            this.checkboxStopDrinking.AutoSize = true;
            this.checkboxStopDrinking.Location = new System.Drawing.Point(41, 185);
            this.checkboxStopDrinking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkboxStopDrinking.Name = "checkboxStopDrinking";
            this.checkboxStopDrinking.Size = new System.Drawing.Size(196, 21);
            this.checkboxStopDrinking.TabIndex = 3;
            this.checkboxStopDrinking.Text = "reset r/stopdrinking badge";
            this.checkboxStopDrinking.UseVisualStyleBackColor = true;
            // 
            // resetBadge
            // 
            this.resetBadge.Location = new System.Drawing.Point(75, 294);
            this.resetBadge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetBadge.Name = "resetBadge";
            this.resetBadge.Size = new System.Drawing.Size(100, 28);
            this.resetBadge.TabIndex = 4;
            this.resetBadge.Text = "Reset :(";
            this.resetBadge.UseVisualStyleBackColor = true;
            this.resetBadge.Click += new System.EventHandler(this.resetBadge_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.resetBadge;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(285, 367);
            this.Controls.Add(this.resetBadge);
            this.Controls.Add(this.checkboxStopDrinking);
            this.Controls.Add(this.checkboxStopSmoking);
            this.Controls.Add(this.datePickerStopDrinking);
            this.Controls.Add(this.datePickerStopSmoking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BadgeResetter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePickerStopSmoking;
        private System.Windows.Forms.DateTimePicker datePickerStopDrinking;
        private System.Windows.Forms.CheckBox checkboxStopSmoking;
        private System.Windows.Forms.CheckBox checkboxStopDrinking;
        private System.Windows.Forms.Button resetBadge;
    }
}