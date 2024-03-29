namespace PasswordGame
{
    partial class PasswordGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGame));
            textBoxPassword = new TextBox();
            labelPasswordTitle = new Label();
            listBoxRules = new ListBox();
            progressBarPassword = new ProgressBar();
            labelCount = new Label();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.BackColor = Color.Ivory;
            textBoxPassword.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.ImeMode = ImeMode.NoControl;
            textBoxPassword.Location = new Point(105, 110);
            textBoxPassword.Margin = new Padding(8);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(580, 39);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.TabStop = false;
            textBoxPassword.TextChanged += TextBoxPassword_TextChanged;
            // 
            // labelPasswordTitle
            // 
            labelPasswordTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelPasswordTitle.AutoSize = true;
            labelPasswordTitle.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPasswordTitle.Location = new Point(212, 47);
            labelPasswordTitle.Name = "labelPasswordTitle";
            labelPasswordTitle.Size = new Size(362, 60);
            labelPasswordTitle.TabIndex = 1;
            labelPasswordTitle.Text = "Password Game";
            // 
            // listBoxRules
            // 
            listBoxRules.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxRules.BackColor = SystemColors.Info;
            listBoxRules.BorderStyle = BorderStyle.None;
            listBoxRules.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxRules.FormattingEnabled = true;
            listBoxRules.ItemHeight = 20;
            listBoxRules.Location = new Point(126, 175);
            listBoxRules.Name = "listBoxRules";
            listBoxRules.SelectionMode = SelectionMode.None;
            listBoxRules.Size = new Size(544, 20);
            listBoxRules.TabIndex = 2;
            listBoxRules.TabStop = false;
            // 
            // progressBarPassword
            // 
            progressBarPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarPassword.Location = new Point(197, 387);
            progressBarPassword.Name = "progressBarPassword";
            progressBarPassword.Size = new Size(398, 33);
            progressBarPassword.TabIndex = 3;
            // 
            // labelCount
            // 
            labelCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelCount.AutoSize = true;
            labelCount.BackColor = Color.White;
            labelCount.BorderStyle = BorderStyle.Fixed3D;
            labelCount.Font = new Font("Ink Free", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCount.Location = new Point(696, 110);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(33, 36);
            labelCount.TabIndex = 4;
            labelCount.Text = "0";
            // 
            // PasswordGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCount);
            Controls.Add(progressBarPassword);
            Controls.Add(listBoxRules);
            Controls.Add(labelPasswordTitle);
            Controls.Add(textBoxPassword);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PasswordGame";
            Text = "PasswordGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private Label labelPasswordTitle;
        private ListBox listBoxRules;
        private ProgressBar progressBarPassword;
        private Label labelCount;
    }
}
