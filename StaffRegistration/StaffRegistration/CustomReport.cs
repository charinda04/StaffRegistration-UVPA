using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffRegistration
{
    class CustomReport
    {

        Connection conn = new Connection();

        public void populateTreeView(ref TreeView trVwFaculty, ref TreeView trVwDesignation, ref TreeView trVwDepartment)
        {
            try
            {
                trVwFaculty.Nodes.Clear();
                trVwDesignation.Nodes.Clear();
                trVwDepartment.Nodes.Clear();


                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `faculty`", conn.connConnection());


                conn.connOpen();
                conn.connConnection();


                MySqlDataReader reader1;


                reader1 = cmd.ExecuteReader();
                TreeNode node = new TreeNode("Faculty Name");
                while (reader1.Read())
                {
                    //if(count == 0)


                    node.Nodes.Add(reader1["Faculty Name"].ToString());


                }
                trVwFaculty.Nodes.Add(node);
                trVwFaculty.CheckBoxes = true;
                reader1.Close();


                cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `department`", conn.connConnection());


                conn.connOpen();
                conn.connConnection();





                reader1 = cmd.ExecuteReader();
                TreeNode node1 = new TreeNode("Department Name");
                while (reader1.Read())
                {
                    //if(count == 0)


                    node1.Nodes.Add(reader1["Department Name"].ToString());


                }
                trVwDepartment.Nodes.Add(node1);
                trVwDepartment.CheckBoxes = true;
                reader1.Close();

                cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `designations`", conn.connConnection());


                conn.connOpen();
                conn.connConnection();





                reader1 = cmd.ExecuteReader();
                TreeNode node2 = new TreeNode("Designation");
                while (reader1.Read())
                {
                    //if(count == 0)


                    node2.Nodes.Add(reader1["Designation"].ToString());


                }
                trVwDesignation.Nodes.Add(node2);
                trVwDesignation.CheckBoxes = true;



                reader1.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Updates all child tree nodes recursively.
        public void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }


        public void populateCheckListBox(ref CheckedListBox designations, ref CheckedListBox faculty, ref CheckedListBox department, ref CheckedListBox leave, ref CheckedListBox salarycode, ref CheckedListBox salaryscale)
        {
            try
            {

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `faculty`", conn.connConnection());


                conn.connOpen();
                conn.connConnection();


                MySqlDataReader reader1;


                reader1 = cmd.ExecuteReader();

                while (reader1.Read())
                {
                    //if(count == 0)


                    faculty.Items.Add(reader1["Faculty Name"].ToString());


                }

                reader1.Close();


                cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `department`", conn.connConnection());


                conn.connOpen();
                conn.connConnection();





                reader1 = cmd.ExecuteReader();

                while (reader1.Read())
                {
                    //if(count == 0)


                    department.Items.Add(reader1["Department Name"].ToString());


                }

                reader1.Close();

                cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `designations`", conn.connConnection());


                conn.connOpen();
                conn.connConnection();





                reader1 = cmd.ExecuteReader();
               // TreeNode node2 = new TreeNode("Designation");
                while (reader1.Read())
                {
                    //if(count == 0)


                    designations.Items.Add(reader1["Designation"].ToString());


                }




                reader1.Close();

                cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `leavetype`", conn.connConnection());


                conn.connOpen();
                conn.connConnection();


                leave.Items.Clear();


                reader1 = cmd.ExecuteReader();
                //TreeNode node2 = new TreeNode("Designation");
                while (reader1.Read())
                {
                    //if(count == 0)


                    leave.Items.Add(reader1["Leave Type"].ToString());


                }




                reader1.Close();

                cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `salarycode`", conn.connConnection());


                conn.connOpen();
                conn.connConnection();





                reader1 = cmd.ExecuteReader();
                //TreeNode node2 = new TreeNode("Designation");
                while (reader1.Read())
                {
                    //if(count == 0)


                    salarycode.Items.Add(reader1["Salary Code"].ToString());


                }




                reader1.Close();

                cmd = conn.connConnection().CreateCommand();
                cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM `salaryscale`", conn.connConnection());


                conn.connOpen();
                conn.connConnection();





                reader1 = cmd.ExecuteReader();
                //TreeNode node2 = new TreeNode("Designation");
                while (reader1.Read())
                {
                    //if(count == 0)


                    salaryscale.Items.Add(reader1["Salary Scale"].ToString());


                }




                reader1.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
        public void loadReportTable(CheckedListBox chkLBxPersonal, CheckedListBox chkLBxFamily, CheckedListBox chkLBxEducational, CheckedListBox chkLBxService, CheckedListBox chkLBxOtherPositions, DataGridView tblReport,
            CheckedListBox chkLBAddress, CheckedListBox chkLBFaculty, CheckedListBox chkLBSalaryScale, CheckedListBox chkLBSalaryCode, CheckedListBox chkLBDesignation, CheckedListBox chkLBLeave, CheckedListBox chkLBDepartment, CheckedListBox chkLtBxLeaveCategory)
        {
            try
            {
                string query = "SELECT DISTINCT ";
                int wherecount = 0;

                foreach (object itemChecked in chkLBxPersonal.CheckedItems)
                {
                    query += "`AcademicStaff`.`" + itemChecked.ToString() + "`" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }

                foreach (object itemChecked in chkLBxFamily.CheckedItems)
                {
                    query += "`ChildrenDetail`.`" + itemChecked.ToString() + "`" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }

                foreach (object itemChecked in chkLBxEducational.CheckedItems)
                {
                    query += "`educationalqulifications`.`" + itemChecked.ToString() + "`" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }

                foreach (object itemChecked in chkLBxService.CheckedItems)
                {
                    query += "`servicerecords`.`" + itemChecked.ToString() + "`" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }

                foreach (object itemChecked in chkLBxOtherPositions.CheckedItems)
                {
                    query += "`OtherPositions`.`" + itemChecked.ToString() + "`" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }
                foreach (object itemChecked in chkLBAddress.CheckedItems)
                {
                    query += "`Address`.`" + itemChecked.ToString() + "`" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }
               
               
               
                foreach (object itemChecked in chkLBLeave.CheckedItems)
                {
                    query += "`leave`.`" + itemChecked.ToString() + "`" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }
                
                

                query = query.Substring(0, query.Length - 1);
                query += " FROM academicstaff  ";

                if (chkLBxFamily.CheckedItems.Count>0)
                    query += ",childrendetail ";
                if (chkLBxOtherPositions.CheckedItems.Count > 0)
                    query += ",otherpositions ";
                if (chkLBxEducational.CheckedItems.Count > 0)
                    query += ",educationalqulifications ";
                if (chkLBxService.CheckedItems.Count > 0)
                    query += ",servicerecords ";
                if (chkLBSalaryCode.CheckedItems.Count > 0)
                {
                    query += ",salarycode ";
                    
                }
                if (chkLBSalaryScale.CheckedItems.Count > 0)
                {
                    query += ",salaryscale ";
                }

                

                if (chkLBDesignation.CheckedItems.Count > 0)
                {
                    query += ",designations ";
                }

                if (chkLBDepartment.CheckedItems.Count > 0 || chkLBFaculty.CheckedItems.Count > 0)
                {
                    query += ",department ";
                }

                if (chkLtBxLeaveCategory.CheckedItems.Count > 0)
                {
                    query += ",leavetype ";
                    
                }


                if (chkLBFaculty.CheckedItems.Count > 0)
                {
                    query += ",faculty ";
                    
                }

                if (chkLBAddress.CheckedItems.Count > 0)
                    query += ",address ";

                if (chkLBLeave.CheckedItems.Count > 0 || chkLtBxLeaveCategory.CheckedItems.Count > 0)
                {
                    query += ",`leave` ";
                }


                if (chkLBxFamily.CheckedItems.Count > 0 || chkLBxOtherPositions.CheckedItems.Count > 0 || chkLBxEducational.CheckedItems.Count > 0 || chkLBxService.CheckedItems.Count > 0 ||
                     chkLBLeave.CheckedItems.Count > 0 || chkLBAddress.CheckedItems.Count > 0 || chkLtBxLeaveCategory.CheckedItems.Count > 0 || chkLBFaculty.CheckedItems.Count > 0)
                {
                    query += "WHERE ";
                    
                }


                if (chkLBxFamily.CheckedItems.Count > 0)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`AcademicStaff`.`NIC` = `ChildrenDetail`.`NIC` ";
                    
                }
                if (chkLBxOtherPositions.CheckedItems.Count > 0)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`AcademicStaff`.`NIC` = `OtherPositions`.`NIC` ";
                }
                if (chkLBxEducational.CheckedItems.Count > 0)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`AcademicStaff`.`NIC` = `EducationalQulifications`.`NIC` ";
                }
                if (chkLBxService.CheckedItems.Count > 0)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`AcademicStaff`.`NIC` = `ServiceRecords`.`NIC` ";
                }
                if (chkLBSalaryCode.CheckedItems.Count > 0)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`AcademicStaff`.`Salary Scale` = `salaryscale`.`Salary Scale` ";
                    query += "AND `salaryscale`.`Salary Code` = `salarycode`.`Salary Code` ";
                }
                if (chkLBSalaryScale.CheckedItems.Count > 0)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`AcademicStaff`.`Salary Scale` = `salaryscale`.`Salary Scale` ";
                }

                if (chkLBLeave.CheckedItems.Count > 0)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`academicstaff`.`NIC` = `leave`.`NIC` ";
                }

                if (chkLBDesignation.CheckedItems.Count > 0)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`academicstaff`.`Designation` = `designations`.`Designation` ";
                }

                if (chkLBDepartment.CheckedItems.Count > 0)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`academicstaff`.`Department Name` = `department`.`Department Name` ";
                }

                if (chkLtBxLeaveCategory.CheckedItems.Count > 0)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`AcademicStaff`.`NIC` = `leave`.`NIC` ";
                    //query += "AND `leave`.`Leave Type` = `leavetype`.`Leave Type` ";
                }


                if (chkLBFaculty.CheckedItems.Count > 0)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`AcademicStaff`.`Department Name` = `Department`.`Department Name` ";
                    //query += "AND `department`.`Faculty Name` = `faculty`.`Faculty Name` ";
                }

                if (chkLBAddress.CheckedItems.Count > 0)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`AcademicStaff`.`NIC` = `Address`.`NIC` ";
                }


                foreach (object itemChecked in chkLBDepartment.CheckedItems)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "WHERE `Department Name` = "+ itemChecked.ToString() +" ";
                   // query += "`SalaryScale`.`" + itemChecked.ToString() + "`" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }
                foreach (object itemChecked in chkLtBxLeaveCategory.CheckedItems)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`leave`.`Leave Category` = " + itemChecked.ToString() +" ";
                    //query += "`leavetype`.`" + itemChecked.ToString() + "`" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }

                foreach (object itemChecked in chkLBDesignation.CheckedItems)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "WHERE `Designation` = " + itemChecked.ToString() + " ";
                   // query += "`designations`.`" + itemChecked.ToString() + "`" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }

                foreach (object itemChecked in chkLBSalaryCode.CheckedItems)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "WHERE `Salary Code` = " + itemChecked.ToString() + " ";
                    //query += "`salarycode`.`" + itemChecked.ToString() + "`" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }

                foreach (object itemChecked in chkLBFaculty.CheckedItems)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "`department`.`Faculty Name` = " + itemChecked.ToString() + " ";
                    //query += "`Department`.`" + itemChecked.ToString() + "`" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }
                foreach (object itemChecked in chkLBSalaryScale.CheckedItems)
                {
                    if (wherecount != 0)
                    {
                        query += "AND ";
                    }
                    wherecount++;
                    query += "WHERE `Salary Scale` = " + itemChecked.ToString() + " ";
                    //query += "`salaryscale`.`" + itemChecked.ToString() + "`" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }

                //MessageBox.Show(query);
                //Console.WriteLine(query);

                conn.connOpen();
                conn.connConnection();

                MySqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new MySqlCommand(query, conn.connConnection());
                //cmd.Parameters.AddWithValue("@1", txtSearchName);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblReport.DataSource = table;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


            


        /* private void PopulateRows()
         {
             for (int i = 1; i <= 10; i++)
             {
                 DataGridViewRow row =
                     (DataGridViewRow)dgvCityDetails.RowTemplate.Clone();

                 row.CreateCells(dgvCityDetails, string.Format("City{0}", i),
                     string.Format("State{0}", i), string.Format("Country{0}", i));

                 dgvCityDetails.Rows.Add(row);

             }
         }
         */

            
        /// <summary> 
        /// Exports the datagridview values to Excel. 
        /// </summary> 
        public void ExportToExcel(DataGridView tblReport, String txtHeader, String Date)
        {

            String path = null;
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            Microsoft.Office.Interop.Excel.Range myCells;

            // try
            {
                //excel.Workbooks.Open("C:\\Users\\Charinda\\AcademicStaffRegistration\\Staff Registration System - Copy\\Staff Registration System\bin\\Debug\\Test.xlsx");
                // excel.Visible = true;

                //workbook = excel.Worksheets.Item[1];


                int rowCount = 0;
                worksheet = workbook.ActiveSheet;

                myCells = worksheet.Cells;

                worksheet.Name = "Report";

                int cellRowIndex = 4;
                int cellColumnIndex = 1;

                myCells.Item[1, "A"].value = txtHeader;
                myCells.Item[2, "A"].value = Date;


                //Loop through each row and read value from each column. 
                for (int i = 0, index = 1; i < tblReport.Rows.Count;)
                {
                    char z = 'A';
                    char y = 'A';
                    char x = 'A';
                    //MessageBox.Show(tblReport.Rows.Count.ToString());
                    for (int j = 0; j < tblReport.Columns.Count; j++)
                    {

                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 4)
                        {

                            myCells.Range[z.ToString() + "" + cellRowIndex.ToString() + ":" + z.ToString() + "" + cellRowIndex.ToString()].Font.Bold = true;
                            //myCells.Range["A1:A1"].Font.Bold = true;
                            //MessageBox.Show(z.ToString() + "" + i.ToString() + ":" + z.ToString() + "" + i.ToString());
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = tblReport.Columns[j].HeaderText;
                            myCells.Range[z.ToString() + "" + cellRowIndex.ToString() + ":" + z.ToString() + "" + cellRowIndex.ToString()].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                            // myCells.Range[z.ToString() + "" + cellRowIndex.ToString() + ":" + z.ToString() + "" + cellRowIndex.ToString()].AutoFit();
                            z++;

                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = tblReport.Rows[i].Cells[j].Value.ToString();
                            myCells.Range[y.ToString() + "" + cellRowIndex.ToString() + ":" + y.ToString() + "" + cellRowIndex.ToString()].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                            // MessageBox.Show("test");
                            //myCells.Range[y.ToString() + "" + cellRowIndex.ToString() + ":" + y.ToString() + "" + cellRowIndex.ToString()].AutoFit();
                            y++;
                        }
                        cellColumnIndex++;
                    }
                    rowCount++;
                    if (rowCount != 1)
                        i++;
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                //myCells.Range["A1", "Z1"].AutoFit();
                worksheet.Columns["A:Z"].AutoFit();

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    // MessageBox.Show("Export Successful");
                    path = saveDialog.FileName;
                    path += ".xlsx";
                    // MessageBox.Show(path);
                    Process.Start(@path);
                }
            }
            // catch (System.Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
            // finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }





        




            


        public void dataGridPdf(DataGridView tblReport, String txtHeader, String txtDate)
        {
            try
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
                doc.Open();

                PdfPTable table = new PdfPTable(tblReport.Columns.Count);

                for (int j = 0; j < tblReport.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(tblReport.Columns[j].HeaderText));
                }

                table.HeaderRows = 1;

                for (int i = 0; i < tblReport.Rows.Count; i++)
                {
                    for (int k = 0; k < tblReport.Columns.Count; k++)
                    {
                        if (tblReport[k, i].Value != null)
                            table.AddCell(new Phrase(tblReport[k, i].Value.ToString()));
                    }
                }


                //PdfPTable table = new PdfPTable();



                Paragraph paragraph = new Paragraph("                 " + txtHeader + "\n                 " + txtDate + "\n\n");
                doc.Add(paragraph);
                doc.Add(table);
                doc.Close();

                //System.Diagnostics.Process.Start(@"‪C:\Users\Charinda\AcademicStaffRegistration\Staff Registration System - Copy\Staff Registration System\bin\Debug\Test.pdf");
                Process.Start("Test.pdf", "‪C:\\Users\\Charinda\\AcademicStaffRegistration\\Staff Registration System - Copy\\Staff Registration System\bin\\Debug\\Test.pdf");
                //System.Diagnostics.Process.Start("‪C:\\Users\\Charinda\\AcademicStaffRegistration\\Staff Registration System - Copy\\Staff Registration System\bin\\Debug\\Test.pdf");
            }
            catch (Exception ex)
            {

                // MessageBox.Show(ex.ToString());
                MessageBox.Show("Pdf file is alreday open. Please close that for generate a new report");
            }
        }
        
        /*
        public void BindReport(CheckedListBox x, CrystalReportViewer crystalReportViewer1, CrystalReport5 CrystalReport5)
        {

            try
            {
                string query = "SELECT * ";

                foreach (object itemChecked in x.CheckedItems)
                {
                    query += itemChecked.ToString() + ",";
                    MessageBox.Show(itemChecked.ToString());
                }
                // for (int i = 0; i < x.Items.Count; i++)
                // {
                //    if (x.))
                //     {
                //        query += x.SelectedValue + ",";
                //        MessageBox.Show("test");
                //     }
                //    MessageBox.Show(x.SelectedIndex.ToString());
                // }

                query = query.Substring(0, query.Length - 1);
                query += " FROM AcademicStaff";

                MessageBox.Show(query);
                // ReportDocument crystalReport = new ReportDocument();
                // crystalReportViewer1.DisplayGroupTree = false;
                // crystalReport.Load(@"C:\Users\Charinda\AcademicStaffRegistration\Staff Registration System - Copy\Staff Registration System\CrystalReport5.rpt");
                //CrystalReport5.Load(Application.StartupPath + ("~/Report1.rpt"));
                // DataSet1 dsCustomers = GetData(query, crystalReport);
                //  crystalReport.SetDataSource(dsCustomers);
                //  crystalReportViewer1.ReportSource = crystalReport;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public DataSet1 GetData(string query, ReportDocument crystalReport)
        {

            DataSet1 dsCustomers = new DataSet1();

            try
            {
                conn.connConnection();
                SqlCommand cmd = conn.connConnection().CreateCommand();

                cmd = new SqlCommand(query, conn.connConnection());



                SqlDataReader sdr = cmd.ExecuteReader();

                //Get the List of all TextObjects in Section2.
                List<TextObject> textObjects = crystalReport.ReportDefinition.Sections["Section2"].ReportObjects.OfType<TextObject>().ToList();
                for (int i = 0; i < textObjects.Count; i++)
                {
                    //Set the name of Column in TextObject.
                    textObjects[i].Text = string.Empty;
                    if (sdr.FieldCount > i)
                    {
                        textObjects[i].Text = sdr.GetName(i);
                    }
                }
                //Load all the data rows in the Dataset.
                while (sdr.Read())
                {
                    DataRow dr = dsCustomers.Tables[0].Rows.Add();
                    for (int i = 0; i < sdr.FieldCount; i++)
                    {
                        dr[i] = sdr[i];
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            conn.closeConnection();
            return dsCustomers;
        }

        public void dataGridView(DataGridView tblSearch)
        {

            try
            {
                conn.connConnection();

                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM AcademicStaff ", conn.connConnection());
                // cmd.Parameters.AddWithValue("@1", txtSearchName);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                tblSearch.DataSource = table;
                conn.closeConnection();

                cmd.Dispose();
                dataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Cus(CrystalReportViewer crystalReportViewer1, CrystalReport5 CrystalReport5)
        {
            try
            {
                conn.connConnection();

                string sql = null;


                // sql = procesSQL();
                sql = "SELECT * FROM AcademicStaff";
                SqlDataAdapter dscmd = new SqlDataAdapter(sql, conn.connConnection());
                DataSet1 ds = new DataSet1();
                dscmd.Fill(ds, "Product");
                CrystalReport5.SetDataSource(ds.Tables[0]);
                crystalReportViewer1.ReportSource = CrystalReport5;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void try1(CrystalReportViewer crystalReportViewer1, DataGridView tblSearch)
        {
            try
            {
                DataSet ds = new DataSet();

                ds = FetchDataFromGrid(tblSearch);

                CrystalReport1 myReport = new CrystalReport1();

                myReport.SetDataSource(ds);

                crystalReportViewer1.ReportSource = myReport;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public DataSet FetchDataFromGrid(DataGridView tblSearch)
        {
            DataSet ds = new DataSet();
            try
            {

                DataTable dt = new DataTable();


                foreach (DataGridViewRow item in tblSearch.Rows)
                {

                    DataRow dr = dt.NewRow();

                    if (item.DataBoundItem != null)
                    {
                        dr = (DataRow)((DataRowView)item.DataBoundItem).Row;
                        dt.ImportRow(dr);
                        MessageBox.Show("test");
                    }
                }

                ds.Tables.Add(dt);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            return ds;
        }

        public void try2(CrystalReportViewer crystalReportViewer1)
        {
            try
            {
                conn.connConnection();

                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand("SELECT * FROM AcademicStaff ; ", conn.connConnection());
                // cmd.Parameters.AddWithValue("@1", txtSearchName);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                CrystalReport1 myReport = new CrystalReport1();

                myReport.SetDataSource(table);

                crystalReportViewer1.ReportSource = myReport;


                conn.closeConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }*/



    }
}
