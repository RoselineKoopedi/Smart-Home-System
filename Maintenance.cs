using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
     public class Maintenance
    {
        private string maintenanceID;
        private string maintenanceType;
        private DateTime maintenanceDate;
        private string serviceLevel;
        private string maintenanceStatus;

        public string MaintenanceID
        {
            get
            {
                return maintenanceID;
            }

            set
            {
                maintenanceID = value;
            }
        }

        public string MaintenanceType
        {
            get
            {
                return maintenanceType;
            }

            set
            {
                maintenanceType = value;
            }
        }

        public DateTime MaintenanceDate
        {
            get
            {
                return maintenanceDate;
            }

            set
            {
                maintenanceDate = value;
            }
        }

        public string ServiceLevel
        {
            get
            {
                return serviceLevel;
            }

            set
            {
                serviceLevel = value;
            }
        }

        public string MaintenanceStatus
        {
            get
            {
                return maintenanceStatus;
            }

            set
            {
                maintenanceStatus = value;
            }
        }
        public Maintenance()
        {

        }
        public Maintenance(string maintenanceID, string maintenanceType, DateTime maintenanceDate, string serviceLevel, string maintenanceStatus)
        {
            this.maintenanceID = maintenanceID;
            this.maintenanceType = maintenanceType;
            this.maintenanceDate = maintenanceDate;
            this.serviceLevel = serviceLevel;
            this.maintenanceStatus = maintenanceStatus;
        }

        static DataTable dataMaintenance = new DataTable();
        public DataTable GetMaintenace()
        {
            MaintenanceDataHandler MaintenanceHandler = new MaintenanceDataHandler();
            dataMaintenance = MaintenanceHandler.ReadMaintenance("Maintenance");

            return dataMaintenance;
        }
        // Insert Maintenance data into the database
        public void InsertMaintenance(string maintenanceID, string maintenanceType, DateTime maintenanceDate, string serviceLevel, string maintenanceStatus)
        {
            new MaintenanceDataHandler().InsertMaintenance(maintenanceID, maintenanceType, maintenanceDate, serviceLevel, maintenanceStatus);
        }
    }
}
