namespace SalvaOceano
{
    partial class ChooseRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseRole));
            label1 = new Label();
            TXT_Name = new TextBox();
            BTN_Next = new Button();
            CB_Rol = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 112);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 2;
            label1.Text = "Nom:";
            // 
            // TXT_Name
            // 
            TXT_Name.Location = new Point(163, 113);
            TXT_Name.Name = "TXT_Name";
            TXT_Name.Size = new Size(125, 27);
            TXT_Name.TabIndex = 3;
            // 
            // BTN_Next
            // 
            BTN_Next.BackColor = Color.LightBlue;
            BTN_Next.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_Next.Location = new Point(220, 192);
            BTN_Next.Name = "BTN_Next";
            BTN_Next.Size = new Size(94, 29);
            BTN_Next.TabIndex = 4;
            BTN_Next.Text = "Continuar";
            BTN_Next.UseVisualStyleBackColor = false;
            BTN_Next.Click += BTN_Next_Click;
            // 
            // CB_Rol
            // 
            CB_Rol.FormattingEnabled = true;
            CB_Rol.Items.AddRange(new object[] { "Veterinario", "Tecnico" });
            CB_Rol.Location = new Point(163, 146);
            CB_Rol.Name = "CB_Rol";
            CB_Rol.Size = new Size(151, 28);
            CB_Rol.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 34);
            label2.Name = "label2";
            label2.Size = new Size(250, 45);
            label2.TabIndex = 6;
            label2.Text = "Escull el teu rol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 146);
            label3.Name = "label3";
            label3.Size = new Size(47, 28);
            label3.TabIndex = 7;
            label3.Text = "Rol:";
            // 
            // ChooseRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(421, 250);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CB_Rol);
            Controls.Add(BTN_Next);
            Controls.Add(TXT_Name);
            Controls.Add(label1);
            Name = "ChooseRole";
            Text = "EscogerRol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_Next;
        private Button button2;
        private Label label1;
        private TextBox TXT_Name;
        private ComboBox CB_Rol;
        private Label label2;
        private Label label3;
    }
}