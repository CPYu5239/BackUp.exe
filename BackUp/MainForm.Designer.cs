
namespace BackUp
{
    partial class MainForm
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
            this.tB_From = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_From = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tB_To = new System.Windows.Forms.TextBox();
            this.bt_To = new System.Windows.Forms.Button();
            this.bt_BackUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_LastTime = new System.Windows.Forms.Label();
            this.cB_folder = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tB_From
            // 
            this.tB_From.Location = new System.Drawing.Point(6, 22);
            this.tB_From.Name = "tB_From";
            this.tB_From.ReadOnly = true;
            this.tB_From.Size = new System.Drawing.Size(267, 23);
            this.tB_From.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_From);
            this.groupBox1.Controls.Add(this.tB_From);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 63);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // bt_From
            // 
            this.bt_From.Location = new System.Drawing.Point(279, 21);
            this.bt_From.Name = "bt_From";
            this.bt_From.Size = new System.Drawing.Size(75, 23);
            this.bt_From.TabIndex = 6;
            this.bt_From.Text = "Select";
            this.bt_From.UseVisualStyleBackColor = true;
            this.bt_From.Click += new System.EventHandler(this.bt_From_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tB_To);
            this.groupBox2.Controls.Add(this.bt_To);
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 63);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // tB_To
            // 
            this.tB_To.Location = new System.Drawing.Point(6, 22);
            this.tB_To.Name = "tB_To";
            this.tB_To.ReadOnly = true;
            this.tB_To.Size = new System.Drawing.Size(267, 23);
            this.tB_To.TabIndex = 5;
            // 
            // bt_To
            // 
            this.bt_To.Location = new System.Drawing.Point(279, 21);
            this.bt_To.Name = "bt_To";
            this.bt_To.Size = new System.Drawing.Size(75, 23);
            this.bt_To.TabIndex = 0;
            this.bt_To.Text = "Select";
            this.bt_To.UseVisualStyleBackColor = true;
            this.bt_To.Click += new System.EventHandler(this.bt_To_Click);
            // 
            // bt_BackUp
            // 
            this.bt_BackUp.Location = new System.Drawing.Point(67, 225);
            this.bt_BackUp.Name = "bt_BackUp";
            this.bt_BackUp.Size = new System.Drawing.Size(251, 23);
            this.bt_BackUp.TabIndex = 10;
            this.bt_BackUp.Text = "BackUp File";
            this.bt_BackUp.UseVisualStyleBackColor = true;
            this.bt_BackUp.Click += new System.EventHandler(this.bt_BackUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lastest BackUp Time :";
            // 
            // label_LastTime
            // 
            this.label_LastTime.AutoSize = true;
            this.label_LastTime.Location = new System.Drawing.Point(146, 181);
            this.label_LastTime.Name = "label_LastTime";
            this.label_LastTime.Size = new System.Drawing.Size(150, 15);
            this.label_LastTime.TabIndex = 13;
            this.label_LastTime.Text = "Please select folder or file";
            // 
            // cB_folder
            // 
            this.cB_folder.AutoSize = true;
            this.cB_folder.Location = new System.Drawing.Point(258, 150);
            this.cB_folder.Name = "cB_folder";
            this.cB_folder.Size = new System.Drawing.Size(108, 19);
            this.cB_folder.TabIndex = 15;
            this.cB_folder.Text = "BackUp Folder";
            this.cB_folder.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 260);
            this.Controls.Add(this.cB_folder);
            this.Controls.Add(this.label_LastTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_BackUp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "BackUp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tB_From;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tB_To;
        private System.Windows.Forms.Button bt_To;
        private System.Windows.Forms.Button bt_BackUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_LastTime;
        private System.Windows.Forms.Button bt_From;
        private System.Windows.Forms.CheckBox cB_folder;
    }
}

