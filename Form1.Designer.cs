namespace SalvaOceano
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
            label1 = new Label();
            play = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 39);
            label1.Name = "label1";
            label1.Size = new Size(266, 48);
            label1.TabIndex = 0;
            label1.Text = "Save the ocean";
            // 
            // play
            // 
            play.BackColor = Color.LightBlue;
            play.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            play.Location = new Point(190, 131);
            play.Name = "play";
            play.Size = new Size(94, 29);
            play.TabIndex = 1;
            play.Text = "Jugar";
            play.UseVisualStyleBackColor = false;
            play.Click += play_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.LightBlue;
            exit.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(290, 131);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 2;
            exit.Text = "Sortir";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(560, 251);
            Controls.Add(exit);
            Controls.Add(play);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SaveTheOcean2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button play;
        private Button exit;
    }
}
