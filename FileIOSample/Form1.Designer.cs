namespace FileIOSample
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
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadSchedule = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lstSchedule = new System.Windows.Forms.ListBox();
            this.lblEnterCourse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(55, 71);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(218, 23);
            this.btnAddCourse.TabIndex = 0;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(312, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Schedule";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadSchedule
            // 
            this.btnLoadSchedule.Location = new System.Drawing.Point(312, 113);
            this.btnLoadSchedule.Name = "btnLoadSchedule";
            this.btnLoadSchedule.Size = new System.Drawing.Size(112, 23);
            this.btnLoadSchedule.TabIndex = 2;
            this.btnLoadSchedule.Text = "Load Schedule";
            this.btnLoadSchedule.UseVisualStyleBackColor = true;
            this.btnLoadSchedule.Click += new System.EventHandler(this.btnLoadSchedule_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(173, 32);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 20);
            this.txtClass.TabIndex = 3;
            // 
            // lstSchedule
            // 
            this.lstSchedule.FormattingEnabled = true;
            this.lstSchedule.Location = new System.Drawing.Point(55, 113);
            this.lstSchedule.Name = "lstSchedule";
            this.lstSchedule.Size = new System.Drawing.Size(218, 95);
            this.lstSchedule.TabIndex = 4;
            // 
            // lblEnterCourse
            // 
            this.lblEnterCourse.AutoSize = true;
            this.lblEnterCourse.Location = new System.Drawing.Point(52, 38);
            this.lblEnterCourse.Name = "lblEnterCourse";
            this.lblEnterCourse.Size = new System.Drawing.Size(71, 13);
            this.lblEnterCourse.TabIndex = 5;
            this.lblEnterCourse.Text = "Enter Course;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 278);
            this.Controls.Add(this.lblEnterCourse);
            this.Controls.Add(this.lstSchedule);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.btnLoadSchedule);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddCourse);
            this.Name = "Form1";
            this.Text = "Schedule Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadSchedule;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.ListBox lstSchedule;
        private System.Windows.Forms.Label lblEnterCourse;
    }
}

