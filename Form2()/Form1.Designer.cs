namespace Form2__
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lstStudents = new ListBox();
            BtnAdd = new Button();
            BtnSave = new Button();
            BtnDel = new Button();
            cmbSearch = new ComboBox();
            bindingSource1 = new BindingSource(components);
            txtSearch = new TextBox();
            BtnSearch = new Button();
            BtnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(400, 12);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(403, 394);
            lstStudents.TabIndex = 0;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(12, 32);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(104, 23);
            BtnAdd.TabIndex = 1;
            BtnAdd.Text = "Добавить";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(12, 71);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(104, 23);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "Сохранить";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnDel
            // 
            BtnDel.Location = new Point(15, 117);
            BtnDel.Name = "BtnDel";
            BtnDel.Size = new Size(101, 23);
            BtnDel.TabIndex = 3;
            BtnDel.Text = "Удалить";
            BtnDel.UseVisualStyleBackColor = true;
            BtnDel.Click += BtnDel_Click;
            // 
            // cmbSearch
            // 
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Location = new Point(12, 199);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(121, 23);
            cmbSearch.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(11, 239);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(122, 23);
            txtSearch.TabIndex = 5;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(15, 282);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 23);
            BtnSearch.TabIndex = 6;
            BtnSearch.Text = "Поиск";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnReset
            // 
            BtnReset.Location = new Point(15, 311);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(75, 23);
            BtnReset.TabIndex = 7;
            BtnReset.Text = "Сброс";
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(BtnReset);
            Controls.Add(BtnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cmbSearch);
            Controls.Add(BtnDel);
            Controls.Add(BtnSave);
            Controls.Add(BtnAdd);
            Controls.Add(lstStudents);
            Name = "Form1";
            Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstStudents;
        private Button BtnAdd;
        private Button BtnSave;
        private Button BtnDel;
        private ComboBox cmbSearch;
        private BindingSource bindingSource1;
        private TextBox txtSearch;
        private Button BtnSearch;
        private Button BtnReset;
    }
}
