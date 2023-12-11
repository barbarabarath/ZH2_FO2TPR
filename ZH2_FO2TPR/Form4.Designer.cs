namespace ZH2_FO2TPR
{
    partial class Form4
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
            lbHotel = new ListBox();
            lbStay = new ListBox();
            lbUser = new ListBox();
            lbRoom = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            textHotel = new TextBox();
            textUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbHotel
            // 
            lbHotel.FormattingEnabled = true;
            lbHotel.ItemHeight = 15;
            lbHotel.Location = new Point(20, 78);
            lbHotel.Name = "lbHotel";
            lbHotel.Size = new Size(135, 349);
            lbHotel.TabIndex = 0;
            lbHotel.SelectedIndexChanged += lbHotel_SelectedIndexChanged;
            // 
            // lbStay
            // 
            lbStay.FormattingEnabled = true;
            lbStay.ItemHeight = 15;
            lbStay.Location = new Point(264, 78);
            lbStay.Name = "lbStay";
            lbStay.Size = new Size(135, 349);
            lbStay.TabIndex = 1;
            // 
            // lbUser
            // 
            lbUser.FormattingEnabled = true;
            lbUser.ItemHeight = 15;
            lbUser.Location = new Point(467, 78);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(135, 349);
            lbUser.TabIndex = 2;
            // 
            // lbRoom
            // 
            lbRoom.FormattingEnabled = true;
            lbRoom.ItemHeight = 15;
            lbRoom.Location = new Point(176, 78);
            lbRoom.Name = "lbRoom";
            lbRoom.Size = new Size(62, 349);
            lbRoom.TabIndex = 3;
            lbRoom.SelectedIndexChanged += lbRoom_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(405, 141);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(56, 67);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "<";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(405, 240);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(56, 67);
            btnRemove.TabIndex = 5;
            btnRemove.Text = ">";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // textHotel
            // 
            textHotel.Location = new Point(20, 49);
            textHotel.Name = "textHotel";
            textHotel.Size = new Size(135, 23);
            textHotel.TabIndex = 6;
            textHotel.TextChanged += textHotel_TextChanged;
            // 
            // textUser
            // 
            textUser.Location = new Point(467, 49);
            textUser.Name = "textUser";
            textUser.Size = new Size(135, 23);
            textUser.TabIndex = 7;
            textUser.TextChanged += textUser_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 8;
            label1.Text = "Szálláshelyek:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 19);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 9;
            label2.Text = "Vendégek:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textUser);
            Controls.Add(textHotel);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lbRoom);
            Controls.Add(lbUser);
            Controls.Add(lbStay);
            Controls.Add(lbHotel);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbHotel;
        private ListBox lbStay;
        private ListBox lbUser;
        private ListBox lbRoom;
        private Button btnAdd;
        private Button btnRemove;
        private TextBox textHotel;
        private TextBox textUser;
        private Label label1;
        private Label label2;
    }
}