namespace SaveTheOcean2
{
    partial class AddAnimal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAnimal));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtBoxName = new TextBox();
            txtBoxFamily = new TextBox();
            txtBoxPlace = new TextBox();
            txtBoxSpecies = new TextBox();
            txtBoxWeight = new TextBox();
            errorProviderString = new ErrorProvider(components);
            errorProviderInt = new ErrorProvider(components);
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProviderString).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInt).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 36);
            label1.Name = "label1";
            label1.Size = new Size(515, 42);
            label1.TabIndex = 0;
            label1.Text = "Insereix les dades del nou animal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 13.8F);
            label2.Location = new Point(162, 114);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 1;
            label2.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 194);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 13.8F);
            label4.Location = new Point(162, 153);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 3;
            label4.Text = "Lloc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Impact", 13.8F);
            label5.Location = new Point(162, 191);
            label5.Name = "label5";
            label5.Size = new Size(81, 28);
            label5.TabIndex = 4;
            label5.Text = "Família";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Impact", 13.8F);
            label6.Location = new Point(162, 231);
            label6.Name = "label6";
            label6.Size = new Size(86, 28);
            label6.TabIndex = 5;
            label6.Text = "Espècie";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Impact", 13.8F);
            label7.Location = new Point(162, 269);
            label7.Name = "label7";
            label7.Size = new Size(47, 28);
            label7.TabIndex = 6;
            label7.Text = "Pes";
            // 
            // txtBoxName
            // 
            txtBoxName.BackColor = Color.LightBlue;
            txtBoxName.Font = new Font("Impact", 9F);
            txtBoxName.Location = new Point(292, 119);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(125, 26);
            txtBoxName.TabIndex = 7;
            // 
            // txtBoxFamily
            // 
            txtBoxFamily.BackColor = Color.LightBlue;
            txtBoxFamily.Font = new Font("Impact", 9F);
            txtBoxFamily.Location = new Point(292, 191);
            txtBoxFamily.Name = "txtBoxFamily";
            txtBoxFamily.Size = new Size(125, 26);
            txtBoxFamily.TabIndex = 8;
            // 
            // txtBoxPlace
            // 
            txtBoxPlace.BackColor = Color.LightBlue;
            txtBoxPlace.Font = new Font("Impact", 9F);
            txtBoxPlace.Location = new Point(292, 153);
            txtBoxPlace.Name = "txtBoxPlace";
            txtBoxPlace.Size = new Size(125, 26);
            txtBoxPlace.TabIndex = 9;
            // 
            // txtBoxSpecies
            // 
            txtBoxSpecies.BackColor = Color.LightBlue;
            txtBoxSpecies.Font = new Font("Impact", 9F);
            txtBoxSpecies.Location = new Point(292, 231);
            txtBoxSpecies.Name = "txtBoxSpecies";
            txtBoxSpecies.Size = new Size(125, 26);
            txtBoxSpecies.TabIndex = 10;
            // 
            // txtBoxWeight
            // 
            txtBoxWeight.BackColor = Color.LightBlue;
            txtBoxWeight.Font = new Font("Impact", 9F);
            txtBoxWeight.Location = new Point(292, 269);
            txtBoxWeight.Name = "txtBoxWeight";
            txtBoxWeight.Size = new Size(125, 26);
            txtBoxWeight.TabIndex = 11;
            // 
            // errorProviderString
            // 
            errorProviderString.ContainerControl = this;
            // 
            // errorProviderInt
            // 
            errorProviderInt.ContainerControl = this;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightBlue;
            buttonSave.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(162, 315);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(257, 42);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Insereix";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(575, 375);
            Controls.Add(buttonSave);
            Controls.Add(txtBoxWeight);
            Controls.Add(txtBoxSpecies);
            Controls.Add(txtBoxPlace);
            Controls.Add(txtBoxFamily);
            Controls.Add(txtBoxName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AddAnimal";
            Text = "SaveTheOcean2";
            ((System.ComponentModel.ISupportInitialize)errorProviderString).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderInt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtBoxName;
        private TextBox txtBoxFamily;
        private TextBox txtBoxPlace;
        private TextBox txtBoxSpecies;
        private TextBox txtBoxWeight;
        private ErrorProvider errorProviderString;
        private Button buttonSave;
        private ErrorProvider errorProviderInt;
    }
}