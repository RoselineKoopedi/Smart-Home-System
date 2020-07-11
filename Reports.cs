using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Reports : Correction
    {
        private int reportID;
        private string faultDetected;
        private DateTime detectedDate;

        public int ReportID
        {
            get
            {
                return reportID;
            }

            set
            {
                reportID = value;
            }
        }

        public string FaultDetected
        {
            get
            {
                return faultDetected;
            }

            set
            {
                faultDetected = value;
            }
        }

        public DateTime DetectedDate
        {
            get
            {
                return detectedDate;
            }

            set
            {
                detectedDate = value;
            }
        }
        public Reports()
        {

        }
        public Reports(int reportID, string faultD, DateTime detectedDate)
        {
            this.ReportID = reportID;
            this.FaultDetected = faultD;
            this.DetectedDate = detectedDate;
        }
        public Reports(int reportID, string faultD, DateTime detectedDate, int correctionID, DateTime correctionDate)
            :base(correctionID,correctionDate)
        {
            this.CorrectionID = correctionID;
            this.CorrectionDate = correctionDate;
        }
        public Reports(int reportID, int correctionID, string faultD, DateTime detectedD)
        {
            this.ReportID = reportID;
            this.CorrectionID = correctionID;
            this.faultDetected = faultD;
            this.DetectedDate = detectedD;
        }
        public List<Reports> ReadReports()
        {
            List<Reports> GetReports = new List<Reports>();
            DataSet ReportsData = new ReportDataHandler().ReadReports("Reports");

            foreach (DataRow item in ReportsData.Tables["Reports"].Rows)
            {
                GetReports.Add(new Reports(int.Parse(item["ReportID"].ToString()), int.Parse(item["CorrectionID"].ToString()), item["FaultDetected"].ToString(), DateTime.Parse(item["DetectedDate"].ToString())));
            }

            return GetReports;
        }

        public void InsertReport()
        {
            new ReportDataHandler().InsertReport(ReportID, CorrectionID, FaultDetected, DetectedDate);
                
        }
        public void UpdateReport()
        {
            new ReportDataHandler().UpdateReports(ReportID, CorrectionID, FaultDetected, DetectedDate);
        }
        public void DeleteReport()
        {
            new ReportDataHandler().DeleteReports(ReportID);
        }
    }
}
