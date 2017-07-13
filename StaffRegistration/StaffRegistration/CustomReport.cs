using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRegistration
{
    class CustomReport
    {
        /*
         

        Connection conn = new Connection();

        public void loadReportTable( CheckedListBox chkLBxPersonal, CheckedListBox chkLBxFamily, CheckedListBox chkLBxEducational, CheckedListBox chkLBxService, CheckedListBox chkLBxOtherPositions, DataGridView tblReport,
            CheckedListBox chkLBAddress,CheckedListBox chkLBFaculty, CheckedListBox chkLBSalary)
        {
            try
            {
                string query = "SELECT DISTINCT ";

                foreach (object itemChecked in chkLBxPersonal.CheckedItems)
                {
                    query += "[AcademicStaff].[" + itemChecked.ToString() +"]"+ ",";
                    //MessageBox.Show(itemChecked.ToString());
                }

                foreach (object itemChecked in chkLBxFamily.CheckedItems)
                {
                    query += "[ChildrenDetail].[" + itemChecked.ToString() + "]" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }

                foreach (object itemChecked in chkLBxEducational.CheckedItems)
                {
                    query += "[EducationalQulifications].[" + itemChecked.ToString() + "]" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }

                foreach (object itemChecked in chkLBxService.CheckedItems)
                {
                    query += "[ServiceRecords].[" + itemChecked.ToString() + "]" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }

                foreach (object itemChecked in chkLBxOtherPositions.CheckedItems)
                {
                    query += "[OtherPositions].[" + itemChecked.ToString() + "]" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }
                foreach (object itemChecked in chkLBAddress.CheckedItems)
                {
                    query += "[Address].[" + itemChecked.ToString() + "]" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }
                foreach (object itemChecked in chkLBFaculty.CheckedItems)
                {
                    query += "[Department].[" + itemChecked.ToString() + "]" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }
                foreach (object itemChecked in chkLBSalary.CheckedItems)
                {
                    query += "[SalaryScale].[" + itemChecked.ToString() + "]" + ",";
                    //MessageBox.Show(itemChecked.ToString());
                }

                query = query.Substring(0, query.Length - 1);
                query += " FROM AcademicStaff,ChildrenDetail,EducationalQulifications,ServiceRecords,OtherPositions,SalaryScale,Department,Address,SalaryStep ";
               // if (chkLBxFamily.CheckedItems.Count>0)
                    query += "WHERE [AcademicStaff].[ASID] = [ChildrenDetail].[ASID] ";
                if (chkLBxOtherPositions.CheckedItems.Count > 0)
                    query += "AND [AcademicStaff].[ASID] = [OtherPositions].[ASID] ";
                if (chkLBxEducational.CheckedItems.Count > 0)
                    query += "AND [AcademicStaff].[ASID] = [EducationalQulifications].[ASID] ";
                if (chkLBxService.CheckedItems.Count > 0)
                    query += "AND [AcademicStaff].[ASID] = [ServiceRecords].[ASID] ";
                if (chkLBSalary.CheckedItems.Count > 0)
                {
                    query += "AND [AcademicStaff].[Salary Step] = [SalaryStep].[Salary Step] ";
                    query += "AND [SalaryStep].[Salary Scale] = [SalaryScale].[Salary Scale] ";
                }
                if (chkLBFaculty.CheckedItems.Count > 0)
                {
                    query += "AND [AcademicStaff].[Department Name] = [Department].[Department Name] ";
                }
                if (chkLBAddress.CheckedItems.Count > 0)
                    query += "AND [AcademicStaff].[ASID] = [Address].[ASID] ";





               // MessageBox.Show(query);

                conn.connOpen();
                conn.connConnection();

                SqlCommand cmd = conn.connConnection().CreateCommand();
                cmd = new SqlCommand(query, conn.connConnection());
                //cmd.Parameters.AddWithValue("@1", txtSearchName);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

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
