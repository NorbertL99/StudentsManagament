// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me
                                                                                                                // References
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Students_Managament.DatabaseEF;                                                                           // This allow to use DatabaseEF namespace
using System.Data.Entity;                                                                                       // This allow to use Data.Entity namespace

namespace Students_Managament
{
    public partial class MainWindow : Form
    {
        students students = new students();                                                                     // Creating new object of students from SchoolDatabaseEF this object is a object using Entity Framework 6.0
        public MainWindow()                                                                                     // This method run when window open
        {
            InitializeComponent();                                                                              // Initialize components
        }

        private void addBT_Click(object sender, EventArgs e)                                                    // This method run when addBT clicked
        {
            try                                                                                                 // Holding errors
            {
                students.name = nameTB.Text.Trim();                                                             // Set value of name as a nameTB.Text
                students.surname = surnameTB.Text.Trim();                                                       // Set value of surname as a surnameTB.Text
                students.age = Convert.ToInt32(ageTB.Text.Trim());                                              // Set value of age as a ageTB.Text
                students.@class = classTB.Text.Trim();                                                          // Set value of class as a classTB.Text
                students.address = addressTB.Text.Trim();                                                       // Set value of address as a addressTB.Text
                using (SchoolDatabaseEntities schoolDatabase = new SchoolDatabaseEntities())                    // Create temporary object of SchoolDatabaseEntities
                {
                    schoolDatabase.students.Add(students);                                                      // Adding new created student to students table
                    schoolDatabase.SaveChanges();                                                               // Saving changes
                }
                clear();                                                                                        // Run clear method
                refreshDataGridView();                                                                          // Refreshing DataGridView with students
                MessageBox.Show("Inserting new record successfull !", "Entity Inforamtion",                     // Inform user about successfull inserting record
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                                          // Set buttons and icon for messagebox
            }
            catch (Exception exception)                                                                         // If some error become
            {
                MessageBox.Show("Error, contact system admin ! \n" + exception.ToString(), "Entity Error",      // Inform user about some error
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                                // Set buttons and icon for messagebox
            }
        }

        private void saveBT_Click(object sender, EventArgs e)                                                   // This method run when saveBT clicked
        {
            try                                                                                                 // Holding errors
            {
                students.name = nameTB.Text.Trim();                                                             // Set value of name as a nameTB.Text
                students.surname = surnameTB.Text.Trim();                                                       // Set value of surname as a surnameTB.Text
                students.age = Convert.ToInt32(ageTB.Text.Trim());                                              // Set value of age as a ageTB.Text
                students.@class = classTB.Text.Trim();                                                          // Set value of class as a classTB.Text
                students.address = addressTB.Text.Trim();                                                       // Set value of address as a addressTB.Text
                using (SchoolDatabaseEntities schoolDatabase = new SchoolDatabaseEntities())                    // Create temporary object of SchoolDatabaseEntities
                {
                    schoolDatabase.Entry(students).State = EntityState.Modified;                                // Modify the current record
                    schoolDatabase.SaveChanges();                                                               // Saving changes
                }
                clear();                                                                                        // Run clear method
                refreshDataGridView();                                                                          // Refreshing DataGridView with students
                MessageBox.Show("Updateing record successfull !", "Entity Inforamtion",                         // Inform user about successfull inserting record
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                                          // Set buttons and icon for messagebox
            }
            catch (Exception exception)                                                                         // If some error become
            {
                MessageBox.Show("Error, contact system admin ! \n" + exception.ToString(), "Entity Error",      // Inform user about some error
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                                // Set buttons and icon for messagebox
            }
        }

        private void deleteBT_Click(object sender, EventArgs e)                                                 // This method run when deleteBT clicked
        {
            try                                                                                                 // Holding errors
            {
                using (SchoolDatabaseEntities schoolDatabase = new SchoolDatabaseEntities())                    // Create temporary object of SchoolDatabaseEntities
                {
                    var entry = schoolDatabase.Entry(students);                                                 // This variable store information about current state of entry on object
                    if (entry.State == EntityState.Detached)                                                    // If state is detached
                    {
                        schoolDatabase.students.Attach(students);                                               // Ataching student object to table
                    }
                    schoolDatabase.students.Remove(students);                                                   // Removeing students object from table
                    schoolDatabase.SaveChanges();                                                               // Saveing changes
                    refreshDataGridView();                                                                      // Refreshing DataGridView with students
                    clear();                                                                                    // Run clear method
                }
                MessageBox.Show("Removeing record successfull !", "Entity Inforamtion",                         // Inform user about successfull inserting record
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                                          // Set buttons and icon for messagebox
            }
            catch (Exception exception)                                                                         // If some error become
            {
                MessageBox.Show("Error, contact system admin ! \n" + exception.ToString(), "Entity Error",      // Inform user about some error
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                                // Set buttons and icon for messagebox
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)                                                // This method run when window load
        {
            clear();                                                                                            // Run clear method
            refreshDataGridView();                                                                              // Refreshing DataGridView with students
        }

        private void studentsDataView_DoubleClick(object sender, EventArgs e)                                   // This method run after double click on some record
        {
            try                                                                                                 // Holding errors
            {
                if (studentsDataView.CurrentRow.Index != -1)
                {
                    students.id_s = Convert.ToInt32(studentsDataView.CurrentRow.Cells["id_s"].Value);
                    using (SchoolDatabaseEntities schoolDatabase = new SchoolDatabaseEntities())                // Create temporary object of SchoolDatabaseEntities
                    {
                        students = schoolDatabase.students.Where(x => x.id_s == students.id_s).FirstOrDefault();// Set students object values as values from row with was clicked
                        nameTB.Text = students.name;                                                            // Set textbox text with right value
                        surnameTB.Text = students.surname;                                                      // Set textbox text with right value
                        ageTB.Text = students.age.ToString();                                                   // Set textbox text with right value
                        classTB.Text = students.@class;                                                         // Set textbox text with right value
                        addressTB.Text = students.address;                                                      // Set textbox text with right value
                    }
                }
            }
            catch (Exception exception)                                                                         // If some error become
            {
                MessageBox.Show("Error, contact system admin ! \n" + exception.ToString(), "Entity Error",      // Inform user about some error
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                                // Set buttons and icon for messagebox
            }
        }

        void clear()                                                                                            // This method clearing everything
        {
            nameTB.Text = surnameTB.Text = ageTB.Text = classTB.Text = addressTB.Text = "";                     // Clearing TextBoxes
            students.id_s = 0;                                                                                  // Seting student id as 0
        }

        void refreshDataGridView()                                                                              // This method refrshing studentsDataView
        {
            try                                                                                                 // Holding errors
            {
                studentsDataView.AutoGenerateColumns = false;                                                   // Set auto generate colums as a false
                using (SchoolDatabaseEntities schoolDatabase = new SchoolDatabaseEntities())                    // Create temporary object of SchoolDatabaseEntities
                {
                    studentsDataView.DataSource = schoolDatabase.students.ToList<students>();                   // Set a data source of studentsDataView with table from SchoolDatabase
                }
            }
            catch(Exception exception)                                                                         // If some error become
            {
                MessageBox.Show("Error, contact system admin ! \n" + exception.ToString(), "Entity Error",      // Inform user about some error
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                                                // Set buttons and icon for messagebox
            }
        }
    }
}
