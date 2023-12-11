namespace ZH2_FO2TPR
{
    partial class UserControl3
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            foglalasBindingSource = new BindingSource(components);
            btnModify = new Button();
            vendegBindingSource = new BindingSource(components);
            szobaBindingSource = new BindingSource(components);
            foglalasPkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelFkDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            szobaFkDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            mettolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            meddigDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            felnottSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gyermekSzamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendegBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)szobaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "Foglalások megjelenítése:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { foglalasPkDataGridViewTextBoxColumn, ugyfelFkDataGridViewTextBoxColumn, szobaFkDataGridViewTextBoxColumn, mettolDataGridViewTextBoxColumn, meddigDataGridViewTextBoxColumn, felnottSzamDataGridViewTextBoxColumn, gyermekSzamDataGridViewTextBoxColumn });
            dataGridView1.DataSource = foglalasBindingSource;
            dataGridView1.Location = new Point(18, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(759, 379);
            dataGridView1.TabIndex = 1;
            // 
            // foglalasBindingSource
            // 
            foglalasBindingSource.DataSource = typeof(Models.Foglalas);
            // 
            // btnModify
            // 
            btnModify.Location = new Point(702, 30);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 2;
            btnModify.Text = "Módosítás";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // vendegBindingSource
            // 
            vendegBindingSource.DataSource = typeof(Models.Vendeg);
            // 
            // szobaBindingSource
            // 
            szobaBindingSource.DataSource = typeof(Models.Szoba);
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
            ugyfelFkDataGridViewTextBoxColumn.DataSource = vendegBindingSource;
            ugyfelFkDataGridViewTextBoxColumn.DisplayMember = "Nev";
            ugyfelFkDataGridViewTextBoxColumn.HeaderText = "UgyfelFk";
            ugyfelFkDataGridViewTextBoxColumn.Name = "ugyfelFkDataGridViewTextBoxColumn";
            ugyfelFkDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            ugyfelFkDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            ugyfelFkDataGridViewTextBoxColumn.ValueMember = "Usernev";
            // 
            // szobaFkDataGridViewTextBoxColumn
            // 
            szobaFkDataGridViewTextBoxColumn.DataPropertyName = "SzobaFk";
            szobaFkDataGridViewTextBoxColumn.DataSource = szobaBindingSource;
            szobaFkDataGridViewTextBoxColumn.DisplayMember = "SzobaSzama";
            szobaFkDataGridViewTextBoxColumn.HeaderText = "SzobaFk";
            szobaFkDataGridViewTextBoxColumn.Name = "szobaFkDataGridViewTextBoxColumn";
            szobaFkDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            szobaFkDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            szobaFkDataGridViewTextBoxColumn.ValueMember = "SzobaId";
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
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnModify);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "UserControl3";
            Size = new Size(794, 463);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)foglalasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendegBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)szobaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource foglalasBindingSource;
        private Button btnModify;
        private BindingSource vendegBindingSource;
        private BindingSource szobaBindingSource;
        private DataGridViewTextBoxColumn foglalasPkDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn ugyfelFkDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn szobaFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mettolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn meddigDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn felnottSzamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gyermekSzamDataGridViewTextBoxColumn;
    }
}
