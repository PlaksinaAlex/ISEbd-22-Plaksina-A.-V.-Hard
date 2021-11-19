namespace Lab1_Plaksina
{
	partial class FormAerodrom
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
			this.pictureBoxAerodrom = new System.Windows.Forms.PictureBox();
			this.buttonSetAirplane = new System.Windows.Forms.Button();
			this.buttonSetAerobus = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonTakeAirplane = new System.Windows.Forms.Button();
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
			this.listBoxAerodrom = new System.Windows.Forms.ListBox();
			this.buttonAddAerodrom = new System.Windows.Forms.Button();
			this.buttonDelAerodrom = new System.Windows.Forms.Button();
			this.buttonAddtoLinkedList = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrom)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxAerodrom
			// 
			this.pictureBoxAerodrom.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxAerodrom.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxAerodrom.Name = "pictureBoxAerodrom";
			this.pictureBoxAerodrom.Size = new System.Drawing.Size(670, 450);
			this.pictureBoxAerodrom.TabIndex = 0;
			this.pictureBoxAerodrom.TabStop = false;
			// 
			// buttonSetAirplane
			// 
			this.buttonSetAirplane.Location = new System.Drawing.Point(688, 202);
			this.buttonSetAirplane.Name = "buttonSetAirplane";
			this.buttonSetAirplane.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.buttonSetAirplane.Size = new System.Drawing.Size(92, 34);
			this.buttonSetAirplane.TabIndex = 1;
			this.buttonSetAirplane.Text = "припарковать самолет";
			this.buttonSetAirplane.UseVisualStyleBackColor = true;
			this.buttonSetAirplane.Click += new System.EventHandler(this.buttonSetAirplane_Click);
			// 
			// buttonSetAerobus
			// 
			this.buttonSetAerobus.Location = new System.Drawing.Point(688, 242);
			this.buttonSetAerobus.Name = "buttonSetAerobus";
			this.buttonSetAerobus.Size = new System.Drawing.Size(91, 54);
			this.buttonSetAerobus.TabIndex = 2;
			this.buttonSetAerobus.Text = "припарковать аэробус";
			this.buttonSetAerobus.UseVisualStyleBackColor = true;
			this.buttonSetAerobus.Click += new System.EventHandler(this.buttonSetAerobus_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonTakeAirplane);
			this.groupBox1.Controls.Add(this.maskedTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(678, 302);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(114, 93);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Забрать самолет";
			// 
			// buttonTakeAirplane
			// 
			this.buttonTakeAirplane.Location = new System.Drawing.Point(22, 52);
			this.buttonTakeAirplane.Name = "buttonTakeAirplane";
			this.buttonTakeAirplane.Size = new System.Drawing.Size(69, 31);
			this.buttonTakeAirplane.TabIndex = 2;
			this.buttonTakeAirplane.Text = "забрать";
			this.buttonTakeAirplane.UseVisualStyleBackColor = true;
			this.buttonTakeAirplane.Click += new System.EventHandler(this.buttonTakeAirplane_Click);
			// 
			// maskedTextBox
			// 
			this.maskedTextBox.Location = new System.Drawing.Point(54, 26);
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(28, 20);
			this.maskedTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Место:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(703, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Аэродромы";
			// 
			// textBoxNewLevelName
			// 
			this.textBoxNewLevelName.Location = new System.Drawing.Point(684, 25);
			this.textBoxNewLevelName.Name = "textBoxNewLevelName";
			this.textBoxNewLevelName.Size = new System.Drawing.Size(92, 20);
			this.textBoxNewLevelName.TabIndex = 5;
			// 
			// listBoxAerodrom
			// 
			this.listBoxAerodrom.FormattingEnabled = true;
			this.listBoxAerodrom.Location = new System.Drawing.Point(684, 85);
			this.listBoxAerodrom.Name = "listBoxAerodrom";
			this.listBoxAerodrom.Size = new System.Drawing.Size(97, 82);
			this.listBoxAerodrom.TabIndex = 6;
			this.listBoxAerodrom.SelectedIndexChanged += new System.EventHandler(this.listBoxAerodrom_SelectedIndexChanged);
			// 
			// buttonAddAerodrom
			// 
			this.buttonAddAerodrom.Location = new System.Drawing.Point(675, 51);
			this.buttonAddAerodrom.Name = "buttonAddAerodrom";
			this.buttonAddAerodrom.Size = new System.Drawing.Size(122, 28);
			this.buttonAddAerodrom.TabIndex = 7;
			this.buttonAddAerodrom.Text = "Добавить аэродром";
			this.buttonAddAerodrom.UseVisualStyleBackColor = true;
			this.buttonAddAerodrom.Click += new System.EventHandler(this.buttonAddAerodrom_Click);
			// 
			// buttonDelAerodrom
			// 
			this.buttonDelAerodrom.Location = new System.Drawing.Point(676, 173);
			this.buttonDelAerodrom.Name = "buttonDelAerodrom";
			this.buttonDelAerodrom.Size = new System.Drawing.Size(116, 23);
			this.buttonDelAerodrom.TabIndex = 8;
			this.buttonDelAerodrom.Text = "Удалить аэродром";
			this.buttonDelAerodrom.UseVisualStyleBackColor = true;
			this.buttonDelAerodrom.Click += new System.EventHandler(this.buttonDelAerodrom_Click);
			// 
			// buttonAddtoLinkedList
			// 
			this.buttonAddtoLinkedList.Location = new System.Drawing.Point(685, 401);
			this.buttonAddtoLinkedList.Name = "buttonAddtoLinkedList";
			this.buttonAddtoLinkedList.Size = new System.Drawing.Size(95, 37);
			this.buttonAddtoLinkedList.TabIndex = 9;
			this.buttonAddtoLinkedList.Text = "поместить в список";
			this.buttonAddtoLinkedList.UseVisualStyleBackColor = true;
			this.buttonAddtoLinkedList.Click += new System.EventHandler(this.buttonAddtoLinkedList_Click);
			// 
			// FormAerodrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonAddtoLinkedList);
			this.Controls.Add(this.buttonDelAerodrom);
			this.Controls.Add(this.buttonAddAerodrom);
			this.Controls.Add(this.listBoxAerodrom);
			this.Controls.Add(this.textBoxNewLevelName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonSetAerobus);
			this.Controls.Add(this.buttonSetAirplane);
			this.Controls.Add(this.pictureBoxAerodrom);
			this.Name = "FormAerodrom";
			this.Text = "Аэродром";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrom)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxAerodrom;
		private System.Windows.Forms.Button buttonSetAirplane;
		private System.Windows.Forms.Button buttonSetAerobus;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonTakeAirplane;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNewLevelName;
		private System.Windows.Forms.ListBox listBoxAerodrom;
		private System.Windows.Forms.Button buttonAddAerodrom;
		private System.Windows.Forms.Button buttonDelAerodrom;
		private System.Windows.Forms.Button buttonAddtoLinkedList;
	}
}