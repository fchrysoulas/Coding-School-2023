using System;
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

    public class Message {

        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }

        // Change from class diagram: Message property cannot be the same as class name
        public string Text { get; set; }

    }

    public class MessageLogger {

        public Message[] Messages { get; set; }

        public MessageLogger() {

        }


        public void ReadAll() { 
        
        }

        public void Clear() {

        }

        public void Write(Message message) {

        }

    }

    public class ActionRequest {

        public Guid RequestID { get; set; }
        public string Input { get; set; }
        public ActionEnum Action { get; set; }

    }

    public class ActionResponse {

        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }
        public string Output { get; set; }
    }

    public class ActionResolver {

        // PROPERTIES
        public MessageLogger Logger { get; set; }

        // CTOR
        public ActionResolver() {

        }

        // METHODS
        public ActionResponse Execute(ActionRequest request) {

            switch (request.Action) {
                case ActionEnum.Convert:
                    Convert();
                    break;

                case ActionEnum.Uppercase:
                    Uppercase();
                    break;

                case ActionEnum.Reverse:
                    Reverse();
                    break;

                default:
                    // TODO: ERRORMESSAGE!
                    break;
            }

            return null;
        }

        public void Convert() { 
        
        }

        public void Uppercase() { 
        
        }

        public void Reverse() {

        }


    }
}
