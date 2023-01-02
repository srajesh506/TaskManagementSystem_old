using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using TMS.Home.wait;
using System.Threading;

namespace TMS.Reporting
{
    public partial class StatusBasedReport : Form
    {
        App_Code.CodeTMS obj = new App_Code.CodeTMS();
        public StatusBasedReport()
        {
            InitializeComponent();
            LoadTheme();
            cmbstatus.SelectedText = "--Select Status--";
            GetAllData("0");
        }
        private void LoadTheme()
        {

            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
          
            lblstatus.ForeColor = ThemeColor.PrimaryColor;
            //lblexport.ForeColor = ThemeColor.PrimaryColor;
            dview.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforeTaskBasedReport.ForeColor = ThemeColor.PrimaryColor;
        }

        private void StatusBasedReport_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = obj.GetDataFromTable("Select * from tbl_status");
                DataRow dr;
                dr = ds.Tables[0].NewRow();
                dr.ItemArray = new object[] { 0, "--Select Status--" };
                ds.Tables[0].Rows.InsertAt(dr, 0);
                cmbstatus.ValueMember = "Statusid";
                cmbstatus.DisplayMember = "Status";
                cmbstatus.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbstatus.SelectedIndex>0)
                {
                    GetAllData(cmbstatus.SelectedValue.ToString());
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetAllData(string statusid)
        {
            if (cmbstatus.SelectedIndex > 0)
            {
                dview.DataSource = null;
                dview.DataSource = obj.GetDataFromTable("SELECT dbo.tbl_workitems.Remark as WorkItem, FORMAT(dbo.tbl_workitemsassignment.Start_Date, 'dd-MMM-yy') AS StartDate, dbo.tbl_workitemsassignment.[HandOver/ClosedDate] as ClosedDate, ISNULL(dbo.tbl_status.Status,'--Choose--')  as Status, ISNULL(dbo.UserMaster.EmpName,'--Choose--')  as Employee FROM dbo.tbl_workitemsassignment INNER JOIN dbo.tbl_workitems ON dbo.tbl_workitemsassignment.assigmentitemId = dbo.tbl_workitems.Id INNER JOIN dbo.tbl_status ON dbo.tbl_workitemsassignment.Status = dbo.tbl_status.StatusId LEFT OUTER JOIN dbo.UserMaster ON dbo.tbl_workitemsassignment.empid = dbo.UserMaster.empid where dbo.tbl_workitemsassignment.Status='" + cmbstatus.SelectedValue + "'").Tables[0];
                dview.Columns[0].Width = 600;
                dview.Columns[1].Width = 100;
                dview.Columns[2].Width = 100;
                dview.Columns[3].Width = 100;
                dview.Columns[4].Width = 100;
                dview.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dview.ReadOnly = true;
            }
            else
            {
                dview.DataSource = null;
                dview.DataSource = obj.GetDataFromTable("SELECT dbo.tbl_workitems.Remark as WorkItem, FORMAT(dbo.tbl_workitemsassignment.Start_Date, 'dd-MMM-yy') AS StartDate, dbo.tbl_workitemsassignment.[HandOver/ClosedDate] as ClosedDate, ISNULL(dbo.tbl_status.Status,'--Choose--')  as Status, ISNULL(dbo.UserMaster.EmpName,'--Choose--')  as Employee FROM dbo.tbl_workitemsassignment INNER JOIN dbo.tbl_workitems ON dbo.tbl_workitemsassignment.assigmentitemId = dbo.tbl_workitems.Id INNER JOIN dbo.tbl_status ON dbo.tbl_workitemsassignment.Status = dbo.tbl_status.StatusId LEFT OUTER JOIN dbo.UserMaster ON dbo.tbl_workitemsassignment.empid = dbo.UserMaster.empid").Tables[0];
                dview.Columns[0].Width = 600;
                dview.Columns[1].Width = 100;
                dview.Columns[2].Width = 100;
                dview.Columns[3].Width = 100;
                dview.Columns[4].Width = 100;
                dview.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dview.ReadOnly = true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Status Based Report";
            // storing header part in Excel  
            for (int i = 1; i < dview.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dview.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dview.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dview.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dview.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            //excel.DisplayAlerts = false;
            //workbook.SaveAs(Application.StartupPath + "\\Report\\" + "StatusBasedReport_" + DateTime.Now.ToString(), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //workbook.SaveAs(Microsoft.Office.Interop.Excel.Application.StartupPath + "\\Report\\" + "StatusBasedReport_" + DateTime.Now.ToString(), Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void picpdf_Click(object sender, EventArgs e)
        {
            if (dview.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dview.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dview.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dview.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }
                            }
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}
