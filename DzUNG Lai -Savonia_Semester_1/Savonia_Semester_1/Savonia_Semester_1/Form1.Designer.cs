namespace Savonia_Semester_1
{
    partial class personalDataForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_PersonData = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spring_Semester_DatabaseDataSet = new Savonia_Semester_1.Spring_Semester_DatabaseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_NameTable = new System.Windows.Forms.Label();
            this.TBoxFirstName = new System.Windows.Forms.TextBox();
            this.TBoxFamilyName = new System.Windows.Forms.TextBox();
            this.TBoxPlaceOfBirth = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DOB = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonFemale = new System.Windows.Forms.RadioButton();
            this.ButtonMale = new System.Windows.Forms.RadioButton();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_DOB = new System.Windows.Forms.Label();
            this.label_POB = new System.Windows.Forms.Label();
            this.label_FamilyName = new System.Windows.Forms.Label();
            this.Lb_SearchByName = new System.Windows.Forms.Label();
            this.TBox_Searching = new System.Windows.Forms.TextBox();
            this.tableTableAdapter = new Savonia_Semester_1.Spring_Semester_DatabaseDataSetTableAdapters.TableTableAdapter();
            this.Button_Search = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.Button_Clear = new Project_Final_Semester2019.RoundConerButton();
            this.buttonUpdate = new Project_Final_Semester2019.RoundConerButton();
            this.Button_Del = new Project_Final_Semester2019.RoundConerButton();
            this.Button_Static = new Project_Final_Semester2019.RoundConerButton();
            this.Button_Exit = new Project_Final_Semester2019.RoundConerButton();
            this.Button_Save = new Project_Final_Semester2019.RoundConerButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PersonData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spring_Semester_DatabaseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_PersonData
            // 
            this.dataGridView_PersonData.AutoGenerateColumns = false;
            this.dataGridView_PersonData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PersonData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.pOBDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView_PersonData.DataSource = this.tableBindingSource;
            this.dataGridView_PersonData.Location = new System.Drawing.Point(311, 116);
            this.dataGridView_PersonData.Name = "dataGridView_PersonData";
            this.dataGridView_PersonData.Size = new System.Drawing.Size(550, 325);
            this.dataGridView_PersonData.TabIndex = 0;
            this.dataGridView_PersonData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PersonData_CellContentClick);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // pOBDataGridViewTextBoxColumn
            // 
            this.pOBDataGridViewTextBoxColumn.DataPropertyName = "POB";
            this.pOBDataGridViewTextBoxColumn.HeaderText = "POB";
            this.pOBDataGridViewTextBoxColumn.Name = "pOBDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.spring_Semester_DatabaseDataSet;
            // 
            // spring_Semester_DatabaseDataSet
            // 
            this.spring_Semester_DatabaseDataSet.DataSetName = "Spring_Semester_DatabaseDataSet";
            this.spring_Semester_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.Label_NameTable);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 90);
            this.panel1.TabIndex = 1;
            // 
            // Label_NameTable
            // 
            this.Label_NameTable.AutoSize = true;
            this.Label_NameTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NameTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label_NameTable.Location = new System.Drawing.Point(238, 32);
            this.Label_NameTable.Name = "Label_NameTable";
            this.Label_NameTable.Size = new System.Drawing.Size(412, 29);
            this.Label_NameTable.TabIndex = 17;
            this.Label_NameTable.Text = "PERSONAL INFORMATION DATA";
            // 
            // TBoxFirstName
            // 
            this.TBoxFirstName.Location = new System.Drawing.Point(28, 136);
            this.TBoxFirstName.Name = "TBoxFirstName";
            this.TBoxFirstName.Size = new System.Drawing.Size(250, 20);
            this.TBoxFirstName.TabIndex = 2;
            // 
            // TBoxFamilyName
            // 
            this.TBoxFamilyName.Location = new System.Drawing.Point(28, 186);
            this.TBoxFamilyName.Name = "TBoxFamilyName";
            this.TBoxFamilyName.Size = new System.Drawing.Size(250, 20);
            this.TBoxFamilyName.TabIndex = 3;
            // 
            // TBoxPlaceOfBirth
            // 
            this.TBoxPlaceOfBirth.Location = new System.Drawing.Point(28, 286);
            this.TBoxPlaceOfBirth.Name = "TBoxPlaceOfBirth";
            this.TBoxPlaceOfBirth.Size = new System.Drawing.Size(250, 20);
            this.TBoxPlaceOfBirth.TabIndex = 4;
            // 
            // dateTimePicker_DOB
            // 
            this.dateTimePicker_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DOB.Location = new System.Drawing.Point(28, 236);
            this.dateTimePicker_DOB.Name = "dateTimePicker_DOB";
            this.dateTimePicker_DOB.Size = new System.Drawing.Size(250, 20);
            this.dateTimePicker_DOB.TabIndex = 5;
            this.dateTimePicker_DOB.Value = new System.DateTime(2020, 4, 30, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonFemale);
            this.groupBox1.Controls.Add(this.ButtonMale);
            this.groupBox1.Location = new System.Drawing.Point(28, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 45);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // ButtonFemale
            // 
            this.ButtonFemale.AutoSize = true;
            this.ButtonFemale.Location = new System.Drawing.Point(140, 19);
            this.ButtonFemale.Name = "ButtonFemale";
            this.ButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.ButtonFemale.TabIndex = 1;
            this.ButtonFemale.TabStop = true;
            this.ButtonFemale.Text = "Female";
            this.ButtonFemale.UseVisualStyleBackColor = true;
            // 
            // ButtonMale
            // 
            this.ButtonMale.AutoSize = true;
            this.ButtonMale.Location = new System.Drawing.Point(26, 19);
            this.ButtonMale.Name = "ButtonMale";
            this.ButtonMale.Size = new System.Drawing.Size(48, 17);
            this.ButtonMale.TabIndex = 0;
            this.ButtonMale.TabStop = true;
            this.ButtonMale.Text = "Male";
            this.ButtonMale.UseVisualStyleBackColor = true;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(28, 116);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(57, 13);
            this.label_FirstName.TabIndex = 13;
            this.label_FirstName.Text = "First Name";
            // 
            // label_DOB
            // 
            this.label_DOB.AutoSize = true;
            this.label_DOB.Location = new System.Drawing.Point(28, 216);
            this.label_DOB.Name = "label_DOB";
            this.label_DOB.Size = new System.Drawing.Size(68, 13);
            this.label_DOB.TabIndex = 14;
            this.label_DOB.Text = "Date Of Birth";
            // 
            // label_POB
            // 
            this.label_POB.AutoSize = true;
            this.label_POB.Location = new System.Drawing.Point(28, 266);
            this.label_POB.Name = "label_POB";
            this.label_POB.Size = new System.Drawing.Size(72, 13);
            this.label_POB.TabIndex = 15;
            this.label_POB.Text = "Place Of Birth";
            // 
            // label_FamilyName
            // 
            this.label_FamilyName.AutoSize = true;
            this.label_FamilyName.Location = new System.Drawing.Point(28, 166);
            this.label_FamilyName.Name = "label_FamilyName";
            this.label_FamilyName.Size = new System.Drawing.Size(67, 13);
            this.label_FamilyName.TabIndex = 18;
            this.label_FamilyName.Text = "Family Name";
            // 
            // Lb_SearchByName
            // 
            this.Lb_SearchByName.AutoSize = true;
            this.Lb_SearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_SearchByName.Location = new System.Drawing.Point(309, 467);
            this.Lb_SearchByName.Name = "Lb_SearchByName";
            this.Lb_SearchByName.Size = new System.Drawing.Size(238, 40);
            this.Lb_SearchByName.TabIndex = 17;
            this.Lb_SearchByName.Text = "Search Personal Information\nBy First Name";
            // 
            // TBox_Searching
            // 
            this.TBox_Searching.Location = new System.Drawing.Point(574, 467);
            this.TBox_Searching.Name = "TBox_Searching";
            this.TBox_Searching.Size = new System.Drawing.Size(287, 20);
            this.TBox_Searching.TabIndex = 20;
            this.TBox_Searching.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBox_Searching_KeyDown);
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(574, 501);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(135, 22);
            this.Button_Search.TabIndex = 21;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(726, 501);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(135, 22);
            this.button_Back.TabIndex = 22;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear._OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.Button_Clear.BoderColor = System.Drawing.Color.Silver;
            this.Button_Clear.ButtonColor = System.Drawing.Color.Red;
            this.Button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Clear.Location = new System.Drawing.Point(169, 391);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.onHoverColorBoder = System.Drawing.Color.Gray;
            this.Button_Clear.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Button_Clear.Size = new System.Drawing.Size(90, 30);
            this.Button_Clear.TabIndex = 12;
            this.Button_Clear.Text = "CLEAR FIELD";
            this.Button_Clear.TextColor = System.Drawing.Color.White;
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate._OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.buttonUpdate.BoderColor = System.Drawing.Color.Silver;
            this.buttonUpdate.ButtonColor = System.Drawing.Color.Red;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(43, 442);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.onHoverColorBoder = System.Drawing.Color.Gray;
            this.buttonUpdate.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttonUpdate.Size = new System.Drawing.Size(90, 30);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.TextColor = System.Drawing.Color.White;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Button_Del
            // 
            this.Button_Del._OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.Button_Del.BoderColor = System.Drawing.Color.Silver;
            this.Button_Del.ButtonColor = System.Drawing.Color.Red;
            this.Button_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Del.Location = new System.Drawing.Point(169, 442);
            this.Button_Del.Name = "Button_Del";
            this.Button_Del.onHoverColorBoder = System.Drawing.Color.Gray;
            this.Button_Del.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Button_Del.Size = new System.Drawing.Size(90, 30);
            this.Button_Del.TabIndex = 10;
            this.Button_Del.Text = "DELETE";
            this.Button_Del.TextColor = System.Drawing.Color.White;
            this.Button_Del.UseVisualStyleBackColor = true;
            this.Button_Del.Click += new System.EventHandler(this.Button_Del_Click);
            // 
            // Button_Static
            // 
            this.Button_Static._OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.Button_Static.BoderColor = System.Drawing.Color.Silver;
            this.Button_Static.ButtonColor = System.Drawing.Color.Red;
            this.Button_Static.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Static.Location = new System.Drawing.Point(43, 493);
            this.Button_Static.Name = "Button_Static";
            this.Button_Static.onHoverColorBoder = System.Drawing.Color.Gray;
            this.Button_Static.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Button_Static.Size = new System.Drawing.Size(90, 30);
            this.Button_Static.TabIndex = 9;
            this.Button_Static.Text = "STATIC";
            this.Button_Static.TextColor = System.Drawing.Color.White;
            this.Button_Static.UseVisualStyleBackColor = true;
            this.Button_Static.Click += new System.EventHandler(this.Button_Static_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit._OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.Button_Exit.BoderColor = System.Drawing.Color.Silver;
            this.Button_Exit.ButtonColor = System.Drawing.Color.Red;
            this.Button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit.Location = new System.Drawing.Point(168, 493);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.onHoverColorBoder = System.Drawing.Color.Gray;
            this.Button_Exit.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Button_Exit.Size = new System.Drawing.Size(90, 30);
            this.Button_Exit.TabIndex = 8;
            this.Button_Exit.Text = "EXIT";
            this.Button_Exit.TextColor = System.Drawing.Color.White;
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click_1);
            // 
            // Button_Save
            // 
            this.Button_Save._OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.Button_Save.BoderColor = System.Drawing.Color.Silver;
            this.Button_Save.ButtonColor = System.Drawing.Color.Red;
            this.Button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save.Location = new System.Drawing.Point(43, 391);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.onHoverColorBoder = System.Drawing.Color.Gray;
            this.Button_Save.OnHoverTextColor = System.Drawing.Color.Gray;
            this.Button_Save.Size = new System.Drawing.Size(90, 30);
            this.Button_Save.TabIndex = 7;
            this.Button_Save.Text = "SAVE";
            this.Button_Save.TextColor = System.Drawing.Color.White;
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click_1);
            // 
            // personalDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 548);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.TBox_Searching);
            this.Controls.Add(this.Lb_SearchByName);
            this.Controls.Add(this.label_FamilyName);
            this.Controls.Add(this.label_POB);
            this.Controls.Add(this.label_DOB);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.Button_Del);
            this.Controls.Add(this.Button_Static);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker_DOB);
            this.Controls.Add(this.TBoxPlaceOfBirth);
            this.Controls.Add(this.TBoxFamilyName);
            this.Controls.Add(this.TBoxFirstName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_PersonData);
            this.Name = "personalDataForm";
            this.Text = "Personal Data Form";
            this.Load += new System.EventHandler(this.personalDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PersonData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spring_Semester_DatabaseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_PersonData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBoxFirstName;
        private System.Windows.Forms.TextBox TBoxFamilyName;
        private System.Windows.Forms.TextBox TBoxPlaceOfBirth;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DOB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ButtonFemale;
        private System.Windows.Forms.RadioButton ButtonMale;
        private System.Windows.Forms.Label Label_NameTable;
        private Project_Final_Semester2019.RoundConerButton Button_Save;
        private Project_Final_Semester2019.RoundConerButton Button_Exit;
        private Project_Final_Semester2019.RoundConerButton Button_Static;
        private Project_Final_Semester2019.RoundConerButton Button_Del;
        private Project_Final_Semester2019.RoundConerButton buttonUpdate;
        private Project_Final_Semester2019.RoundConerButton Button_Clear;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_DOB;
        private System.Windows.Forms.Label label_POB;
        private System.Windows.Forms.Label label_FamilyName;
        private System.Windows.Forms.Label Lb_SearchByName;
        private System.Windows.Forms.TextBox TBox_Searching;
        private Spring_Semester_DatabaseDataSet spring_Semester_DatabaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Spring_Semester_DatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.Button button_Back;
    }
}

