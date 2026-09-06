namespace TESEGUI
{
    partial class CharacterForm
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
            CharacterPictureBox = new PictureBox();
            RightButton = new Button();
            LeftButton = new Button();
            BackButton = new Button();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CharacterPictureBox).BeginInit();
            SuspendLayout();
            // 
            // CharacterPictureBox
            // 
            CharacterPictureBox.Location = new Point(68, 12);
            CharacterPictureBox.Name = "CharacterPictureBox";
            CharacterPictureBox.Size = new Size(160, 160);
            CharacterPictureBox.TabIndex = 0;
            CharacterPictureBox.TabStop = false;
            // 
            // RightButton
            // 
            RightButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RightButton.Location = new Point(234, 122);
            RightButton.Margin = new Padding(0);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(50, 50);
            RightButton.TabIndex = 1;
            RightButton.Text = ">";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // LeftButton
            // 
            LeftButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LeftButton.Location = new Point(12, 122);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(50, 50);
            LeftButton.TabIndex = 2;
            LeftButton.Text = "<";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(12, 178);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 3;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(93, 178);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CharacterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 209);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(LeftButton);
            Controls.Add(RightButton);
            Controls.Add(CharacterPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CharacterForm";
            Text = "Edit Character";
            ((System.ComponentModel.ISupportInitialize)CharacterPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CharacterPictureBox;
        private Button RightButton;
        private Button LeftButton;
        private Button BackButton;
        private Button SaveButton;
    }
}