namespace DateTimeToJPG
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.select_Folder_Btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exe_btn = new System.Windows.Forms.Button();
            this.response_Lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // select_Folder_Btn
            // 
            this.select_Folder_Btn.Location = new System.Drawing.Point(195, 12);
            this.select_Folder_Btn.Name = "select_Folder_Btn";
            this.select_Folder_Btn.Size = new System.Drawing.Size(154, 53);
            this.select_Folder_Btn.TabIndex = 0;
            this.select_Folder_Btn.Text = "Select Folder";
            this.select_Folder_Btn.UseVisualStyleBackColor = true;
            this.select_Folder_Btn.Click += new System.EventHandler(this.select_Folder_Btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(502, 276);
            this.dataGridView1.TabIndex = 1;
            // 
            // exe_btn
            // 
            this.exe_btn.Location = new System.Drawing.Point(195, 353);
            this.exe_btn.Name = "exe_btn";
            this.exe_btn.Size = new System.Drawing.Size(154, 53);
            this.exe_btn.TabIndex = 2;
            this.exe_btn.Text = "Execute";
            this.exe_btn.UseVisualStyleBackColor = true;
            this.exe_btn.Click += new System.EventHandler(this.execute_Btn_Click);
            // 
            // response_Lbl
            // 
            this.response_Lbl.Location = new System.Drawing.Point(87, 470);
            this.response_Lbl.Name = "response_Lbl";
            this.response_Lbl.Size = new System.Drawing.Size(397, 28);
            this.response_Lbl.TabIndex = 3;
            this.response_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(144, 425);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(257, 31);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 507);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.response_Lbl);
            this.Controls.Add(this.exe_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.select_Folder_Btn);
            this.Name = "Form1";
            this.Text = "DateTimeToJPG";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button select_Folder_Btn;
        private System.Windows.Forms.Button exe_btn;
        private System.Windows.Forms.Label response_Lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}