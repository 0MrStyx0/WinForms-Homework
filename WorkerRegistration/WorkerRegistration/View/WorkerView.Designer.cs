namespace WorkerRegistration
{
    partial class WorkerView
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
            listBoxWorkers = new ListBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            textBoxSurname = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            buttonRemove = new Button();
            buttonAdd = new Button();
            label4 = new Label();
            comboBoxPosition = new ComboBox();
            label11 = new Label();
            textBoxSalary = new TextBox();
            label12 = new Label();
            comboBoxCity = new ComboBox();
            label13 = new Label();
            comboBoxStreet = new ComboBox();
            label14 = new Label();
            textBoxHouse = new TextBox();
            labelName = new Label();
            labelSurname = new Label();
            labelPosition = new Label();
            labelSalary = new Label();
            labelCity = new Label();
            labelStreet = new Label();
            labelHouse = new Label();
            SuspendLayout();
            // 
            // listBoxWorkers
            // 
            listBoxWorkers.FormattingEnabled = true;
            listBoxWorkers.ItemHeight = 15;
            listBoxWorkers.Location = new Point(415, 12);
            listBoxWorkers.Name = "listBoxWorkers";
            listBoxWorkers.Size = new Size(373, 214);
            listBoxWorkers.TabIndex = 0;
            listBoxWorkers.SelectedIndexChanged += listBoxWorkers_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(415, 366);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 29;
            label10.Text = "City:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(415, 426);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 28;
            label9.Text = "House:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(415, 394);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 27;
            label8.Text = "Street:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(415, 338);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 26;
            label7.Text = "Salary($):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 276);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 25;
            label6.Text = "Surname:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 244);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 24;
            label5.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(415, 306);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 30;
            label1.Text = "Position:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(85, 81);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(153, 23);
            textBoxSurname.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 84);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 33;
            label2.Text = "Surname:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(85, 36);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(153, 23);
            textBoxName.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 39);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 31;
            label3.Text = "Name:";
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.Red;
            buttonRemove.Location = new Point(104, 422);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(75, 23);
            buttonRemove.TabIndex = 36;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Lime;
            buttonAdd.Location = new Point(12, 422);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 35;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 37;
            label4.Text = "Position:";
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Items.AddRange(new object[] { "Director", "Manager", "Accountant", "Frontend Developer", "Backend Developer", "Janitor" });
            comboBoxPosition.Location = new Point(85, 141);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(153, 23);
            comboBoxPosition.TabIndex = 38;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 197);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 39;
            label11.Text = "Salary:";
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(85, 197);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(153, 23);
            textBoxSalary.TabIndex = 40;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 255);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 41;
            label12.Text = "City:";
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Items.AddRange(new object[] { "Baku", "Moscow", "New-York", "London" });
            comboBoxCity.Location = new Point(85, 255);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(153, 23);
            comboBoxCity.TabIndex = 42;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 306);
            label13.Name = "label13";
            label13.Size = new Size(40, 15);
            label13.TabIndex = 43;
            label13.Text = "Street:";
            // 
            // comboBoxStreet
            // 
            comboBoxStreet.FormattingEnabled = true;
            comboBoxStreet.Location = new Point(85, 303);
            comboBoxStreet.Name = "comboBoxStreet";
            comboBoxStreet.Size = new Size(153, 23);
            comboBoxStreet.TabIndex = 44;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 355);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 45;
            label14.Text = "House:";
            // 
            // textBoxHouse
            // 
            textBoxHouse.Location = new Point(85, 352);
            textBoxHouse.Name = "textBoxHouse";
            textBoxHouse.Size = new Size(153, 23);
            textBoxHouse.TabIndex = 46;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F);
            labelName.Location = new Point(505, 244);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 15);
            labelName.TabIndex = 47;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(505, 276);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(0, 15);
            labelSurname.TabIndex = 48;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Location = new Point(505, 306);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(0, 15);
            labelPosition.TabIndex = 49;
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Location = new Point(505, 338);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(0, 15);
            labelSalary.TabIndex = 50;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(505, 366);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(0, 15);
            labelCity.TabIndex = 51;
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(505, 394);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(0, 15);
            labelStreet.TabIndex = 52;
            // 
            // labelHouse
            // 
            labelHouse.AutoSize = true;
            labelHouse.Location = new Point(505, 426);
            labelHouse.Name = "labelHouse";
            labelHouse.Size = new Size(0, 15);
            labelHouse.TabIndex = 53;
            // 
            // WorkerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelHouse);
            Controls.Add(labelStreet);
            Controls.Add(labelCity);
            Controls.Add(labelSalary);
            Controls.Add(labelPosition);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Controls.Add(textBoxHouse);
            Controls.Add(label14);
            Controls.Add(comboBoxStreet);
            Controls.Add(label13);
            Controls.Add(comboBoxCity);
            Controls.Add(label12);
            Controls.Add(textBoxSalary);
            Controls.Add(label11);
            Controls.Add(comboBoxPosition);
            Controls.Add(label4);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxSurname);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBoxWorkers);
            Name = "WorkerView";
            Text = "Form1";
            FormClosing += WorkerView_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxWorkers;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private TextBox textBoxSurname;
        private Label label2;
        private TextBox textBoxName;
        private Label label3;
        private Button buttonRemove;
        private Button buttonAdd;
        private Label label4;
        private ComboBox comboBoxPosition;
        private Label label11;
        private TextBox textBoxSalary;
        private Label label12;
        private ComboBox comboBoxCity;
        private Label label13;
        private ComboBox comboBoxStreet;
        private Label label14;
        private TextBox textBoxHouse;
        private Label labelName;
        private Label labelSurname;
        private Label labelPosition;
        private Label labelSalary;
        private Label labelCity;
        private Label labelStreet;
        private Label labelHouse;
    }
}
