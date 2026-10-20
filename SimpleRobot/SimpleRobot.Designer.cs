namespace SimpleRobot
{
    partial class Robot
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
            panel1 = new Panel();
            btn_North = new Button();
            btn_East = new Button();
            btn_South = new Button();
            btn_West = new Button();
            btn_GoOne = new Button();
            btn_GoTen = new Button();
            btn_Exit = new Button();
            lbl_Arrow = new Label();
            lbl_Position = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_Arrow);
            panel1.Location = new Point(12, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 234);
            panel1.TabIndex = 0;
            // 
            // btn_North
            // 
            btn_North.Location = new Point(140, 300);
            btn_North.Name = "btn_North";
            btn_North.Size = new Size(38, 32);
            btn_North.TabIndex = 1;
            btn_North.Text = "N";
            btn_North.UseVisualStyleBackColor = true;
            // 
            // btn_East
            // 
            btn_East.Location = new Point(175, 327);
            btn_East.Name = "btn_East";
            btn_East.Size = new Size(38, 29);
            btn_East.TabIndex = 2;
            btn_East.Text = "E";
            btn_East.UseVisualStyleBackColor = true;
            // 
            // btn_South
            // 
            btn_South.Location = new Point(140, 350);
            btn_South.Name = "btn_South";
            btn_South.Size = new Size(38, 29);
            btn_South.TabIndex = 3;
            btn_South.Text = "S";
            btn_South.UseVisualStyleBackColor = true;
            // 
            // btn_West
            // 
            btn_West.Location = new Point(105, 327);
            btn_West.Name = "btn_West";
            btn_West.Size = new Size(38, 29);
            btn_West.TabIndex = 4;
            btn_West.Text = "W";
            btn_West.UseVisualStyleBackColor = true;
            // 
            // btn_GoOne
            // 
            btn_GoOne.Location = new Point(43, 327);
            btn_GoOne.Name = "btn_GoOne";
            btn_GoOne.Size = new Size(56, 29);
            btn_GoOne.TabIndex = 5;
            btn_GoOne.Text = "Go 1";
            btn_GoOne.UseVisualStyleBackColor = true;
            // 
            // btn_GoTen
            // 
            btn_GoTen.Location = new Point(219, 327);
            btn_GoTen.Name = "btn_GoTen";
            btn_GoTen.Size = new Size(56, 29);
            btn_GoTen.TabIndex = 6;
            btn_GoTen.Text = "Go 10";
            btn_GoTen.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(219, 385);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(76, 30);
            btn_Exit.TabIndex = 7;
            btn_Exit.Text = "E&xit";
            btn_Exit.UseVisualStyleBackColor = true;
            // 
            // lbl_Arrow
            // 
            lbl_Arrow.AutoSize = true;
            lbl_Arrow.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Arrow.Location = new Point(128, 92);
            lbl_Arrow.Name = "lbl_Arrow";
            lbl_Arrow.Size = new Size(22, 26);
            lbl_Arrow.TabIndex = 0;
            lbl_Arrow.Text = "↑";
            // 
            // lbl_Position
            // 
            lbl_Position.AutoSize = true;
            lbl_Position.Location = new Point(12, 9);
            lbl_Position.Name = "lbl_Position";
            lbl_Position.Size = new Size(79, 20);
            lbl_Position.TabIndex = 8;
            lbl_Position.Text = "(X=0, Y=0)";
            // 
            // Robot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Exit;
            ClientSize = new Size(333, 450);
            Controls.Add(lbl_Position);
            Controls.Add(btn_Exit);
            Controls.Add(btn_GoTen);
            Controls.Add(btn_GoOne);
            Controls.Add(btn_West);
            Controls.Add(btn_South);
            Controls.Add(btn_East);
            Controls.Add(btn_North);
            Controls.Add(panel1);
            Name = "Robot";
            Text = "Robot";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_North;
        private Button btn_East;
        private Button btn_South;
        private Button btn_West;
        private Button btn_GoOne;
        private Button btn_GoTen;
        private Button btn_Exit;
        private Label lbl_Arrow;
        private Label lbl_Position;
    }
}
