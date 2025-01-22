namespace RenameFilesApp
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
            btnExecute = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFolderPath = new TextBox();
            txtOldFileName = new TextBox();
            txtNewFileName = new TextBox();
            SuspendLayout();
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(216, 184);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(75, 23);
            btnExecute.TabIndex = 0;
            btnExecute.Text = "実行";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 1;
            label1.Text = "対象フォルダパスを入力";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 2;
            label2.Text = "改名前のファイル名を入力";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 3;
            label3.Text = "改名後のファイル名を入力";
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(14, 30);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.Size = new Size(483, 23);
            txtFolderPath.TabIndex = 5;
            // 
            // txtOldFileName
            // 
            txtOldFileName.Location = new Point(14, 84);
            txtOldFileName.Name = "txtOldFileName";
            txtOldFileName.Size = new Size(483, 23);
            txtOldFileName.TabIndex = 6;
            // 
            // txtNewFileName
            // 
            txtNewFileName.Location = new Point(12, 143);
            txtNewFileName.Name = "txtNewFileName";
            txtNewFileName.Size = new Size(485, 23);
            txtNewFileName.TabIndex = 7;
            txtNewFileName.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 219);
            Controls.Add(txtNewFileName);
            Controls.Add(txtOldFileName);
            Controls.Add(txtFolderPath);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExecute);
            Name = "Form1";
            Text = "RenameFilesApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExecute;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFolderPath;
        private TextBox txtOldFileName;
        private TextBox txtNewFileName;
    }
}
