
namespace CRUD_System
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
            this.ctrlName = new System.Windows.Forms.TextBox();
            this.ctrlLastname = new System.Windows.Forms.TextBox();
            this.ctrlAge = new System.Windows.Forms.TextBox();
            this.ctrlAddress = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.ctrlBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.grvDetailsData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetailsData)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(98, 71);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(148, 20);
            this.ctrlName.TabIndex = 0;
            // 
            // ctrlLastname
            // 
            this.ctrlLastname.Location = new System.Drawing.Point(98, 125);
            this.ctrlLastname.Name = "ctrlLastname";
            this.ctrlLastname.Size = new System.Drawing.Size(148, 20);
            this.ctrlLastname.TabIndex = 1;
            // 
            // ctrlAge
            // 
            this.ctrlAge.Location = new System.Drawing.Point(98, 186);
            this.ctrlAge.Name = "ctrlAge";
            this.ctrlAge.Size = new System.Drawing.Size(148, 20);
            this.ctrlAge.TabIndex = 2;
            // 
            // ctrlAddress
            // 
            this.ctrlAddress.Location = new System.Drawing.Point(98, 239);
            this.ctrlAddress.Name = "ctrlAddress";
            this.ctrlAddress.Size = new System.Drawing.Size(148, 20);
            this.ctrlAddress.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(25, 74);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(25, 132);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(53, 13);
            this.labelLastname.TabIndex = 5;
            this.labelLastname.Text = "Lastname";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(25, 193);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Age";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(25, 246);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "Address";
            // 
            // ctrlBirthday
            // 
            this.ctrlBirthday.Location = new System.Drawing.Point(98, 302);
            this.ctrlBirthday.Name = "ctrlBirthday";
            this.ctrlBirthday.Size = new System.Drawing.Size(148, 20);
            this.ctrlBirthday.TabIndex = 8;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(25, 309);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(45, 13);
            this.labelBirthday.TabIndex = 9;
            this.labelBirthday.Text = "Birthday";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(351, 67);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(351, 122);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // grvDetailsData
            // 
            this.grvDetailsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDetailsData.Location = new System.Drawing.Point(5, 361);
            this.grvDetailsData.Name = "grvDetailsData";
            this.grvDetailsData.Size = new System.Drawing.Size(735, 229);
            this.grvDetailsData.TabIndex = 13;
            this.grvDetailsData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDetailsData_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 602);
            this.Controls.Add(this.grvDetailsData);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.ctrlBirthday);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.ctrlAddress);
            this.Controls.Add(this.ctrlAge);
            this.Controls.Add(this.ctrlLastname);
            this.Controls.Add(this.ctrlName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDetailsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctrlName;
        private System.Windows.Forms.TextBox ctrlLastname;
        private System.Windows.Forms.TextBox ctrlAge;
        private System.Windows.Forms.TextBox ctrlAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.DateTimePicker ctrlBirthday;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView grvDetailsData;
    }
}

