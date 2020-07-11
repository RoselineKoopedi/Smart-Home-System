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
    public class Correction : Operation
    {
     //Fields
        private int correctionID;
        private DateTime correctionDate;

        //Properties
        public int CorrectionID
        {
            get
            {
                return correctionID;
            }

            set
            {
                correctionID = value;
            }
        }

        public DateTime CorrectionDate
        {
            get
            {
                return correctionDate;
            }

            set
            {
                correctionDate = value;
            }
        }
        //Constructors
        public Correction()
        {

        }
        public Correction(int correctionID, DateTime correctionDate)
        {
            this.CorrectionID = correctionID;
            this.CorrectionDate = correctionDate;
        }
        public Correction(int correctionID, DateTime correctionDate, int operationID, string operationType, DateTime operationDate, string status)
           : base(operationID, operationType, operationDate, status)
        {
            this.CorrectionID = correctionID;
            this.CorrectionDate = correctionDate;
        }

        public Correction(int correctionID, int operationID, int ResidenceID , DateTime correctionDate)
        {
            this.CorrectionID = correctionID;
            this.CorrectionDate = correctionDate;
            //this.ResidenceID = ResidenceID;
            this.OperationID = operationID;
        }

        public List<Correction> ReadCorrections()
        {
            List<Correction> GetCorrections = new List<Correction>();
            DataSet CorrectionData = new CorrectionDataHandler().ReadCorrections("Corrections");

            foreach (DataRow item in CorrectionData.Tables["Corrections"].Rows)
            {
                GetCorrections.Add(new Correction(int.Parse(item["CorrectionID"].ToString()), int.Parse(item["OperationID"].ToString()), int.Parse(item["ResidenceID"].ToString()), DateTime.Parse(item["CorrectionDate"].ToString())));
            }

            return GetCorrections;
        }

        public void InsertCorrection(int correctionID, int OperationID, int ResidenceID, DateTime CorrectionDate)
        {
            new CorrectionDataHandler().InsertCorrection(correctionID, OperationID, ResidenceID, CorrectionDate);
        }
        public void UpdateCorrection(int correctionID, int OperationID, int ResidenceID, DateTime CorrectionDate)
        {
            new CorrectionDataHandler().UpdateCorrection(correctionID, OperationID, ResidenceID, CorrectionDate);
        }
        public void DeleteCorrection(int correctionID)
        {
            new CorrectionDataHandler().DeleteCorrection(correctionID);

        }

    }
}
