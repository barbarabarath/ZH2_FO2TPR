namespace ZH2_FO2TPR
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnExcel = new Button();
            lbHotel = new ListBox();
            lbRoom = new ListBox();
            dataGridView1 = new DataGridView();
            userDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            felnottSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gyermekSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservationBindingSource = new BindingSource(components);
            textHotel = new TextBox();
            textTotal = new TextBox();
            textResCount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(479, 26);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(129, 23);
            btnExcel.TabIndex = 0;
            btnExcel.Text = "Adatok letöltése";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // lbHotel
            // 
            lbHotel.FormattingEnabled = true;
            lbHotel.ItemHeight = 15;
            lbHotel.Location = new Point(12, 70);
            lbHotel.Name = "lbHotel";
            lbHotel.Size = new Size(139, 304);
            lbHotel.TabIndex = 1;
            lbHotel.SelectedIndexChanged += lbHotel_SelectedIndexChanged;
            // 
            // lbRoom
            // 
            lbRoom.FormattingEnabled = true;
            lbRoom.ItemHeight = 15;
            lbRoom.Location = new Point(175, 70);
            lbRoom.Name = "lbRoom";
            lbRoom.Size = new Size(58, 304);
            lbRoom.TabIndex = 2;
            lbRoom.SelectedIndexChanged += lbRoom_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userDataGridViewTextBoxColumn, felnottSzamDataGridViewTextBoxColumn, gyermekSzamDataGridViewTextBoxColumn });
            dataGridView1.DataSource = reservationBindingSource;
            dataGridView1.Location = new Point(261, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(347, 303);
            dataGridView1.TabIndex = 3;
            // 
            // userDataGridViewTextBoxColumn
            // 
            userDataGridViewTextBoxColumn.DataPropertyName = "User";
            userDataGridViewTextBoxColumn.HeaderText = "User";
            userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // felnottSzamDataGridViewTextBoxColumn
            // 
            felnottSzamDataGridViewTextBoxColumn.DataPropertyName = "FelnottSzam";
            felnottSzamDataGridViewTextBoxColumn.HeaderText = "FelnottSzam";
            felnottSzamDataGridViewTextBoxColumn.Name = "felnottSzamDataGridViewTextBoxColumn";
            // 
            // gyermekSzamDataGridViewTextBoxColumn
            // 
            gyermekSzamDataGridViewTextBoxColumn.DataPropertyName = "GyermekSzam";
            gyermekSzamDataGridViewTextBoxColumn.HeaderText = "GyermekSzam";
            gyermekSzamDataGridViewTextBoxColumn.Name = "gyermekSzamDataGridViewTextBoxColumn";
            // 
            // reservationBindingSource
            // 
            reservationBindingSource.DataSource = typeof(Reservation);
            // 
            // textHotel
            // 
            textHotel.Location = new Point(12, 41);
            textHotel.Name = "textHotel";
            textHotel.Size = new Size(139, 23);
            textHotel.TabIndex = 4;
            textHotel.TextChanged += textHotel_TextChanged;
            // 
            // textTotal
            // 
            textTotal.Location = new Point(260, 394);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(51, 23);
            textTotal.TabIndex = 5;
            // 
            // textResCount
            // 
            textResCount.Location = new Point(557, 394);
            textResCount.Name = "textResCount";
            textResCount.Size = new Size(51, 23);
            textResCount.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 12);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 7;
            label1.Text = "Szálláshelyek:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 12);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 8;
            label2.Text = "Szoba száma:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 397);
            label3.Name = "label3";
            label3.Size = new Size(204, 15);
            label3.TabIndex = 9;
            label3.Text = "Szobában megszállt vendégek száma:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 397);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 10;
            label4.Text = "Foglalások száma:";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textResCount);
            Controls.Add(textTotal);
            Controls.Add(textHotel);
            Controls.Add(dataGridView1);
            Controls.Add(lbRoom);
            Controls.Add(lbHotel);
            Controls.Add(btnExcel);
            Name = "UserControl1";
            Size = new Size(630, 430);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExcel;
        private ListBox lbHotel;
        private ListBox lbRoom;
        private DataGridView dataGridView1;
        private TextBox textHotel;
        private TextBox textTotal;
        private TextBox textResCount;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn felnottSzamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gyermekSzamDataGridViewTextBoxColumn;
        private BindingSource reservationBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
