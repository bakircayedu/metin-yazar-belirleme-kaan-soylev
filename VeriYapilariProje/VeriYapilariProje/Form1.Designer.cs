
namespace VeriYapilariProje
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
            this.filePath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStackOku = new System.Windows.Forms.Button();
            this.rtxtbxResult = new System.Windows.Forms.RichTextBox();
            this.rtxtbxResultwords = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHashBTN = new System.Windows.Forms.Button();
            this.txtHashInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filePath
            // 
            this.filePath.BackColor = System.Drawing.Color.Yellow;
            this.filePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filePath.Enabled = false;
            this.filePath.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.filePath.Location = new System.Drawing.Point(818, 62);
            this.filePath.Margin = new System.Windows.Forms.Padding(2);
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(217, 20);
            this.filePath.TabIndex = 0;
            this.filePath.Text = "Please select a file";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Yellow;
            this.btnAdd.Location = new System.Drawing.Point(721, 55);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Upload";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStackOku
            // 
            this.btnStackOku.BackColor = System.Drawing.Color.Yellow;
            this.btnStackOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStackOku.Location = new System.Drawing.Point(113, 57);
            this.btnStackOku.Margin = new System.Windows.Forms.Padding(2);
            this.btnStackOku.Name = "btnStackOku";
            this.btnStackOku.Size = new System.Drawing.Size(164, 33);
            this.btnStackOku.TabIndex = 2;
            this.btnStackOku.Text = "Read to Stack";
            this.btnStackOku.UseVisualStyleBackColor = false;
            this.btnStackOku.Click += new System.EventHandler(this.btnStackOku_Click);
            // 
            // rtxtbxResult
            // 
            this.rtxtbxResult.BackColor = System.Drawing.Color.Cyan;
            this.rtxtbxResult.Location = new System.Drawing.Point(113, 101);
            this.rtxtbxResult.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtbxResult.Name = "rtxtbxResult";
            this.rtxtbxResult.Size = new System.Drawing.Size(346, 187);
            this.rtxtbxResult.TabIndex = 3;
            this.rtxtbxResult.Text = "";
            // 
            // rtxtbxResultwords
            // 
            this.rtxtbxResultwords.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.rtxtbxResultwords.Location = new System.Drawing.Point(608, 125);
            this.rtxtbxResultwords.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtbxResultwords.Name = "rtxtbxResultwords";
            this.rtxtbxResultwords.Size = new System.Drawing.Size(481, 221);
            this.rtxtbxResultwords.TabIndex = 4;
            this.rtxtbxResultwords.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(281, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Read to Heap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHashBTN
            // 
            this.txtHashBTN.BackColor = System.Drawing.Color.Yellow;
            this.txtHashBTN.Location = new System.Drawing.Point(103, 316);
            this.txtHashBTN.Name = "txtHashBTN";
            this.txtHashBTN.Size = new System.Drawing.Size(96, 39);
            this.txtHashBTN.TabIndex = 6;
            this.txtHashBTN.Text = "Hashle";
            this.txtHashBTN.UseVisualStyleBackColor = false;
            this.txtHashBTN.Click += new System.EventHandler(this.txtHashBTN_Click);
            // 
            // txtHashInput
            // 
            this.txtHashInput.BackColor = System.Drawing.Color.Yellow;
            this.txtHashInput.Location = new System.Drawing.Point(264, 326);
            this.txtHashInput.Name = "txtHashInput";
            this.txtHashInput.Size = new System.Drawing.Size(177, 20);
            this.txtHashInput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(463, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "RAGIP KAAN SÖYLEV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(521, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ClientSize = new System.Drawing.Size(1220, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHashInput);
            this.Controls.Add(this.txtHashBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtxtbxResultwords);
            this.Controls.Add(this.rtxtbxResult);
            this.Controls.Add(this.btnStackOku);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.filePath);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStackOku;
        private System.Windows.Forms.RichTextBox rtxtbxResult;
        private System.Windows.Forms.RichTextBox rtxtbxResultwords;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtHashBTN;
        private System.Windows.Forms.TextBox txtHashInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

