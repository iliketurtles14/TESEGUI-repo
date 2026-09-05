namespace TESEGUI
{
    partial class FloorItemsForm
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
            PositionXTextBox = new TextBox();
            label2 = new Label();
            PositionYTextBox = new TextBox();
            label3 = new Label();
            LayerTextBox = new TextBox();
            label4 = new Label();
            ItemTextBox = new TextBox();
            label5 = new Label();
            DurabilityTextBox = new TextBox();
            ItemListBox = new ListBox();
            label21 = new Label();
            BackButton = new Button();
            SaveButton = new Button();
            PlusButton = new Button();
            MinusButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Position X:";
            // 
            // PositionXTextBox
            // 
            PositionXTextBox.Location = new Point(81, 6);
            PositionXTextBox.Name = "PositionXTextBox";
            PositionXTextBox.Size = new Size(50, 23);
            PositionXTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 9);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Position Y:";
            // 
            // PositionYTextBox
            // 
            PositionYTextBox.Location = new Point(206, 6);
            PositionYTextBox.Name = "PositionYTextBox";
            PositionYTextBox.Size = new Size(50, 23);
            PositionYTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 9);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Layer*:";
            // 
            // LayerTextBox
            // 
            LayerTextBox.Location = new Point(311, 6);
            LayerTextBox.Name = "LayerTextBox";
            LayerTextBox.Size = new Size(50, 23);
            LayerTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 36);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 6;
            label4.Text = "Item:";
            // 
            // ItemTextBox
            // 
            ItemTextBox.Location = new Point(52, 33);
            ItemTextBox.Name = "ItemTextBox";
            ItemTextBox.Size = new Size(50, 23);
            ItemTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 36);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 8;
            label5.Text = "Durability:";
            // 
            // DurabilityTextBox
            // 
            DurabilityTextBox.Location = new Point(175, 33);
            DurabilityTextBox.Name = "DurabilityTextBox";
            DurabilityTextBox.Size = new Size(50, 23);
            DurabilityTextBox.TabIndex = 9;
            // 
            // ItemListBox
            // 
            ItemListBox.FormattingEnabled = true;
            ItemListBox.Location = new Point(365, 12);
            ItemListBox.Name = "ItemListBox";
            ItemListBox.Size = new Size(120, 154);
            ItemListBox.TabIndex = 10;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(323, 191);
            label21.Name = "label21";
            label21.Size = new Size(162, 15);
            label21.TabIndex = 67;
            label21.Text = "*0: Main; 1: Bonus; 2: Custom";
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(12, 180);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 68;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(93, 180);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 69;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // PlusButton
            // 
            PlusButton.Location = new Point(466, 166);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(20, 20);
            PlusButton.TabIndex = 70;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = true;
            // 
            // MinusButton
            // 
            MinusButton.Location = new Point(364, 166);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(20, 20);
            MinusButton.TabIndex = 71;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = true;
            // 
            // FloorItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 215);
            Controls.Add(MinusButton);
            Controls.Add(PlusButton);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(label21);
            Controls.Add(ItemListBox);
            Controls.Add(DurabilityTextBox);
            Controls.Add(label5);
            Controls.Add(ItemTextBox);
            Controls.Add(label4);
            Controls.Add(LayerTextBox);
            Controls.Add(label3);
            Controls.Add(PositionYTextBox);
            Controls.Add(label2);
            Controls.Add(PositionXTextBox);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FloorItemsForm";
            Text = "Edit Floor Items";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox PositionXTextBox;
        private Label label2;
        private TextBox PositionYTextBox;
        private Label label3;
        private TextBox LayerTextBox;
        private Label label4;
        private TextBox ItemTextBox;
        private Label label5;
        private TextBox DurabilityTextBox;
        private ListBox ItemListBox;
        private Label label21;
        private Button BackButton;
        private Button SaveButton;
        private Button PlusButton;
        private Button MinusButton;
    }
}