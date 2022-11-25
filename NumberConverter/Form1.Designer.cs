
namespace NumberConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelGeneralClaim = new System.Windows.Forms.Label();
            this.textBoxGeneralClaim = new System.Windows.Forms.TextBox();
            this.textBoxGeneralResult = new System.Windows.Forms.TextBox();
            this.AddClaim = new System.Windows.Forms.TextBox();
            this.labelAddClaim = new System.Windows.Forms.Label();
            this.AddClaimResult = new System.Windows.Forms.TextBox();
            this.TotalClaim = new System.Windows.Forms.TextBox();
            this.labelTotalSumClaim = new System.Windows.Forms.Label();
            this.TotalClaimResultBox = new System.Windows.Forms.TextBox();
            this.buttonGeneralCopy = new System.Windows.Forms.Button();
            this.buttomAddCopy = new System.Windows.Forms.Button();
            this.buttonTotalCopy = new System.Windows.Forms.Button();
            this.labelCopyInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGeneralClaim
            // 
            this.labelGeneralClaim.AutoSize = true;
            this.labelGeneralClaim.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGeneralClaim.Location = new System.Drawing.Point(34, 39);
            this.labelGeneralClaim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGeneralClaim.Name = "labelGeneralClaim";
            this.labelGeneralClaim.Size = new System.Drawing.Size(251, 18);
            this.labelGeneralClaim.TabIndex = 0;
            this.labelGeneralClaim.Text = "Введите сумму основного долга:";
            // 
            // textBoxGeneralClaim
            // 
            this.textBoxGeneralClaim.Location = new System.Drawing.Point(34, 60);
            this.textBoxGeneralClaim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxGeneralClaim.Name = "textBoxGeneralClaim";
            this.textBoxGeneralClaim.Size = new System.Drawing.Size(282, 27);
            this.textBoxGeneralClaim.TabIndex = 1;
            this.textBoxGeneralClaim.TextChanged += new System.EventHandler(this.textBoxGeneralClaim_TextChanged);
            // 
            // textBoxGeneralResult
            // 
            this.textBoxGeneralResult.Enabled = false;
            this.textBoxGeneralResult.Location = new System.Drawing.Point(436, 30);
            this.textBoxGeneralResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxGeneralResult.Multiline = true;
            this.textBoxGeneralResult.Name = "textBoxGeneralResult";
            this.textBoxGeneralResult.Size = new System.Drawing.Size(544, 67);
            this.textBoxGeneralResult.TabIndex = 2;
            this.textBoxGeneralResult.TextChanged += new System.EventHandler(this.textBoxGeneralResult_TextChanged);
            // 
            // AddClaim
            // 
            this.AddClaim.Location = new System.Drawing.Point(34, 186);
            this.AddClaim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddClaim.Name = "AddClaim";
            this.AddClaim.Size = new System.Drawing.Size(282, 27);
            this.AddClaim.TabIndex = 3;
            this.AddClaim.TextChanged += new System.EventHandler(this.AddClaim_TextChanged);
            // 
            // labelAddClaim
            // 
            this.labelAddClaim.AutoSize = true;
            this.labelAddClaim.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddClaim.Location = new System.Drawing.Point(34, 165);
            this.labelAddClaim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddClaim.Name = "labelAddClaim";
            this.labelAddClaim.Size = new System.Drawing.Size(201, 18);
            this.labelAddClaim.TabIndex = 4;
            this.labelAddClaim.Text = "Введите сумму неустойки:";
            // 
            // AddClaimResult
            // 
            this.AddClaimResult.Enabled = false;
            this.AddClaimResult.Location = new System.Drawing.Point(436, 147);
            this.AddClaimResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddClaimResult.Multiline = true;
            this.AddClaimResult.Name = "AddClaimResult";
            this.AddClaimResult.Size = new System.Drawing.Size(544, 67);
            this.AddClaimResult.TabIndex = 5;
            this.AddClaimResult.TextChanged += new System.EventHandler(this.AddClaimResult_TextChanged);
            // 
            // TotalClaim
            // 
            this.TotalClaim.Enabled = false;
            this.TotalClaim.Location = new System.Drawing.Point(34, 312);
            this.TotalClaim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TotalClaim.Name = "TotalClaim";
            this.TotalClaim.Size = new System.Drawing.Size(282, 27);
            this.TotalClaim.TabIndex = 6;
            this.TotalClaim.TextChanged += new System.EventHandler(this.TotalClaim_TextChanged);
            // 
            // labelTotalSumClaim
            // 
            this.labelTotalSumClaim.AutoSize = true;
            this.labelTotalSumClaim.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalSumClaim.Location = new System.Drawing.Point(34, 286);
            this.labelTotalSumClaim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalSumClaim.Name = "labelTotalSumClaim";
            this.labelTotalSumClaim.Size = new System.Drawing.Size(90, 18);
            this.labelTotalSumClaim.TabIndex = 7;
            this.labelTotalSumClaim.Text = "Цена  иска:";
            // 
            // TotalClaimResultBox
            // 
            this.TotalClaimResultBox.Enabled = false;
            this.TotalClaimResultBox.Location = new System.Drawing.Point(436, 282);
            this.TotalClaimResultBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TotalClaimResultBox.Multiline = true;
            this.TotalClaimResultBox.Name = "TotalClaimResultBox";
            this.TotalClaimResultBox.Size = new System.Drawing.Size(544, 67);
            this.TotalClaimResultBox.TabIndex = 8;
            this.TotalClaimResultBox.TextChanged += new System.EventHandler(this.TotalClaimResultBox_TextChanged);
            // 
            // buttonGeneralCopy
            // 
            this.buttonGeneralCopy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGeneralCopy.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGeneralCopy.Location = new System.Drawing.Point(326, 60);
            this.buttonGeneralCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonGeneralCopy.Name = "buttonGeneralCopy";
            this.buttonGeneralCopy.Size = new System.Drawing.Size(106, 28);
            this.buttonGeneralCopy.TabIndex = 9;
            this.buttonGeneralCopy.Tag = "Скопирована сумма долга";
            this.buttonGeneralCopy.Text = "Копировать";
            this.buttonGeneralCopy.UseVisualStyleBackColor = false;
            this.buttonGeneralCopy.Click += new System.EventHandler(this.buttonGeneralCopy_Click);
            // 
            // buttomAddCopy
            // 
            this.buttomAddCopy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttomAddCopy.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttomAddCopy.Location = new System.Drawing.Point(326, 186);
            this.buttomAddCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttomAddCopy.Name = "buttomAddCopy";
            this.buttomAddCopy.Size = new System.Drawing.Size(106, 28);
            this.buttomAddCopy.TabIndex = 10;
            this.buttomAddCopy.Tag = "Скопирована сумма неустойки";
            this.buttomAddCopy.Text = "Копировать";
            this.buttomAddCopy.UseVisualStyleBackColor = false;
            this.buttomAddCopy.Click += new System.EventHandler(this.buttomAddCopy_Click);
            // 
            // buttonTotalCopy
            // 
            this.buttonTotalCopy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTotalCopy.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTotalCopy.Location = new System.Drawing.Point(323, 310);
            this.buttonTotalCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTotalCopy.Name = "buttonTotalCopy";
            this.buttonTotalCopy.Size = new System.Drawing.Size(106, 28);
            this.buttonTotalCopy.TabIndex = 11;
            this.buttonTotalCopy.Tag = "Скопирована цена иска";
            this.buttonTotalCopy.Text = "Копировать";
            this.buttonTotalCopy.UseVisualStyleBackColor = false;
            this.buttonTotalCopy.Click += new System.EventHandler(this.buttonTotalCopy_Click);
            // 
            // labelCopyInfo
            // 
            this.labelCopyInfo.AutoSize = true;
            this.labelCopyInfo.Enabled = false;
            this.labelCopyInfo.Location = new System.Drawing.Point(347, 370);
            this.labelCopyInfo.Name = "labelCopyInfo";
            this.labelCopyInfo.Size = new System.Drawing.Size(0, 19);
            this.labelCopyInfo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(997, 415);
            this.Controls.Add(this.labelCopyInfo);
            this.Controls.Add(this.buttonTotalCopy);
            this.Controls.Add(this.buttomAddCopy);
            this.Controls.Add(this.buttonGeneralCopy);
            this.Controls.Add(this.TotalClaimResultBox);
            this.Controls.Add(this.labelTotalSumClaim);
            this.Controls.Add(this.TotalClaim);
            this.Controls.Add(this.AddClaimResult);
            this.Controls.Add(this.labelAddClaim);
            this.Controls.Add(this.AddClaim);
            this.Controls.Add(this.textBoxGeneralResult);
            this.Controls.Add(this.textBoxGeneralClaim);
            this.Controls.Add(this.labelGeneralClaim);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертор исковых требований";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGeneralClaim;
        private System.Windows.Forms.TextBox textBoxGeneralClaim;
        private System.Windows.Forms.TextBox textBoxGeneralResult;
        private System.Windows.Forms.TextBox AddClaim;
        private System.Windows.Forms.Label labelAddClaim;
        private System.Windows.Forms.TextBox AddClaimResult;
        private System.Windows.Forms.TextBox TotalClaim;
        private System.Windows.Forms.Label labelTotalSumClaim;
        private System.Windows.Forms.TextBox TotalClaimResultBox;
        private System.Windows.Forms.Button buttonGeneralCopy;
        private System.Windows.Forms.Button buttomAddCopy;
        private System.Windows.Forms.Button buttonTotalCopy;
        private System.Windows.Forms.Label labelCopyInfo;
    }
}

