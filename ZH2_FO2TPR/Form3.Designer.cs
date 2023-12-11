namespace ZH2_FO2TPR
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBoxUser = new ComboBox();
            comboBoxHotel = new ComboBox();
            comboBoxRoom = new ComboBox();
            textAdult = new TextBox();
            textKid = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnAdd = new Button();
            btnQuit = new Button();
            foglalasBindingSource = new BindingSource(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Szálláshely:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Szoba:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 3;
            label4.Text = "Felnőttek száma:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 164);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 4;
            label5.Text = "Gyermekek száma:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 199);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 5;
            label6.Text = "Érkezés:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 234);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 6;
            label7.Text = "Távozás:";
            // 
            // comboBoxUser
            // 
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(122, 19);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(121, 23);
            comboBoxUser.TabIndex = 7;
            // 
            // comboBoxHotel
            // 
            comboBoxHotel.FormattingEnabled = true;
            comboBoxHotel.Location = new Point(122, 54);
            comboBoxHotel.Name = "comboBoxHotel";
            comboBoxHotel.Size = new Size(121, 23);
            comboBoxHotel.TabIndex = 8;
            comboBoxHotel.SelectedIndexChanged += comboBoxHotel_SelectedIndexChanged;
            // 
            // comboBoxRoom
            // 
            comboBoxRoom.FormattingEnabled = true;
            comboBoxRoom.Location = new Point(122, 90);
            comboBoxRoom.Name = "comboBoxRoom";
            comboBoxRoom.Size = new Size(121, 23);
            comboBoxRoom.TabIndex = 9;
            // 
            // textAdult
            // 
            textAdult.Location = new Point(122, 128);
            textAdult.Name = "textAdult";
            textAdult.Size = new Size(56, 23);
            textAdult.TabIndex = 10;
            textAdult.Validating += textAdult_Validating;
            textAdult.Validated += textAdult_Validated;
            // 
            // textKid
            // 
            textKid.Location = new Point(122, 161);
            textKid.Name = "textKid";
            textKid.Size = new Size(56, 23);
            textKid.TabIndex = 11;
            textKid.Validating += textKid_Validating;
            textKid.Validated += textKid_Validated;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 193);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(122, 228);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(53, 279);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Hozzáadás";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(203, 279);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 15;
            btnQuit.Text = "Mégse";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // foglalasBindingSource
            // 
            foglalasBindingSource.DataSource = typeof(Models.Foglalas);
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 314);
            Controls.Add(btnQuit);
            Controls.Add(btnAdd);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textKid);
            Controls.Add(textAdult);
            Controls.Add(comboBoxRoom);
            Controls.Add(comboBoxHotel);
            Controls.Add(comboBoxUser);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private ComboBox comboBoxUser;
        private ComboBox comboBoxHotel;
        private ComboBox comboBoxRoom;
        private TextBox textAdult;
        private TextBox textKid;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnAdd;
        private Button btnQuit;
        private BindingSource foglalasBindingSource;
        private ErrorProvider errorProvider1;
    }
}