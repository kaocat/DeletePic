namespace WindowsFormsApplication2
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
            this.tDelDir = new System.Windows.Forms.TextBox();
            this.tDelDirXml = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnOpenXnl = new System.Windows.Forms.Button();
            this.oputRes = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tDelDir
            // 
            this.tDelDir.Location = new System.Drawing.Point(248, 53);
            this.tDelDir.Name = "tDelDir";
            this.tDelDir.Size = new System.Drawing.Size(466, 20);
            this.tDelDir.TabIndex = 0;
            // 
            // tDelDirXml
            // 
            this.tDelDirXml.Location = new System.Drawing.Point(248, 110);
            this.tDelDirXml.Name = "tDelDirXml";
            this.tDelDirXml.Size = new System.Drawing.Size(466, 20);
            this.tDelDirXml.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "刪除目錄";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "要刪除的清單";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FilterIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.AccessibleName = "";
            this.btnOpen.Location = new System.Drawing.Point(736, 49);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "開啟檔案";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnOpenXnl
            // 
            this.btnOpenXnl.Location = new System.Drawing.Point(736, 110);
            this.btnOpenXnl.Name = "btnOpenXnl";
            this.btnOpenXnl.Size = new System.Drawing.Size(75, 23);
            this.btnOpenXnl.TabIndex = 6;
            this.btnOpenXnl.Text = "開啟檔案";
            this.btnOpenXnl.UseVisualStyleBackColor = true;
            this.btnOpenXnl.Click += new System.EventHandler(this.btnOpenXnl_Click);
            // 
            // oputRes
            // 
            this.oputRes.Location = new System.Drawing.Point(117, 162);
            this.oputRes.Multiline = true;
            this.oputRes.Name = "oputRes";
            this.oputRes.ReadOnly = true;
            this.oputRes.Size = new System.Drawing.Size(694, 167);
            this.oputRes.TabIndex = 7;
            this.oputRes.TextChanged += new System.EventHandler(this.oputRes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "只支援刪除(jpg/jpeg/png)，使用前請先備份原檔，刪錯不負責";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(752, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "created by kao";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oputRes);
            this.Controls.Add(this.btnOpenXnl);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tDelDirXml);
            this.Controls.Add(this.tDelDir);
            this.Name = "Form1";
            this.Text = "刪圖刪圖";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tDelDir;
        private System.Windows.Forms.TextBox tDelDirXml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnOpenXnl;
        private System.Windows.Forms.TextBox oputRes;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

