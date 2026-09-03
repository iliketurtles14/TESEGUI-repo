namespace TESEGUI
{
    partial class MainForm
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
            PlayerButton = new Button();
            PrisonButton = new Button();
            InmatesButton = new Button();
            GuardsButton = new Button();
            DesksButton = new Button();
            ContainersButton = new Button();
            FloorItemsButton = new Button();
            JobsButton = new Button();
            TrackingButton = new Button();
            label1 = new Label();
            ExportButton = new Button();
            SuspendLayout();
            // 
            // PlayerButton
            // 
            PlayerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PlayerButton.Location = new Point(11, 43);
            PlayerButton.Name = "PlayerButton";
            PlayerButton.Size = new Size(150, 50);
            PlayerButton.TabIndex = 0;
            PlayerButton.Text = "Player";
            PlayerButton.UseVisualStyleBackColor = true;
            // 
            // PrisonButton
            // 
            PrisonButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PrisonButton.Location = new Point(11, 99);
            PrisonButton.Name = "PrisonButton";
            PrisonButton.Size = new Size(150, 50);
            PrisonButton.TabIndex = 1;
            PrisonButton.Text = "Prison";
            PrisonButton.UseVisualStyleBackColor = true;
            // 
            // InmatesButton
            // 
            InmatesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            InmatesButton.Location = new Point(167, 43);
            InmatesButton.Name = "InmatesButton";
            InmatesButton.Size = new Size(150, 50);
            InmatesButton.TabIndex = 2;
            InmatesButton.Text = "Inmates";
            InmatesButton.UseVisualStyleBackColor = true;
            // 
            // GuardsButton
            // 
            GuardsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GuardsButton.Location = new Point(323, 43);
            GuardsButton.Name = "GuardsButton";
            GuardsButton.Size = new Size(150, 50);
            GuardsButton.TabIndex = 3;
            GuardsButton.Text = "Guards";
            GuardsButton.UseVisualStyleBackColor = true;
            // 
            // DesksButton
            // 
            DesksButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DesksButton.Location = new Point(11, 155);
            DesksButton.Name = "DesksButton";
            DesksButton.Size = new Size(150, 50);
            DesksButton.TabIndex = 4;
            DesksButton.Text = "Desks";
            DesksButton.UseVisualStyleBackColor = true;
            // 
            // ContainersButton
            // 
            ContainersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ContainersButton.Location = new Point(167, 155);
            ContainersButton.Name = "ContainersButton";
            ContainersButton.Size = new Size(150, 50);
            ContainersButton.TabIndex = 5;
            ContainersButton.Text = "Containers";
            ContainersButton.UseVisualStyleBackColor = true;
            // 
            // FloorItemsButton
            // 
            FloorItemsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FloorItemsButton.Location = new Point(323, 155);
            FloorItemsButton.Name = "FloorItemsButton";
            FloorItemsButton.Size = new Size(150, 50);
            FloorItemsButton.TabIndex = 6;
            FloorItemsButton.Text = "Floor Items";
            FloorItemsButton.UseVisualStyleBackColor = true;
            // 
            // JobsButton
            // 
            JobsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            JobsButton.Location = new Point(167, 99);
            JobsButton.Name = "JobsButton";
            JobsButton.Size = new Size(150, 50);
            JobsButton.TabIndex = 7;
            JobsButton.Text = "Jobs";
            JobsButton.UseVisualStyleBackColor = true;
            // 
            // TrackingButton
            // 
            TrackingButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TrackingButton.Location = new Point(323, 99);
            TrackingButton.Name = "TrackingButton";
            TrackingButton.Size = new Size(150, 50);
            TrackingButton.TabIndex = 8;
            TrackingButton.Text = "Tracking";
            TrackingButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 13);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 9;
            label1.Text = "Select an attribute to edit.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(11, 5);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(75, 23);
            ExportButton.TabIndex = 10;
            ExportButton.Text = "Export";
            ExportButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 216);
            Controls.Add(ExportButton);
            Controls.Add(label1);
            Controls.Add(TrackingButton);
            Controls.Add(JobsButton);
            Controls.Add(FloorItemsButton);
            Controls.Add(ContainersButton);
            Controls.Add(DesksButton);
            Controls.Add(GuardsButton);
            Controls.Add(InmatesButton);
            Controls.Add(PrisonButton);
            Controls.Add(PlayerButton);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "The Escapists Save Editor GUI";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PlayerButton;
        private Button PrisonButton;
        private Button InmatesButton;
        private Button GuardsButton;
        private Button DesksButton;
        private Button ContainersButton;
        private Button FloorItemsButton;
        private Button JobsButton;
        private Button TrackingButton;
        private Label label1;
        private Button ExportButton;
    }
}
