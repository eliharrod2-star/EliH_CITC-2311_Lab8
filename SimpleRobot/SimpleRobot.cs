
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleRobot
{
    public partial class Robot : Form
    {
        private RobotMovement robot;

        public Robot()
        {
            InitializeComponent();

            robot = new RobotMovement();
            robot.RangeExceeded += Robot_RangeExceeded;

            btn_North.Click += btn_North_Click;
            btn_South.Click += btn_South_Click;
            btn_East.Click += btn_East_Click;
            btn_West.Click += btn_West_Click;
            btn_GoOne.Click += btn_GoOne_Click;
            btn_GoTen.Click += btn_GoTen_Click;
            btn_Exit.Click += btn_Exit_Click;

            UpdateRobot();
        }

        private void btn_North_Click(object sender, EventArgs e)
        {
            robot.CurrentDirection = Direction.North;
            UpdateRobot();
        }

        private void btn_South_Click(object sender, EventArgs e)
        {
            robot.CurrentDirection = Direction.South;
            UpdateRobot();
        }

        private void btn_East_Click(object sender, EventArgs e)
        {
            robot.CurrentDirection = Direction.East;
            UpdateRobot();
        }

        private void btn_West_Click(object sender, EventArgs e)
        {
            robot.CurrentDirection = Direction.West;
            UpdateRobot();
        }

        private void btn_GoOne_Click(object sender, EventArgs e)
        {
            robot.Move(1);
            UpdateRobot();
        }

        private void btn_GoTen_Click(object sender, EventArgs e)
        {
            robot.Move(10);
            UpdateRobot();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Robot_RangeExceeded(object sender, EventArgs e)
        {
            MessageBox.Show(
                "The robot cannot move beyond 100 units in any direction.",
                "Movement Limit",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void UpdateRobot()
        {
            lbl_Position.Text =
                $"(X={robot.Position.X}, Y={robot.Position.Y})";

            int centerX = (panel1.ClientSize.Width -
                lbl_Arrow.Width) / 2;

            int centerY = (panel1.ClientSize.Height -
                lbl_Arrow.Height) / 2;

            int pixelX = centerX + robot.Position.X;
            int pixelY = centerY - robot.Position.Y;

            lbl_Arrow.Location = new Point(pixelX, pixelY);

            switch (robot.CurrentDirection)
            {
                case Direction.North:
                    lbl_Arrow.Text = "↑";
                    break;

                case Direction.South:
                    lbl_Arrow.Text = "↓";
                    break;

                case Direction.East:
                    lbl_Arrow.Text = "→";
                    break;

                case Direction.West:
                    lbl_Arrow.Text = "←";
                    break;
            }
        }
    }
}

