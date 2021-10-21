namespace Lab1_Plaksina
{
	partial class FormAerobus
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBoxAerobus = new System.Windows.Forms.PictureBox();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonCreateAerobus = new System.Windows.Forms.Button();
			this.count_ill = new System.Windows.Forms.ComboBox();
			this.label_ill = new System.Windows.Forms.Label();
			this.label_type = new System.Windows.Forms.Label();
			this.type_ill = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerobus)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxAerobus
			// 
			this.pictureBoxAerobus.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.pictureBoxAerobus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxAerobus.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxAerobus.Name = "pictureBoxAerobus";
			this.pictureBoxAerobus.Size = new System.Drawing.Size(884, 461);
			this.pictureBoxAerobus.TabIndex = 0;
			this.pictureBoxAerobus.TabStop = false;
			// 
			// buttonLeft
			// 
			this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLeft.BackgroundImage = global::Lab1_Plaksina.Properties.Resources.left;
			this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLeft.Location = new System.Drawing.Point(740, 419);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(30, 30);
			this.buttonLeft.TabIndex = 2;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.BackgroundImage = global::Lab1_Plaksina.Properties.Resources.up;
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUp.Location = new System.Drawing.Point(776, 383);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(30, 30);
			this.buttonUp.TabIndex = 3;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.BackgroundImage = global::Lab1_Plaksina.Properties.Resources.down;
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDown.Location = new System.Drawing.Point(776, 419);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(30, 30);
			this.buttonDown.TabIndex = 4;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRight.BackgroundImage = global::Lab1_Plaksina.Properties.Resources.right;
			this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRight.Location = new System.Drawing.Point(812, 419);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(30, 30);
			this.buttonRight.TabIndex = 5;
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonCreateAerobus
			// 
			this.buttonCreateAerobus.Location = new System.Drawing.Point(21, 22);
			this.buttonCreateAerobus.Name = "buttonCreateAerobus";
			this.buttonCreateAerobus.Size = new System.Drawing.Size(144, 30);
			this.buttonCreateAerobus.TabIndex = 6;
			this.buttonCreateAerobus.Text = "Создать аэробус";
			this.buttonCreateAerobus.UseVisualStyleBackColor = true;
			this.buttonCreateAerobus.Click += new System.EventHandler(this.buttonCreateAerobus_Click);
			// 
			// count_ill
			// 
			this.count_ill.FormattingEnabled = true;
			this.count_ill.Items.AddRange(new object[] {
            "10",
            "20",
            "30"});
			this.count_ill.Location = new System.Drawing.Point(161, 425);
			this.count_ill.Name = "count_ill";
			this.count_ill.Size = new System.Drawing.Size(45, 21);
			this.count_ill.TabIndex = 6;
			// 
			// label_ill
			// 
			this.label_ill.AutoSize = true;
			this.label_ill.Location = new System.Drawing.Point(18, 419);
			this.label_ill.Name = "label_ill";
			this.label_ill.Size = new System.Drawing.Size(120, 26);
			this.label_ill.TabIndex = 7;
			this.label_ill.Text = "выберите количество \r\n      иллюминаторов:\r\n";
			// 
			// label_type
			// 
			this.label_type.AutoSize = true;
			this.label_type.Location = new System.Drawing.Point(280, 419);
			this.label_type.Name = "label_type";
			this.label_type.Size = new System.Drawing.Size(95, 26);
			this.label_type.TabIndex = 8;
			this.label_type.Text = "выберите форму \r\nиллюминаторов:\r\n";
			// 
			// type_ill
			// 
			this.type_ill.FormattingEnabled = true;
			this.type_ill.Items.AddRange(new object[] {
            "круглые",
            "квадратные",
            "в полоску"});
			this.type_ill.Location = new System.Drawing.Point(405, 424);
			this.type_ill.Name = "type_ill";
			this.type_ill.Size = new System.Drawing.Size(90, 21);
			this.type_ill.TabIndex = 9;
			// 
			// FormAerobus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 461);
			this.Controls.Add(this.type_ill);
			this.Controls.Add(this.label_type);
			this.Controls.Add(this.label_ill);
			this.Controls.Add(this.count_ill);
			this.Controls.Add(this.buttonCreateAerobus);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.pictureBoxAerobus);
			this.Name = "FormAerobus";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormAerobus";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerobus)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxAerobus;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonCreateAerobus;
		private System.Windows.Forms.ComboBox count_ill;
		private System.Windows.Forms.Label label_ill;
		private System.Windows.Forms.Label label_type;
		private System.Windows.Forms.ComboBox type_ill;
	}
}

