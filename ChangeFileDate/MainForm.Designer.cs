namespace ChangeFileDate
{
    partial class MainForm
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
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.tboxSelectedFile = new System.Windows.Forms.TextBox();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnNow = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.cboxCreationTime = new System.Windows.Forms.CheckBox();
            this.cboxLastWriteTime = new System.Windows.Forms.CheckBox();
            this.cboxLastAccessTime = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(458, 14);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(98, 21);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Choose File...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // tboxSelectedFile
            // 
            this.tboxSelectedFile.Location = new System.Drawing.Point(89, 14);
            this.tboxSelectedFile.Name = "tboxSelectedFile";
            this.tboxSelectedFile.Size = new System.Drawing.Size(363, 20);
            this.tboxSelectedFile.TabIndex = 1;
            this.tboxSelectedFile.TextChanged += new System.EventHandler(this.tboxSelectedFile_TextChanged);
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.Location = new System.Drawing.Point(12, 17);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(71, 13);
            this.lblSelectedFile.TabIndex = 2;
            this.lblSelectedFile.Text = "Selected File:";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MM / dd / yyyy @ hh: mm: ss tt";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(89, 40);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(295, 40);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(75, 20);
            this.btnNow.TabIndex = 5;
            this.btnNow.Text = "Now";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // btnSet
            // 
            this.btnSet.Enabled = false;
            this.btnSet.Location = new System.Drawing.Point(89, 132);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(467, 23);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // cboxCreationTime
            // 
            this.cboxCreationTime.AutoSize = true;
            this.cboxCreationTime.Checked = true;
            this.cboxCreationTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxCreationTime.Location = new System.Drawing.Point(89, 66);
            this.cboxCreationTime.Name = "cboxCreationTime";
            this.cboxCreationTime.Size = new System.Drawing.Size(110, 17);
            this.cboxCreationTime.TabIndex = 8;
            this.cboxCreationTime.Text = "Set Creation Time";
            this.cboxCreationTime.UseVisualStyleBackColor = true;
            // 
            // cboxLastWriteTime
            // 
            this.cboxLastWriteTime.AutoSize = true;
            this.cboxLastWriteTime.Checked = true;
            this.cboxLastWriteTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxLastWriteTime.Location = new System.Drawing.Point(89, 89);
            this.cboxLastWriteTime.Name = "cboxLastWriteTime";
            this.cboxLastWriteTime.Size = new System.Drawing.Size(119, 17);
            this.cboxLastWriteTime.TabIndex = 9;
            this.cboxLastWriteTime.Text = "Set Last Write Time";
            this.cboxLastWriteTime.UseVisualStyleBackColor = true;
            // 
            // cboxLastAccessTime
            // 
            this.cboxLastAccessTime.AutoSize = true;
            this.cboxLastAccessTime.Checked = true;
            this.cboxLastAccessTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxLastAccessTime.Location = new System.Drawing.Point(89, 112);
            this.cboxLastAccessTime.Name = "cboxLastAccessTime";
            this.cboxLastAccessTime.Size = new System.Drawing.Size(129, 17);
            this.cboxLastAccessTime.TabIndex = 10;
            this.cboxLastAccessTime.Text = "Set Last Access Time";
            this.cboxLastAccessTime.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 165);
            this.Controls.Add(this.cboxLastAccessTime);
            this.Controls.Add(this.cboxLastWriteTime);
            this.Controls.Add(this.cboxCreationTime);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.tboxSelectedFile);
            this.Controls.Add(this.btnChooseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Change File Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox tboxSelectedFile;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.CheckBox cboxCreationTime;
        private System.Windows.Forms.CheckBox cboxLastWriteTime;
        private System.Windows.Forms.CheckBox cboxLastAccessTime;
    }
}

