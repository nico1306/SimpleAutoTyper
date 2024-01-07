namespace SimpleAutoTyper
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
            tb_inputtext = new TextBox();
            btn_start = new Button();
            lbl_tb_inputtext = new Label();
            SuspendLayout();
            // 
            // tb_inputtext
            // 
            tb_inputtext.Location = new Point(12, 54);
            tb_inputtext.Name = "tb_inputtext";
            tb_inputtext.PlaceholderText = "Example Text";
            tb_inputtext.Size = new Size(340, 23);
            tb_inputtext.TabIndex = 0;
            tb_inputtext.Tag = "";
            // 
            // btn_start
            // 
            btn_start.Location = new Point(12, 92);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(86, 23);
            btn_start.TabIndex = 1;
            btn_start.Text = "START";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // lbl_tb_inputtext
            // 
            lbl_tb_inputtext.AutoSize = true;
            lbl_tb_inputtext.Location = new Point(12, 36);
            lbl_tb_inputtext.Name = "lbl_tb_inputtext";
            lbl_tb_inputtext.Size = new Size(93, 15);
            lbl_tb_inputtext.TabIndex = 2;
            lbl_tb_inputtext.Text = "Test to by typed:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 127);
            Controls.Add(lbl_tb_inputtext);
            Controls.Add(btn_start);
            Controls.Add(tb_inputtext);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "AutoTyper by Nico136";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_inputtext;
        private Button btn_start;
        private Label lbl_tb_inputtext;
    }
}