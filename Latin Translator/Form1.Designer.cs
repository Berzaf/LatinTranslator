namespace Latin_Translator
{
    partial class LatinTranslator
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
            this.btnLatinSinister = new System.Windows.Forms.Button();
            this.btmLatinMedium = new System.Windows.Forms.Button();
            this.btnLatinDexter = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLatinSinister
            // 
            this.btnLatinSinister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLatinSinister.Location = new System.Drawing.Point(12, 393);
            this.btnLatinSinister.Name = "btnLatinSinister";
            this.btnLatinSinister.Size = new System.Drawing.Size(75, 23);
            this.btnLatinSinister.TabIndex = 0;
            this.btnLatinSinister.Text = "Sinister";
            this.btnLatinSinister.UseVisualStyleBackColor = true;
            this.btnLatinSinister.Click += new System.EventHandler(this.btnLatinSinister_Click);
            // 
            // btmLatinMedium
            // 
            this.btmLatinMedium.Location = new System.Drawing.Point(291, 393);
            this.btmLatinMedium.Name = "btmLatinMedium";
            this.btmLatinMedium.Size = new System.Drawing.Size(75, 23);
            this.btmLatinMedium.TabIndex = 1;
            this.btmLatinMedium.Text = "Medium";
            this.btmLatinMedium.UseVisualStyleBackColor = true;
            this.btmLatinMedium.Click += new System.EventHandler(this.btmLatinMedium_Click);
            // 
            // btnLatinDexter
            // 
            this.btnLatinDexter.Location = new System.Drawing.Point(670, 393);
            this.btnLatinDexter.Name = "btnLatinDexter";
            this.btnLatinDexter.Size = new System.Drawing.Size(75, 23);
            this.btnLatinDexter.TabIndex = 2;
            this.btnLatinDexter.Text = "Dexter";
            this.btnLatinDexter.UseVisualStyleBackColor = true;
            this.btnLatinDexter.Click += new System.EventHandler(this.btnLatinDexter_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(238, 96);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(313, 92);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutput.Click += new System.EventHandler(this.label1_Click);
            // 
            // LatinTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnLatinDexter);
            this.Controls.Add(this.btmLatinMedium);
            this.Controls.Add(this.btnLatinSinister);
            this.Name = "LatinTranslator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Latin Translator";
            this.Load += new System.EventHandler(this.LatinTranslator_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btmLatinMedium;
        private System.Windows.Forms.Button btnLatinDexter;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnLatinSinister;
    }
}

