namespace TESEGUI
{
    partial class TrackingForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CutsTextBox = new TextBox();
            ChippedTextBox = new TextBox();
            DugTextBox = new TextBox();
            DownedTextBox = new TextBox();
            OiTextBox = new TextBox();
            BackButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Cuts:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 9);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Chipped:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 9);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Dug:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(319, 9);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Downed:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 9);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 4;
            label5.Text = "Oi:";
            // 
            // CutsTextBox
            // 
            CutsTextBox.Location = new Point(52, 6);
            CutsTextBox.Name = "CutsTextBox";
            CutsTextBox.Size = new Size(50, 23);
            CutsTextBox.TabIndex = 5;
            // 
            // ChippedTextBox
            // 
            ChippedTextBox.Location = new Point(169, 6);
            ChippedTextBox.Name = "ChippedTextBox";
            ChippedTextBox.Size = new Size(50, 23);
            ChippedTextBox.TabIndex = 6;
            // 
            // DugTextBox
            // 
            DugTextBox.Location = new Point(263, 6);
            DugTextBox.Name = "DugTextBox";
            DugTextBox.Size = new Size(50, 23);
            DugTextBox.TabIndex = 7;
            // 
            // DownedTextBox
            // 
            DownedTextBox.Location = new Point(379, 6);
            DownedTextBox.Name = "DownedTextBox";
            DownedTextBox.Size = new Size(50, 23);
            DownedTextBox.TabIndex = 8;
            // 
            // OiTextBox
            // 
            OiTextBox.Location = new Point(463, 6);
            OiTextBox.Name = "OiTextBox";
            OiTextBox.Size = new Size(50, 23);
            OiTextBox.TabIndex = 9;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(12, 35);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 10;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(93, 35);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // TrackingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 66);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(OiTextBox);
            Controls.Add(DownedTextBox);
            Controls.Add(DugTextBox);
            Controls.Add(ChippedTextBox);
            Controls.Add(CutsTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TrackingForm";
            Text = "Edit Tracking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox CutsTextBox;
        private TextBox ChippedTextBox;
        private TextBox DugTextBox;
        private TextBox DownedTextBox;
        private TextBox OiTextBox;
        private Button BackButton;
        private Button SaveButton;
    }
}