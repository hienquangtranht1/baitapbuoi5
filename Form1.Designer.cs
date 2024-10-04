namespace b5
{
    partial class Form1
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
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.grpttsv = new System.Windows.Forms.GroupBox();
            this.cbbkhoa = new System.Windows.Forms.ComboBox();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.lbldtb = new System.Windows.Forms.Label();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnrepair = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvdssv = new System.Windows.Forms.DataGridView();
            this.STID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexit = new System.Windows.Forms.Button();
            this.grpttsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdssv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(76, 45);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(200, 22);
            this.txtmssv.TabIndex = 4;
            // 
            // grpttsv
            // 
            this.grpttsv.Controls.Add(this.cbbkhoa);
            this.grpttsv.Controls.Add(this.txtdtb);
            this.grpttsv.Controls.Add(this.txthoten);
            this.grpttsv.Controls.Add(this.txtmssv);
            this.grpttsv.Controls.Add(this.lbldtb);
            this.grpttsv.Controls.Add(this.lblkhoa);
            this.grpttsv.Controls.Add(this.lblhoten);
            this.grpttsv.Controls.Add(this.lblMSSV);
            this.grpttsv.Location = new System.Drawing.Point(52, 49);
            this.grpttsv.Name = "grpttsv";
            this.grpttsv.Size = new System.Drawing.Size(282, 291);
            this.grpttsv.TabIndex = 2;
            this.grpttsv.TabStop = false;
            this.grpttsv.Text = "Thông Tin Sinh Viên";
            // 
            // cbbkhoa
            // 
            this.cbbkhoa.FormattingEnabled = true;
            this.cbbkhoa.Location = new System.Drawing.Point(76, 176);
            this.cbbkhoa.Name = "cbbkhoa";
            this.cbbkhoa.Size = new System.Drawing.Size(200, 24);
            this.cbbkhoa.TabIndex = 7;
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(76, 242);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(200, 22);
            this.txtdtb.TabIndex = 6;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(76, 106);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(200, 22);
            this.txthoten.TabIndex = 5;
            // 
            // lbldtb
            // 
            this.lbldtb.AutoSize = true;
            this.lbldtb.Location = new System.Drawing.Point(26, 248);
            this.lbldtb.Name = "lbldtb";
            this.lbldtb.Size = new System.Drawing.Size(37, 16);
            this.lbldtb.TabIndex = 3;
            this.lbldtb.Text = "ĐTB:";
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Location = new System.Drawing.Point(26, 176);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(41, 16);
            this.lblkhoa.TabIndex = 2;
            this.lblkhoa.Text = "Khoa:";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(12, 109);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(55, 16);
            this.lblhoten.TabIndex = 1;
            this.lblhoten.Text = "Họ Tên:";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(19, 51);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(48, 16);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV:";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(259, 371);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnrepair
            // 
            this.btnrepair.Location = new System.Drawing.Point(164, 371);
            this.btnrepair.Name = "btnrepair";
            this.btnrepair.Size = new System.Drawing.Size(75, 23);
            this.btnrepair.TabIndex = 6;
            this.btnrepair.Text = "Repair";
            this.btnrepair.UseVisualStyleBackColor = true;
            this.btnrepair.Click += new System.EventHandler(this.btnrepair_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(55, 371);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvdssv
            // 
            this.dgvdssv.AllowUserToAddRows = false;
            this.dgvdssv.AllowUserToDeleteRows = false;
            this.dgvdssv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdssv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STID,
            this.FullName,
            this.dgvkhoa,
            this.dgvdtb});
            this.dgvdssv.Location = new System.Drawing.Point(368, 49);
            this.dgvdssv.Name = "dgvdssv";
            this.dgvdssv.RowHeadersWidth = 51;
            this.dgvdssv.RowTemplate.Height = 24;
            this.dgvdssv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdssv.Size = new System.Drawing.Size(508, 313);
            this.dgvdssv.TabIndex = 8;
            this.dgvdssv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdssv_CellClick);
            // 
            // STID
            // 
            this.STID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STID.HeaderText = "MSSV";
            this.STID.MinimumWidth = 6;
            this.STID.Name = "STID";
            this.STID.Width = 74;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FullName.HeaderText = "Họ Tên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 81;
            // 
            // dgvkhoa
            // 
            this.dgvkhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvkhoa.HeaderText = "Khoa";
            this.dgvkhoa.MinimumWidth = 6;
            this.dgvkhoa.Name = "dgvkhoa";
            this.dgvkhoa.Width = 67;
            // 
            // dgvdtb
            // 
            this.dgvdtb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvdtb.HeaderText = "ĐTB";
            this.dgvdtb.MinimumWidth = 6;
            this.dgvdtb.Name = "dgvdtb";
            this.dgvdtb.Width = 63;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(801, 397);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.dgvdssv);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnrepair);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.grpttsv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpttsv.ResumeLayout(false);
            this.grpttsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdssv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.GroupBox grpttsv;
        private System.Windows.Forms.ComboBox cbbkhoa;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label lbldtb;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnrepair;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvdssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn STID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdtb;
        private System.Windows.Forms.Button btnexit;
    }
}

