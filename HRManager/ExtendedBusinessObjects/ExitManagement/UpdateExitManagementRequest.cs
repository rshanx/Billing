﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRManager.ExtendedBusinessObjects.ExitManagement
{
    public class UpdateExitManagementRequest
    {
        public int ID;
        public int EmployeeID;
        public int ExitTypeID;
        public DateTime ExitDate;
    }
    public class UpdateEMPExitManagementRequest
    {
        public int EmployeeID;       
    }
}
