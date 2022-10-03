namespace Anket
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
            this.FileNameInput = new System.Windows.Forms.TextBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WomanRButton = new System.Windows.Forms.RadioButton();
            this.ManRButton = new System.Windows.Forms.RadioButton();
            this.GenderRButton = new System.Windows.Forms.RadioButton();
            this.BirthDateInput = new System.Windows.Forms.DateTimePicker();
            this.PhoneInput = new System.Windows.Forms.TextBox();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.CountryInput = new System.Windows.Forms.TextBox();
            this.FatherNameInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.SurnameInput = new System.Windows.Forms.TextBox();
            this.Gender_Label = new System.Windows.Forms.Label();
            this.BirthDate_Label = new System.Windows.Forms.Label();
            this.Phone_Label = new System.Windows.Forms.Label();
            this.City_Label = new System.Windows.Forms.Label();
            this.Country_Label = new System.Windows.Forms.Label();
            this.Father_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Surname_Label = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileNameInput
            // 
            this.FileNameInput.Location = new System.Drawing.Point(129, 1);
            this.FileNameInput.Name = "FileNameInput";
            this.FileNameInput.PlaceholderText = "Enter File Name";
            this.FileNameInput.Size = new System.Drawing.Size(137, 23);
            this.FileNameInput.TabIndex = 0;
            this.FileNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(299, 1);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WomanRButton);
            this.groupBox1.Controls.Add(this.ManRButton);
            this.groupBox1.Controls.Add(this.GenderRButton);
            this.groupBox1.Controls.Add(this.BirthDateInput);
            this.groupBox1.Controls.Add(this.PhoneInput);
            this.groupBox1.Controls.Add(this.CityInput);
            this.groupBox1.Controls.Add(this.CountryInput);
            this.groupBox1.Controls.Add(this.FatherNameInput);
            this.groupBox1.Controls.Add(this.NameInput);
            this.groupBox1.Controls.Add(this.SurnameInput);
            this.groupBox1.Controls.Add(this.Gender_Label);
            this.groupBox1.Controls.Add(this.BirthDate_Label);
            this.groupBox1.Controls.Add(this.Phone_Label);
            this.groupBox1.Controls.Add(this.City_Label);
            this.groupBox1.Controls.Add(this.Country_Label);
            this.groupBox1.Controls.Add(this.Father_Label);
            this.groupBox1.Controls.Add(this.Name_Label);
            this.groupBox1.Controls.Add(this.Surname_Label);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 329);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anket";
            // 
            // WomanRButton
            // 
            this.WomanRButton.AutoSize = true;
            this.WomanRButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WomanRButton.Location = new System.Drawing.Point(245, 296);
            this.WomanRButton.Name = "WomanRButton";
            this.WomanRButton.Size = new System.Drawing.Size(74, 20);
            this.WomanRButton.TabIndex = 16;
            this.WomanRButton.Text = "Woman";
            this.WomanRButton.UseVisualStyleBackColor = true;
            // 
            // ManRButton
            // 
            this.ManRButton.AutoSize = true;
            this.ManRButton.Checked = true;
            this.ManRButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ManRButton.Location = new System.Drawing.Point(158, 295);
            this.ManRButton.Name = "ManRButton";
            this.ManRButton.Size = new System.Drawing.Size(52, 20);
            this.ManRButton.TabIndex = 15;
            this.ManRButton.TabStop = true;
            this.ManRButton.Text = "Man";
            this.ManRButton.UseVisualStyleBackColor = true;
            this.WomanRButton.TabStop = true;
            this.WomanRButton.Text = "Woman";
            this.WomanRButton.UseVisualStyleBackColor = true;
            // 
            // GenderRButton
            // 
            this.GenderRButton.AutoSize = true;
            this.GenderRButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenderRButton.Location = new System.Drawing.Point(158, 295);
            this.GenderRButton.Name = "GenderRButton";
            this.GenderRButton.Size = new System.Drawing.Size(52, 20);
            this.GenderRButton.TabIndex = 15;
            this.GenderRButton.TabStop = true;
            this.GenderRButton.Text = "Man";
            this.GenderRButton.UseVisualStyleBackColor = true;
            // 
            // BirthDateInput
            // 
            this.BirthDateInput.Location = new System.Drawing.Point(140, 260);
            this.BirthDateInput.Name = "BirthDateInput";
            this.BirthDateInput.Size = new System.Drawing.Size(215, 23);
            this.BirthDateInput.TabIndex = 14;
            // 
            // PhoneInput
            // 
            this.PhoneInput.Location = new System.Drawing.Point(140, 200);
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.PlaceholderText = "Enter Phone";
            this.PhoneInput.Size = new System.Drawing.Size(215, 23);
            this.PhoneInput.TabIndex = 13;
            this.PhoneInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CityInput
            // 
            this.CityInput.Location = new System.Drawing.Point(140, 171);
            this.CityInput.Name = "CityInput";
            this.CityInput.PlaceholderText = "Enter City";
            this.CityInput.Size = new System.Drawing.Size(215, 23);
            this.CityInput.TabIndex = 12;
            this.CityInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CountryInput
            // 
            this.CountryInput.Location = new System.Drawing.Point(140, 142);
            this.CountryInput.Name = "CountryInput";
            this.CountryInput.PlaceholderText = "Enter Country";
            this.CountryInput.Size = new System.Drawing.Size(215, 23);
            this.CountryInput.TabIndex = 11;
            this.CountryInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FatherNameInput
            // 
            this.FatherNameInput.Location = new System.Drawing.Point(140, 87);
            this.FatherNameInput.Name = "FatherNameInput";
            this.FatherNameInput.PlaceholderText = "Enter Father Name";
            this.FatherNameInput.Size = new System.Drawing.Size(215, 23);
            this.FatherNameInput.TabIndex = 10;
            this.FatherNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(140, 58);
            this.NameInput.Name = "NameInput";
            this.NameInput.PlaceholderText = "Enter Name";
            this.NameInput.Size = new System.Drawing.Size(215, 23);
            this.NameInput.TabIndex = 9;
            this.NameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SurnameInput
            // 
            this.SurnameInput.Location = new System.Drawing.Point(140, 32);
            this.SurnameInput.Name = "SurnameInput";
            this.SurnameInput.PlaceholderText = "Enter Surname";
            this.SurnameInput.Size = new System.Drawing.Size(215, 23);
            this.SurnameInput.TabIndex = 8;
            this.SurnameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Gender_Label
            // 
            this.Gender_Label.AutoSize = true;
            this.Gender_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Gender_Label.Location = new System.Drawing.Point(22, 294);
            this.Gender_Label.Name = "Gender_Label";
            this.Gender_Label.Size = new System.Drawing.Size(60, 20);
            this.Gender_Label.TabIndex = 7;
            this.Gender_Label.Text = "Gender";
            // 
            // BirthDate_Label
            // 
            this.BirthDate_Label.AutoSize = true;
            this.BirthDate_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BirthDate_Label.Location = new System.Drawing.Point(22, 263);
            this.BirthDate_Label.Name = "BirthDate_Label";
            this.BirthDate_Label.Size = new System.Drawing.Size(77, 20);
            this.BirthDate_Label.TabIndex = 6;
            this.BirthDate_Label.Text = "BirthDate";
            // 
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.Phone_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Phone_Label.Location = new System.Drawing.Point(22, 203);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(53, 20);
            this.Phone_Label.TabIndex = 5;
            this.Phone_Label.Text = "Phone";
            // 
            // City_Label
            // 
            this.City_Label.AutoSize = true;
            this.City_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.City_Label.Location = new System.Drawing.Point(22, 174);
            this.City_Label.Name = "City_Label";
            this.City_Label.Size = new System.Drawing.Size(36, 20);
            this.City_Label.TabIndex = 4;
            this.City_Label.Text = "City";
            // 
            // Country_Label
            // 
            this.Country_Label.AutoSize = true;
            this.Country_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Country_Label.Location = new System.Drawing.Point(22, 145);
            this.Country_Label.Name = "Country_Label";
            this.Country_Label.Size = new System.Drawing.Size(66, 20);
            this.Country_Label.TabIndex = 3;
            this.Country_Label.Text = "Country";
            // 
            // Father_Label
            // 
            this.Father_Label.AutoSize = true;
            this.Father_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Father_Label.Location = new System.Drawing.Point(22, 90);
            this.Father_Label.Name = "Father_Label";
            this.Father_Label.Size = new System.Drawing.Size(100, 20);
            this.Father_Label.TabIndex = 2;
            this.Father_Label.Text = "Father Name";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_Label.Location = new System.Drawing.Point(22, 61);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(51, 20);
            this.Name_Label.TabIndex = 1;
            this.Name_Label.Text = "Name";
            // 
            // Surname_Label
            // 
            this.Surname_Label.AutoSize = true;
            this.Surname_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Surname_Label.Location = new System.Drawing.Point(22, 32);
            this.Surname_Label.Name = "Surname_Label";
            this.Surname_Label.Size = new System.Drawing.Size(71, 20);
            this.Surname_Label.TabIndex = 0;
            this.Surname_Label.Text = "Surname";
            //
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.Location = new System.Drawing.Point(12, 365);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(403, 34);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 408);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.FileNameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.FileNameInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FileNameInput;
        private Button LoadBtn;
        private GroupBox groupBox1;
        private RadioButton WomanRButton;
        private RadioButton ManRButton;
        private RadioButton GenderRButton;
        private DateTimePicker BirthDateInput;
        private TextBox PhoneInput;
        private TextBox CityInput;
        private TextBox CountryInput;
        private TextBox FatherNameInput;
        private TextBox NameInput;
        private TextBox SurnameInput;
        private Label Gender_Label;
        private Label BirthDate_Label;
        private Label Phone_Label;
        private Label City_Label;
        private Label Country_Label;
        private Label Father_Label;
        private Label Name_Label;
        private Label Surname_Label;
        private Button SaveBtn;
    }
}