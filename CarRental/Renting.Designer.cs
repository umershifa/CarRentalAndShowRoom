namespace CarRental
{
    partial class Renting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.searchCM = new System.Windows.Forms.Button();
            this.searchCAR = new System.Windows.Forms.TextBox();
            this.carDGV = new System.Windows.Forms.DataGridView();
            this.custDGV = new System.Windows.Forms.DataGridView();
            this.searchCUST = new System.Windows.Forms.TextBox();
            this.Brand = new System.Windows.Forms.ComboBox();
            this.model = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RefNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.carReg = new System.Windows.Forms.TextBox();
            this.CustNm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbtime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.carDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(14, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 158;
            this.button2.Text = "SEARCH CAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // searchCM
            // 
            this.searchCM.BackColor = System.Drawing.Color.DarkSlateGray;
            this.searchCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCM.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.searchCM.Location = new System.Drawing.Point(12, 75);
            this.searchCM.Name = "searchCM";
            this.searchCM.Size = new System.Drawing.Size(170, 23);
            this.searchCM.TabIndex = 157;
            this.searchCM.Text = "SEARCH CUSTOMER";
            this.searchCM.UseVisualStyleBackColor = false;
            // 
            // searchCAR
            // 
            this.searchCAR.ForeColor = System.Drawing.Color.OrangeRed;
            this.searchCAR.Location = new System.Drawing.Point(200, 262);
            this.searchCAR.Name = "searchCAR";
            this.searchCAR.Size = new System.Drawing.Size(265, 20);
            this.searchCAR.TabIndex = 156;
            // 
            // carDGV
            // 
            this.carDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.carDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.carDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDGV.Location = new System.Drawing.Point(12, 301);
            this.carDGV.Name = "carDGV";
            this.carDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carDGV.Size = new System.Drawing.Size(453, 157);
            this.carDGV.TabIndex = 155;
            this.carDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carDGV_CellClick);
            // 
            // custDGV
            // 
            this.custDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.custDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custDGV.Location = new System.Drawing.Point(12, 106);
            this.custDGV.Name = "custDGV";
            this.custDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custDGV.Size = new System.Drawing.Size(453, 138);
            this.custDGV.TabIndex = 154;
            this.custDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custDGV_CellClick);
            // 
            // searchCUST
            // 
            this.searchCUST.ForeColor = System.Drawing.Color.OrangeRed;
            this.searchCUST.Location = new System.Drawing.Point(200, 75);
            this.searchCUST.Name = "searchCUST";
            this.searchCUST.Size = new System.Drawing.Size(265, 20);
            this.searchCUST.TabIndex = 159;
            // 
            // Brand
            // 
            this.Brand.FormattingEnabled = true;
            this.Brand.Items.AddRange(new object[] {
            "TOYOTA",
            "NISSAN",
            "AUDI"});
            this.Brand.Location = new System.Drawing.Point(663, 139);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(261, 21);
            this.Brand.TabIndex = 176;
            this.Brand.Text = "--";
            this.Brand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Brand_KeyPress);
            // 
            // model
            // 
            this.model.FormattingEnabled = true;
            this.model.Items.AddRange(new object[] {
            "CARINA",
            "BENZ",
            "FH",
            "PRADO"});
            this.model.Location = new System.Drawing.Point(663, 179);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(261, 21);
            this.model.TabIndex = 175;
            this.model.Text = "--";
            this.model.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.model_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(472, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 174;
            this.label6.Text = "CAR BRAND";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(472, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 22);
            this.label16.TabIndex = 173;
            this.label16.Text = "CAR MODEL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(473, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 22);
            this.label11.TabIndex = 168;
            this.label11.Text = "CHARGE/HOUR";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(664, 245);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(259, 20);
            this.Price.TabIndex = 167;
            this.Price.Text = "0";
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.Honeydew;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(851, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 166;
            // 
            // RefNo
            // 
            this.RefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.RefNo.Location = new System.Drawing.Point(663, 75);
            this.RefNo.Name = "RefNo";
            this.RefNo.Size = new System.Drawing.Size(259, 26);
            this.RefNo.TabIndex = 165;
            this.RefNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RefNo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(471, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 164;
            this.label4.Text = "REFRENCE NO";
            // 
            // carReg
            // 
            this.carReg.Location = new System.Drawing.Point(664, 211);
            this.carReg.Name = "carReg";
            this.carReg.Size = new System.Drawing.Size(259, 20);
            this.carReg.TabIndex = 162;
            this.carReg.Text = "--";
            this.carReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carReg_KeyPress);
            // 
            // CustNm
            // 
            this.CustNm.Location = new System.Drawing.Point(663, 107);
            this.CustNm.Name = "CustNm";
            this.CustNm.Size = new System.Drawing.Size(259, 20);
            this.CustNm.TabIndex = 163;
            this.CustNm.Text = "--";
            this.CustNm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustNm_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(473, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 22);
            this.label8.TabIndex = 161;
            this.label8.Text = "CAR REG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(471, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 22);
            this.label10.TabIndex = 160;
            this.label10.Text = "CUSTOMER NAME";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 14.25F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(473, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 22);
            this.label12.TabIndex = 169;
            this.label12.Text = "DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 37);
            this.label1.TabIndex = 164;
            this.label1.Text = "MANAGE RENTING";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.Black;
            this.backbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backbtn.Location = new System.Drawing.Point(487, 365);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(177, 36);
            this.backbtn.TabIndex = 177;
            this.backbtn.Text = "MAIN MENU";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(737, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 36);
            this.button1.TabIndex = 178;
            this.button1.Text = "RENT OUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbtime
            // 
            this.Lbtime.Location = new System.Drawing.Point(664, 282);
            this.Lbtime.Name = "Lbtime";
            this.Lbtime.Size = new System.Drawing.Size(258, 20);
            this.Lbtime.TabIndex = 179;
            this.Lbtime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lbtime_KeyPress);
            // 
            // Renting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(934, 469);
            this.Controls.Add(this.Lbtime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RefNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.carReg);
            this.Controls.Add(this.CustNm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchCUST);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchCM);
            this.Controls.Add(this.searchCAR);
            this.Controls.Add(this.carDGV);
            this.Controls.Add(this.custDGV);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Renting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Renting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button searchCM;
        private System.Windows.Forms.TextBox searchCAR;
        private System.Windows.Forms.DataGridView carDGV;
        private System.Windows.Forms.DataGridView custDGV;
        private System.Windows.Forms.TextBox searchCUST;
        private System.Windows.Forms.ComboBox Brand;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RefNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox carReg;
        private System.Windows.Forms.TextBox CustNm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Lbtime;
    }
}