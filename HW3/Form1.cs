using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MainForm : Form
    {
        private int targetNumber;
        private bool gameActive;

        public MainForm()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 1001);

            gameActive = true;
            textBoxGuess.Clear();
            textBoxGuess.Enabled = true;
            buttonGuess.Enabled = true;
            labelHint.Text = "لدي رقم بين 1 و1000، هل يمكنك تخمين رقمي؟";
            UpdateBackgroundColor(SystemColors.Control);
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            if (gameActive)
            {
                if (int.TryParse(textBoxGuess.Text, out int userGuess))
                {
                    if (userGuess == targetNumber)
                    {
                        ShowResult("رائع لقد عرفت الرقم الصحيح.", MessageBoxIcon.Information, Color.Green);
                    }
                    else
                    {
                        ProvideHints(userGuess);
                    }
                }
                else
                {
                    MessageBox.Show("قم بادخال رقم صحيح.", "المدخل غير صحيح", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ProvideHints(int userGuess)
        {
            string hint;
            int difference = Math.Abs(targetNumber - userGuess);

            if (userGuess > targetNumber)
            {
                hint = "الرقم الذي أدخلته أكبر";
                UpdateBackgroundColor(Color.Orange);
            }
            else
            {
                hint = "الرقم الذي أدخلته أصغر";
                UpdateBackgroundColor(Color.Blue);
            }

            string warmth = (difference <= 10) ? "بينك وبين الاجابه قرابة ال 10 أرقام" : "اقتربت من الاجابة";
            string hintMessage = $"{warmth}.{hint}";

            labelHint.Text = hintMessage;
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void ShowResult(string message, MessageBoxIcon icon, Color backgroundColor)
        {
            MessageBox.Show(message, "Game Over", MessageBoxButtons.OK, icon);
            gameActive = false;
            textBoxGuess.Enabled = false;
            buttonGuess.Enabled = false;
            UpdateBackgroundColor(backgroundColor);
        }

        private void UpdateBackgroundColor(Color color)
        {
            labelHint.BackColor = color;
            this.BackColor = color;
        }

        private void InitializeComponent()
        {
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Location = new System.Drawing.Point(110, 76);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(113, 20);
            this.textBoxGuess.TabIndex = 0;
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new System.Drawing.Point(30, 20);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(0, 13);
            this.labelHint.TabIndex = 1;
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(45, 120);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(100, 23);
            this.buttonGuess.TabIndex = 2;
            this.buttonGuess.Text = "Submit Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Location = new System.Drawing.Point(183, 120);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(100, 23);
            this.buttonPlayAgain.TabIndex = 3;
            this.buttonPlayAgain.Text = "Play Again";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 170);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.buttonPlayAgain);
            this.Name = "MainForm";
            this.Text = "Guess the Number Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Button buttonPlayAgain;
    }
}
