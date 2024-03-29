﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {

    public class ActionEntity {

        public Guid RequestID { get; set; }
    }


    public class ActionRequest : ActionEntity {

        public string Input { get; set; }
        public ActionEnum Action { get; set; }

        public ActionRequest() {
            RequestID = Guid.NewGuid();
        }

    }
}
