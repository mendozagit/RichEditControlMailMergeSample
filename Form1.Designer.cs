namespace RichEditControlMailMergeSample
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
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.LoadDocumentButton = new System.Windows.Forms.Button();
            this.ShowAllFieldCodesButton = new System.Windows.Forms.Button();
            this.ShowMergeResultDocumentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richEditControl1.Location = new System.Drawing.Point(0, 0);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(909, 609);
            this.richEditControl1.TabIndex = 0;
            // 
            // LoadDocumentButton
            // 
            this.LoadDocumentButton.Location = new System.Drawing.Point(12, 615);
            this.LoadDocumentButton.Name = "LoadDocumentButton";
            this.LoadDocumentButton.Size = new System.Drawing.Size(146, 48);
            this.LoadDocumentButton.TabIndex = 1;
            this.LoadDocumentButton.Text = "LoadDocument";
            this.LoadDocumentButton.UseVisualStyleBackColor = true;
            this.LoadDocumentButton.Click += new System.EventHandler(this.LoadDocumentButton_Click);
            // 
            // ShowAllFieldCodesButton
            // 
            this.ShowAllFieldCodesButton.Location = new System.Drawing.Point(164, 615);
            this.ShowAllFieldCodesButton.Name = "ShowAllFieldCodesButton";
            this.ShowAllFieldCodesButton.Size = new System.Drawing.Size(146, 48);
            this.ShowAllFieldCodesButton.TabIndex = 2;
            this.ShowAllFieldCodesButton.Text = "Show All Field Codes";
            this.ShowAllFieldCodesButton.UseVisualStyleBackColor = true;
            this.ShowAllFieldCodesButton.Click += new System.EventHandler(this.ShowAllFieldCodesButton_Click);
            // 
            // ShowMergeResultDocumentButton
            // 
            this.ShowMergeResultDocumentButton.Location = new System.Drawing.Point(316, 615);
            this.ShowMergeResultDocumentButton.Name = "ShowMergeResultDocumentButton";
            this.ShowMergeResultDocumentButton.Size = new System.Drawing.Size(146, 48);
            this.ShowMergeResultDocumentButton.TabIndex = 3;
            this.ShowMergeResultDocumentButton.Text = "Show Merge Result Document";
            this.ShowMergeResultDocumentButton.UseVisualStyleBackColor = true;
            this.ShowMergeResultDocumentButton.Click += new System.EventHandler(this.ShowMergeResultDocumentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 675);
            this.Controls.Add(this.ShowMergeResultDocumentButton);
            this.Controls.Add(this.ShowAllFieldCodesButton);
            this.Controls.Add(this.LoadDocumentButton);
            this.Controls.Add(this.richEditControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private System.Windows.Forms.Button LoadDocumentButton;
        private System.Windows.Forms.Button ShowAllFieldCodesButton;
        private System.Windows.Forms.Button ShowMergeResultDocumentButton;
    }
}

