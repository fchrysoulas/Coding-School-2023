﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {

    public enum ActionEnum { 
        Convert, 
        Uppercase,
        Reverse
    } 

    public class MessageLogger { 
    
    }

    public class ActionRequest { 
    
    }

    public class ActionResponse {

    }

    public class ActionResolver {

        // PROPERTIES
        public MessageLogger Logger { get; set; }

        // CTOR
        public ActionResolver() {

        }

        // METHODS
        public ActionResponse Execute(ActionRequest request) {


            return null;
        }


    }
}
