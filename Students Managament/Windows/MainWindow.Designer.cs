namespace Students_Managament
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.upSidePanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.studentsDataView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.classTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.addBT = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.deleteBT = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.id_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upSidePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // upSidePanel
            // 
            this.upSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.upSidePanel.Controls.Add(this.label1);
            this.upSidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upSidePanel.Location = new System.Drawing.Point(0, 0);
            this.upSidePanel.Name = "upSidePanel";
            this.upSidePanel.Size = new System.Drawing.Size(784, 70);
            this.upSidePanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Gray;
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.deleteBT);
            this.mainPanel.Controls.Add(this.saveBT);
            this.mainPanel.Controls.Add(this.addBT);
            this.mainPanel.Controls.Add(this.addressTB);
            this.mainPanel.Controls.Add(this.classTB);
            this.mainPanel.Controls.Add(this.ageTB);
            this.mainPanel.Controls.Add(this.surnameTB);
            this.mainPanel.Controls.Add(this.nameTB);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.studentsDataView);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 70);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 392);
            this.mainPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students Managament";
            // 
            // studentsDataView
            // 
            this.studentsDataView.AllowUserToDeleteRows = false;
            this.studentsDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_s,
            this.name,
            this.surname,
            this.age,
            this.clas,
            this.address});
            this.studentsDataView.Location = new System.Drawing.Point(3, 283);
            this.studentsDataView.Name = "studentsDataView";
            this.studentsDataView.ReadOnly = true;
            this.studentsDataView.Size = new System.Drawing.Size(778, 106);
            this.studentsDataView.TabIndex = 0;
            this.studentsDataView.DoubleClick += new System.EventHandler(this.studentsDataView_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(52, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(79, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(56, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(23, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTB.Location = new System.Drawing.Point(151, 23);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(221, 29);
            this.nameTB.TabIndex = 6;
            // 
            // surnameTB
            // 
            this.surnameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surnameTB.Location = new System.Drawing.Point(151, 72);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(221, 29);
            this.surnameTB.TabIndex = 7;
            // 
            // ageTB
            // 
            this.ageTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageTB.Location = new System.Drawing.Point(151, 126);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(221, 29);
            this.ageTB.TabIndex = 8;
            // 
            // classTB
            // 
            this.classTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classTB.Location = new System.Drawing.Point(151, 180);
            this.classTB.Name = "classTB";
            this.classTB.Size = new System.Drawing.Size(221, 29);
            this.classTB.TabIndex = 9;
            // 
            // addressTB
            // 
            this.addressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressTB.Location = new System.Drawing.Point(151, 235);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(221, 29);
            this.addressTB.TabIndex = 10;
            // 
            // addBT
            // 
            this.addBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addBT.Location = new System.Drawing.Point(456, 61);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(273, 40);
            this.addBT.TabIndex = 15;
            this.addBT.Text = "Add";
            this.addBT.UseVisualStyleBackColor = true;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // saveBT
            // 
            this.saveBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveBT.Location = new System.Drawing.Point(456, 126);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(273, 40);
            this.saveBT.TabIndex = 16;
            this.saveBT.Text = "Save";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // deleteBT
            // 
            this.deleteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deleteBT.Location = new System.Drawing.Point(456, 190);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(273, 40);
            this.deleteBT.TabIndex = 17;
            this.deleteBT.Text = "Delete";
            this.deleteBT.UseVisualStyleBackColor = true;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(450, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 33);
            this.label8.TabIndex = 18;
            this.label8.Text = "Operations on record";
            // 
            // id_s
            // 
            this.id_s.DataPropertyName = "id_s";
            this.id_s.HeaderText = "id_s";
            this.id_s.Name = "id_s";
            this.id_s.ReadOnly = true;
            this.id_s.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 122;
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "surname";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 122;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 70;
            // 
            // clas
            // 
            this.clas.DataPropertyName = "class";
            this.clas.HeaderText = "clas";
            this.clas.Name = "clas";
            this.clas.ReadOnly = true;
            this.clas.Width = 70;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 350;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.upSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Students Managament";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.upSidePanel.ResumeLayout(false);
            this.upSidePanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upSidePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteBT;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Button addBT;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox classTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView studentsDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn clas;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}

