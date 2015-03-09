﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonManager.Communication.Request
{
    /// <summary>
    /// Request to be sent for login
    /// </summary>
    public class UpdateStateRequest
    {
        public int ZoneID;
        public String StateName;
    }
}
