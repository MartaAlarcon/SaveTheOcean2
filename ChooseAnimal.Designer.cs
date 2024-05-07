namespace SaveTheOcean2
{
    partial class ChooseAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseAnimal));
            buttonAnimal = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonAnimal
            // 
            buttonAnimal.BackColor = Color.LightBlue;
            buttonAnimal.Font = new Font("Impact", 9F);
            buttonAnimal.Location = new Point(107, 147);
            buttonAnimal.Name = "buttonAnimal";
            buttonAnimal.Size = new Size(209, 44);
            buttonAnimal.TabIndex = 0;
            buttonAnimal.Text = "Jugar amb un animal existent";
            buttonAnimal.UseVisualStyleBackColor = false;
            buttonAnimal.Click += buttonAnimal_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("Impact", 9F);
            button1.Location = new Point(107, 197);
            button1.Name = "button1";
            button1.Size = new Size(209, 44);
            button1.TabIndex = 1;
            button1.Text = "Afegir un nou animal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 68);
            label1.Name = "label1";
            label1.Size = new Size(216, 45);
            label1.TabIndex = 2;
            label1.Text = "Què vols fer?";
            // 
            // ChooseAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(428, 311);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(buttonAnimal);
            Name = "ChooseAnimal";
            Text = "SaveTheOcean2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAnimal;
        private Button button1;
        private Label label1;
    }
}