namespace ZH2_FO2TPR
{
    partial class UserControl2
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
            dataGridView1 = new DataGridView();
            foglalasPkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            szobaFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mettolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            meddigDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            felnottSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gyermekSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            foglalasBindingSource = new BindingSource(components);
            btnAdd = new Button();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { foglalasPkDataGridViewTextBoxColumn, ugyfelFkDataGridViewTextBoxColumn, szobaFkDataGridViewTextBoxColumn, mettolDataGridViewTextBoxColumn, meddigDataGridViewTextBoxColumn, felnottSzamDataGridViewTextBoxColumn, gyermekSzamDataGridViewTextBoxColumn });
            dataGridView1.DataSource = foglalasBindingSource;
            dataGridView1.Location = new Point(16, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(743, 337);
            dataGridView1.TabIndex = 0;
            // 
            // foglalasPkDataGridViewTextBoxColumn
            // 
            foglalasPkDataGridViewTextBoxColumn.DataPropertyName = "FoglalasPk";
            foglalasPkDataGridViewTextBoxColumn.HeaderText = "FoglalasPk";
            foglalasPkDataGridViewTextBoxColumn.Name = "foglalasPkDataGridViewTextBoxColumn";
            // 
            // ugyfelFkDataGridViewTextBoxColumn
            // 
            ugyfelFkDataGridViewTextBoxColumn.DataPropertyName = "UgyfelFk";
            ugyfelFkDataGridViewTextBoxColumn.HeaderText = "UgyfelFk";
            ugyfelFkDataGridViewTextBoxColumn.Name = "ugyfelFkDataGridViewTextBoxColumn";
            // 
            // szobaFkDataGridViewTextBoxColumn
            // 
            szobaFkDataGridViewTextBoxColumn.DataPropertyName = "SzobaFk";
            szobaFkDataGridViewTextBoxColumn.HeaderText = "SzobaFk";
            szobaFkDataGridViewTextBoxColumn.Name = "szobaFkDataGridViewTextBoxColumn";
            // 
            // mettolDataGridViewTextBoxColumn
            // 
            mettolDataGridViewTextBoxColumn.DataPropertyName = "Mettol";
            mettolDataGridViewTextBoxColumn.HeaderText = "Mettol";
            mettolDataGridViewTextBoxColumn.Name = "mettolDataGridViewTextBoxColumn";
            // 
            // meddigDataGridViewTextBoxColumn
            // 
            meddigDataGridViewTextBoxColumn.DataPropertyName = "Meddig";
            meddigDataGridViewTextBoxColumn.HeaderText = "Meddig";
            meddigDataGridViewTextBoxColumn.Name = "meddigDataGridViewTextBoxColumn";
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
            // foglalasBindingSource
            // 
            foglalasBindingSource.DataSource = typeof(Models.Foglalas);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(215, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Hozzáadás";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(482, 24);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Törlés";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "UserControl2";
            Size = new Size(780, 417);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnRemove;
        private DataGridViewTextBoxColumn foglalasPkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ugyfelFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn szobaFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mettolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn meddigDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn felnottSzamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gyermekSzamDataGridViewTextBoxColumn;
        private BindingSource foglalasBindingSource;
    }
}
