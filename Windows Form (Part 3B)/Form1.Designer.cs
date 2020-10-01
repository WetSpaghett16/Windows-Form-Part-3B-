namespace Windows_Form__Part_3B_
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
            this.btnSubmit1 = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtINPUT = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit1
            // 
            this.btnSubmit1.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit1.Location = new System.Drawing.Point(5, 55);
            this.btnSubmit1.Name = "btnSubmit1";
            this.btnSubmit1.Size = new System.Drawing.Size(119, 25);
            this.btnSubmit1.TabIndex = 0;
            this.btnSubmit1.Text = "Click Me";
            this.btnSubmit1.UseVisualStyleBackColor = true;
            this.btnSubmit1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(12, 22);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(84, 16);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "ENTER NAME:";
            // 
            // txtINPUT
            // 
            this.txtINPUT.Location = new System.Drawing.Point(102, 20);
            this.txtINPUT.Name = "txtINPUT";
            this.txtINPUT.Size = new System.Drawing.Size(100, 20);
            this.txtINPUT.TabIndex = 2;
            this.txtINPUT.Click += new System.EventHandler(this.txtInput_TextChanged);
            this.txtINPUT.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Myriad Web Pro Condensed", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(140, 64);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(73, 22);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Message";
            this.lblMessage.Visible = false;
            this.lblMessage.Click += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(263, 104);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtINPUT);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnSubmit1);
            this.Name = "MainForm";
            this.Text = "Getting Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit1;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtINPUT;
        private System.Windows.Forms.Label lblMessage;
    }
}

