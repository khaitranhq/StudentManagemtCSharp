using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// List of student
        private List<Student> students = new List<Student>();

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
            this.bigTitleLb = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.mssvLb = new System.Windows.Forms.Label();
            this.dateOfBirthLb = new System.Windows.Forms.Label();
            this.addressLb = new System.Windows.Forms.Label();
            this.schoolYearLb = new System.Windows.Forms.Label();
            this.phoneNumberLb = new System.Windows.Forms.Label();
            this.universityRBtn = new System.Windows.Forms.RadioButton();
            this.secondaryDegreeRBtn = new System.Windows.Forms.RadioButton();
            this.collegeRBtn = new System.Windows.Forms.RadioButton();
            this.specializedLb = new System.Windows.Forms.Label();
            this.specializedAutoCmp = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.firstDegreeTbx = new System.Windows.Forms.TextBox();
            this.workPlaceTbx = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.nameTbx = new System.Windows.Forms.TextBox();
            this.mssvTbx = new System.Windows.Forms.TextBox();
            this.addressTbx = new System.Windows.Forms.TextBox();
            this.phoneNumberTbx = new System.Windows.Forms.TextBox();
            this.dateOfBirthDTP = new System.Windows.Forms.DateTimePicker();
            this.typeDegreeGbx = new System.Windows.Forms.GroupBox();
            this.listStudentGbx = new System.Windows.Forms.GroupBox();
            this.listStudentView = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schoolYearNum = new System.Windows.Forms.NumericUpDown();
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SchoolYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeDegree = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeDegreeGbx.SuspendLayout();
            this.listStudentGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolYearNum)).BeginInit();
            this.SuspendLayout();
            // 
            // bigTitleLb
            // 
            this.bigTitleLb.AutoSize = true;
            this.bigTitleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigTitleLb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bigTitleLb.Location = new System.Drawing.Point(320, 18);
            this.bigTitleLb.Name = "bigTitleLb";
            this.bigTitleLb.Size = new System.Drawing.Size(435, 39);
            this.bigTitleLb.TabIndex = 0;
            this.bigTitleLb.Text = "Quản lí thông tin sinh viên";
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(220, 88);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(50, 17);
            this.nameLb.TabIndex = 1;
            this.nameLb.Text = "Họ tên";
            // 
            // mssvLb
            // 
            this.mssvLb.AutoSize = true;
            this.mssvLb.Location = new System.Drawing.Point(219, 119);
            this.mssvLb.Name = "mssvLb";
            this.mssvLb.Size = new System.Drawing.Size(68, 17);
            this.mssvLb.TabIndex = 2;
            this.mssvLb.Text = "Mã số SV";
            // 
            // dateOfBirthLb
            // 
            this.dateOfBirthLb.AutoSize = true;
            this.dateOfBirthLb.Location = new System.Drawing.Point(219, 147);
            this.dateOfBirthLb.Name = "dateOfBirthLb";
            this.dateOfBirthLb.Size = new System.Drawing.Size(71, 17);
            this.dateOfBirthLb.TabIndex = 3;
            this.dateOfBirthLb.Text = "Ngày sinh";
            // 
            // addressLb
            // 
            this.addressLb.AutoSize = true;
            this.addressLb.Location = new System.Drawing.Point(567, 90);
            this.addressLb.Name = "addressLb";
            this.addressLb.Size = new System.Drawing.Size(51, 17);
            this.addressLb.TabIndex = 4;
            this.addressLb.Text = "Địa chỉ";
            // 
            // schoolYearLb
            // 
            this.schoolYearLb.AutoSize = true;
            this.schoolYearLb.Location = new System.Drawing.Point(566, 147);
            this.schoolYearLb.Name = "schoolYearLb";
            this.schoolYearLb.Size = new System.Drawing.Size(72, 17);
            this.schoolYearLb.TabIndex = 5;
            this.schoolYearLb.Text = "Niên khóa";
            // 
            // phoneNumberLb
            // 
            this.phoneNumberLb.AutoSize = true;
            this.phoneNumberLb.Location = new System.Drawing.Point(567, 119);
            this.phoneNumberLb.Name = "phoneNumberLb";
            this.phoneNumberLb.Size = new System.Drawing.Size(72, 17);
            this.phoneNumberLb.TabIndex = 6;
            this.phoneNumberLb.Text = "Điện thoại";
            // 
            // universityRBtn
            // 
            this.universityRBtn.AutoSize = true;
            this.universityRBtn.Location = new System.Drawing.Point(48, 35);
            this.universityRBtn.Name = "universityRBtn";
            this.universityRBtn.Size = new System.Drawing.Size(77, 21);
            this.universityRBtn.TabIndex = 7;
            this.universityRBtn.TabStop = true;
            this.universityRBtn.Text = "Đại học";
            this.universityRBtn.UseVisualStyleBackColor = true;
            // 
            // secondaryDegreeRBtn
            // 
            this.secondaryDegreeRBtn.AutoSize = true;
            this.secondaryDegreeRBtn.Location = new System.Drawing.Point(329, 35);
            this.secondaryDegreeRBtn.Name = "secondaryDegreeRBtn";
            this.secondaryDegreeRBtn.Size = new System.Drawing.Size(85, 21);
            this.secondaryDegreeRBtn.TabIndex = 8;
            this.secondaryDegreeRBtn.TabStop = true;
            this.secondaryDegreeRBtn.Text = "Bằng hai";
            this.secondaryDegreeRBtn.UseVisualStyleBackColor = true;
            // 
            // collegeRBtn
            // 
            this.collegeRBtn.AutoSize = true;
            this.collegeRBtn.Location = new System.Drawing.Point(622, 35);
            this.collegeRBtn.Name = "collegeRBtn";
            this.collegeRBtn.Size = new System.Drawing.Size(90, 21);
            this.collegeRBtn.TabIndex = 9;
            this.collegeRBtn.TabStop = true;
            this.collegeRBtn.Text = "Cao đẳng";
            this.collegeRBtn.UseVisualStyleBackColor = true;
            // 
            // specializedLb
            // 
            this.specializedLb.AutoSize = true;
            this.specializedLb.Location = new System.Drawing.Point(45, 81);
            this.specializedLb.Name = "specializedLb";
            this.specializedLb.Size = new System.Drawing.Size(100, 17);
            this.specializedLb.TabIndex = 10;
            this.specializedLb.Text = "Chuyên ngành";
            // 
            // specializedAutoCmp
            // 
            this.specializedAutoCmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.specializedAutoCmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.specializedAutoCmp.FormattingEnabled = true;
            this.specializedAutoCmp.Items.AddRange(new object[] {
            "Công nghệ phần mềm",
            "Hệ thống thông tin",
            "Mạng máy tính",
            "Hệ thống nhúng"});
            this.specializedAutoCmp.Location = new System.Drawing.Point(48, 105);
            this.specializedAutoCmp.Name = "specializedAutoCmp";
            this.specializedAutoCmp.Size = new System.Drawing.Size(198, 24);
            this.specializedAutoCmp.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Bằng 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Công tác";
            // 
            // firstDegreeTbx
            // 
            this.firstDegreeTbx.Location = new System.Drawing.Point(406, 75);
            this.firstDegreeTbx.Name = "firstDegreeTbx";
            this.firstDegreeTbx.Size = new System.Drawing.Size(139, 22);
            this.firstDegreeTbx.TabIndex = 14;
            // 
            // workPlaceTbx
            // 
            this.workPlaceTbx.Location = new System.Drawing.Point(406, 108);
            this.workPlaceTbx.Name = "workPlaceTbx";
            this.workPlaceTbx.Size = new System.Drawing.Size(139, 22);
            this.workPlaceTbx.TabIndex = 15;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(128, 363);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(67, 31);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.Location = new System.Drawing.Point(203, 363);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(67, 31);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "Sửa";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(281, 363);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(67, 31);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetBtn.Location = new System.Drawing.Point(847, 363);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(67, 31);
            this.resetBtn.TabIndex = 19;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // nameTbx
            // 
            this.nameTbx.Location = new System.Drawing.Point(294, 88);
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(211, 22);
            this.nameTbx.TabIndex = 21;
            // 
            // mssvTbx
            // 
            this.mssvTbx.Location = new System.Drawing.Point(293, 116);
            this.mssvTbx.Name = "mssvTbx";
            this.mssvTbx.Size = new System.Drawing.Size(211, 22);
            this.mssvTbx.TabIndex = 22;
            // 
            // addressTbx
            // 
            this.addressTbx.Location = new System.Drawing.Point(666, 88);
            this.addressTbx.Name = "addressTbx";
            this.addressTbx.Size = new System.Drawing.Size(211, 22);
            this.addressTbx.TabIndex = 23;
            // 
            // phoneNumberTbx
            // 
            this.phoneNumberTbx.Location = new System.Drawing.Point(666, 116);
            this.phoneNumberTbx.Name = "phoneNumberTbx";
            this.phoneNumberTbx.Size = new System.Drawing.Size(211, 22);
            this.phoneNumberTbx.TabIndex = 24;
            this.phoneNumberTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTbx_KeyPress);
            // 
            // dateOfBirthDTP
            // 
            this.dateOfBirthDTP.Location = new System.Drawing.Point(293, 144);
            this.dateOfBirthDTP.Name = "dateOfBirthDTP";
            this.dateOfBirthDTP.Size = new System.Drawing.Size(211, 22);
            this.dateOfBirthDTP.TabIndex = 26;
            // 
            // typeDegreeGbx
            // 
            this.typeDegreeGbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeDegreeGbx.Controls.Add(this.workPlaceTbx);
            this.typeDegreeGbx.Controls.Add(this.firstDegreeTbx);
            this.typeDegreeGbx.Controls.Add(this.label10);
            this.typeDegreeGbx.Controls.Add(this.label9);
            this.typeDegreeGbx.Controls.Add(this.specializedAutoCmp);
            this.typeDegreeGbx.Controls.Add(this.specializedLb);
            this.typeDegreeGbx.Controls.Add(this.collegeRBtn);
            this.typeDegreeGbx.Controls.Add(this.secondaryDegreeRBtn);
            this.typeDegreeGbx.Controls.Add(this.universityRBtn);
            this.typeDegreeGbx.Location = new System.Drawing.Point(128, 200);
            this.typeDegreeGbx.Name = "typeDegreeGbx";
            this.typeDegreeGbx.Size = new System.Drawing.Size(786, 157);
            this.typeDegreeGbx.TabIndex = 27;
            this.typeDegreeGbx.TabStop = false;
            this.typeDegreeGbx.Text = "Loại hình";
            // 
            // listStudentGbx
            // 
            this.listStudentGbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStudentGbx.Controls.Add(this.listStudentView);
            this.listStudentGbx.Location = new System.Drawing.Point(43, 417);
            this.listStudentGbx.Name = "listStudentGbx";
            this.listStudentGbx.Size = new System.Drawing.Size(988, 229);
            this.listStudentGbx.TabIndex = 28;
            this.listStudentGbx.TabStop = false;
            this.listStudentGbx.Text = "Danh sách sinh viên";
            // 
            // listStudentView
            // 
            this.listStudentView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.FullName,
            this.DateOfBirth,
            this.Address,
            this.PhoneNumber,
            this.SchoolYear,
            this.TypeDegree});
            this.listStudentView.HideSelection = false;
            this.listStudentView.Location = new System.Drawing.Point(19, 37);
            this.listStudentView.Name = "listStudentView";
            this.listStudentView.Size = new System.Drawing.Size(947, 175);
            this.listStudentView.TabIndex = 0;
            this.listStudentView.UseCompatibleStateImageBehavior = false;
            this.listStudentView.View = System.Windows.Forms.View.Details;
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            // 
            // FullName
            // 
            this.FullName.Text = "Họ tên";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Text = "Ngày sinh";
            // 
            // schoolYearNum
            // 
            this.schoolYearNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schoolYearNum.Location = new System.Drawing.Point(666, 147);
            this.schoolYearNum.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.schoolYearNum.Name = "schoolYearNum";
            this.schoolYearNum.Size = new System.Drawing.Size(211, 22);
            this.schoolYearNum.TabIndex = 29;
            this.schoolYearNum.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // Address
            // 
            this.Address.Text = "Địa chỉ";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Điện thoại";
            // 
            // SchoolYear
            // 
            this.SchoolYear.Text = "Niên khóa";
            // 
            // TypeDegree
            // 
            this.TypeDegree.Text = "Loại hình";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1060, 658);
            this.Controls.Add(this.schoolYearNum);
            this.Controls.Add(this.listStudentGbx);
            this.Controls.Add(this.typeDegreeGbx);
            this.Controls.Add(this.dateOfBirthDTP);
            this.Controls.Add(this.phoneNumberTbx);
            this.Controls.Add(this.addressTbx);
            this.Controls.Add(this.mssvTbx);
            this.Controls.Add(this.nameTbx);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.phoneNumberLb);
            this.Controls.Add(this.schoolYearLb);
            this.Controls.Add(this.addressLb);
            this.Controls.Add(this.dateOfBirthLb);
            this.Controls.Add(this.mssvLb);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.bigTitleLb);
            this.Name = "Form1";
            this.Text = "Quản lí thông tin sinh viên";
            this.typeDegreeGbx.ResumeLayout(false);
            this.typeDegreeGbx.PerformLayout();
            this.listStudentGbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schoolYearNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bigTitleLb;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label mssvLb;
        private System.Windows.Forms.Label dateOfBirthLb;
        private System.Windows.Forms.Label addressLb;
        private System.Windows.Forms.Label schoolYearLb;
        private System.Windows.Forms.Label phoneNumberLb;
        private System.Windows.Forms.RadioButton universityRBtn;
        private System.Windows.Forms.RadioButton secondaryDegreeRBtn;
        private System.Windows.Forms.RadioButton collegeRBtn;
        private System.Windows.Forms.Label specializedLb;
        private System.Windows.Forms.ComboBox specializedAutoCmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox firstDegreeTbx;
        private System.Windows.Forms.TextBox workPlaceTbx;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox nameTbx;
        private System.Windows.Forms.TextBox mssvTbx;
        private System.Windows.Forms.TextBox addressTbx;
        private System.Windows.Forms.TextBox phoneNumberTbx;
        private System.Windows.Forms.DateTimePicker dateOfBirthDTP;
        private System.Windows.Forms.GroupBox typeDegreeGbx;
        private System.Windows.Forms.GroupBox listStudentGbx;
        private System.Windows.Forms.NumericUpDown schoolYearNum;
        private ListView listStudentView;
        private ColumnHeader MSSV;
        private ColumnHeader FullName;
        private ColumnHeader DateOfBirth;
        private ColumnHeader Address;
        private ColumnHeader PhoneNumber;
        private ColumnHeader SchoolYear;
        private ColumnHeader TypeDegree;
    }
}

