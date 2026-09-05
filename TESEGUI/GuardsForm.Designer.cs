namespace TESEGUI
{
    partial class GuardsForm
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
            label7 = new Label();
            SaveButton = new Button();
            BackButton = new Button();
            button1 = new Button();
            CharacterButton = new Button();
            label6 = new Label();
            checkBox1 = new CheckBox();
            OpinionTextBox = new TextBox();
            label5 = new Label();
            IntellectTextBox = new TextBox();
            label4 = new Label();
            SpeedTextBox = new TextBox();
            label3 = new Label();
            StrengthTextBox = new TextBox();
            label2 = new Label();
            NameTextBox = new TextBox();
            label1 = new Label();
            GuardsListBox = new ListBox();
            label8 = new Label();
            Patrol1TextBox = new TextBox();
            Patrol2TextBox = new TextBox();
            Patrol3TextBox = new TextBox();
            Patrol4TextBox = new TextBox();
            Patrol5TextBox = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(111, 214);
            label7.Name = "label7";
            label7.Size = new Size(411, 15);
            label7.TabIndex = 37;
            label7.Text = "**Saving affects all edited guards and not just the one being edited currently.";
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(93, 171);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 36;
            SaveButton.Text = "Save**";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(12, 171);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 35;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 142);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 34;
            button1.Text = "Inventory";
            button1.UseVisualStyleBackColor = true;
            // 
            // CharacterButton
            // 
            CharacterButton.Location = new Point(93, 142);
            CharacterButton.Name = "CharacterButton";
            CharacterButton.Size = new Size(75, 23);
            CharacterButton.TabIndex = 32;
            CharacterButton.Text = "Character";
            CharacterButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(166, 197);
            label6.Name = "label6";
            label6.Size = new Size(356, 15);
            label6.TabIndex = 31;
            label6.Text = "*This has no affect to the guard but is still held within the save file.";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(13, 117);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.Yes;
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 30;
            checkBox1.Text = ":*Flag 2001";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // OpinionTextBox
            // 
            OpinionTextBox.Location = new Point(185, 61);
            OpinionTextBox.Name = "OpinionTextBox";
            OpinionTextBox.Size = new Size(50, 23);
            OpinionTextBox.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 64);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 28;
            label5.Text = "Opinion:";
            // 
            // IntellectTextBox
            // 
            IntellectTextBox.Location = new Point(70, 61);
            IntellectTextBox.Name = "IntellectTextBox";
            IntellectTextBox.Size = new Size(50, 23);
            IntellectTextBox.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 64);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 26;
            label4.Text = "Intellect:";
            // 
            // SpeedTextBox
            // 
            SpeedTextBox.Location = new Point(178, 34);
            SpeedTextBox.Name = "SpeedTextBox";
            SpeedTextBox.Size = new Size(50, 23);
            SpeedTextBox.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 37);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 24;
            label3.Text = "Speed:";
            // 
            // StrengthTextBox
            // 
            StrengthTextBox.Location = new Point(73, 34);
            StrengthTextBox.Name = "StrengthTextBox";
            StrengthTextBox.Size = new Size(50, 23);
            StrengthTextBox.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 22;
            label2.Text = "Strength:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(60, 7);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(336, 23);
            NameTextBox.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 20;
            label1.Text = "Name:";
            // 
            // GuardsListBox
            // 
            GuardsListBox.FormattingEnabled = true;
            GuardsListBox.Location = new Point(402, 7);
            GuardsListBox.Name = "GuardsListBox";
            GuardsListBox.Size = new Size(120, 184);
            GuardsListBox.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 91);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 38;
            label8.Text = "Patrol*:";
            // 
            // Patrol1TextBox
            // 
            Patrol1TextBox.Location = new Point(65, 88);
            Patrol1TextBox.Name = "Patrol1TextBox";
            Patrol1TextBox.Size = new Size(50, 23);
            Patrol1TextBox.TabIndex = 39;
            // 
            // Patrol2TextBox
            // 
            Patrol2TextBox.Location = new Point(121, 88);
            Patrol2TextBox.Name = "Patrol2TextBox";
            Patrol2TextBox.Size = new Size(50, 23);
            Patrol2TextBox.TabIndex = 40;
            // 
            // Patrol3TextBox
            // 
            Patrol3TextBox.Location = new Point(177, 88);
            Patrol3TextBox.Name = "Patrol3TextBox";
            Patrol3TextBox.Size = new Size(50, 23);
            Patrol3TextBox.TabIndex = 41;
            // 
            // Patrol4TextBox
            // 
            Patrol4TextBox.Location = new Point(233, 88);
            Patrol4TextBox.Name = "Patrol4TextBox";
            Patrol4TextBox.Size = new Size(50, 23);
            Patrol4TextBox.TabIndex = 42;
            // 
            // Patrol5TextBox
            // 
            Patrol5TextBox.Location = new Point(289, 88);
            Patrol5TextBox.Name = "Patrol5TextBox";
            Patrol5TextBox.Size = new Size(50, 23);
            Patrol5TextBox.TabIndex = 43;
            // 
            // GuardsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 236);
            Controls.Add(Patrol5TextBox);
            Controls.Add(Patrol4TextBox);
            Controls.Add(Patrol3TextBox);
            Controls.Add(Patrol2TextBox);
            Controls.Add(Patrol1TextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(button1);
            Controls.Add(CharacterButton);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(OpinionTextBox);
            Controls.Add(label5);
            Controls.Add(IntellectTextBox);
            Controls.Add(label4);
            Controls.Add(SpeedTextBox);
            Controls.Add(label3);
            Controls.Add(StrengthTextBox);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Controls.Add(GuardsListBox);
            MaximizeBox = false;
            Name = "GuardsForm";
            Text = "Edit Guards";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button SaveButton;
        private Button BackButton;
        private Button button1;
        private Button CharacterButton;
        private Label label6;
        private CheckBox checkBox1;
        private TextBox OpinionTextBox;
        private Label label5;
        private TextBox IntellectTextBox;
        private Label label4;
        private TextBox SpeedTextBox;
        private Label label3;
        private TextBox StrengthTextBox;
        private Label label2;
        private TextBox NameTextBox;
        private Label label1;
        private ListBox GuardsListBox;
        private Label label8;
        private TextBox Patrol1TextBox;
        private TextBox Patrol2TextBox;
        private TextBox Patrol3TextBox;
        private TextBox Patrol4TextBox;
        private TextBox Patrol5TextBox;
    }
}