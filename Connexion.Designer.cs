namespace Fleurs
{
	partial class Connexion
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
			connexion_textbox = new GroupBox();
			email_label = new Label();
			password_label = new Label();
			inscription_label_link = new LinkLabel();
			email_textbox = new TextBox();
			password_textbox = new TextBox();
			connexion_button = new Button();
			connexion_textbox.SuspendLayout();
			SuspendLayout();
			// 
			// connexion_textbox
			// 
			connexion_textbox.Controls.Add(connexion_button);
			connexion_textbox.Controls.Add(password_textbox);
			connexion_textbox.Controls.Add(email_textbox);
			connexion_textbox.Controls.Add(inscription_label_link);
			connexion_textbox.Controls.Add(password_label);
			connexion_textbox.Controls.Add(email_label);
			connexion_textbox.Location = new Point(256, 85);
			connexion_textbox.Name = "connexion_textbox";
			connexion_textbox.Size = new Size(348, 270);
			connexion_textbox.TabIndex = 0;
			connexion_textbox.TabStop = false;
			connexion_textbox.Text = "Connexion";
			// 
			// email_label
			// 
			email_label.AutoSize = true;
			email_label.Location = new Point(84, 52);
			email_label.Name = "email_label";
			email_label.Size = new Size(46, 20);
			email_label.TabIndex = 0;
			email_label.Text = "Email";
			// 
			// password_label
			// 
			password_label.AutoSize = true;
			password_label.Location = new Point(84, 131);
			password_label.Name = "password_label";
			password_label.Size = new Size(70, 20);
			password_label.TabIndex = 1;
			password_label.Text = "Password";
			// 
			// inscription_label_link
			// 
			inscription_label_link.AutoSize = true;
			inscription_label_link.Location = new Point(172, 235);
			inscription_label_link.Name = "inscription_label_link";
			inscription_label_link.Size = new Size(101, 20);
			inscription_label_link.TabIndex = 2;
			inscription_label_link.TabStop = true;
			inscription_label_link.Text = "Inscrivez-vous";
			// 
			// email_textbox
			// 
			email_textbox.Location = new Point(84, 86);
			email_textbox.Name = "email_textbox";
			email_textbox.Size = new Size(125, 27);
			email_textbox.TabIndex = 3;
			// 
			// password_textbox
			// 
			password_textbox.Location = new Point(84, 154);
			password_textbox.Name = "password_textbox";
			password_textbox.Size = new Size(125, 27);
			password_textbox.TabIndex = 4;
			// 
			// connexion_button
			// 
			connexion_button.Location = new Point(111, 202);
			connexion_button.Name = "connexion_button";
			connexion_button.Size = new Size(94, 29);
			connexion_button.TabIndex = 5;
			connexion_button.Text = "Connexion";
			connexion_button.UseVisualStyleBackColor = true;
			connexion_button.Click += connexion_button_Click;
			// 
			// Connexion
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(connexion_textbox);
			Name = "Connexion";
			Text = "Connexion";
			connexion_textbox.ResumeLayout(false);
			connexion_textbox.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox connexion_textbox;
		private Button connexion_button;
		private TextBox password_textbox;
		private TextBox email_textbox;
		private LinkLabel inscription_label_link;
		private Label password_label;
		private Label email_label;
	}
}