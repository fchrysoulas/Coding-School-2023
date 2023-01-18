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

        public Message() {
            ID = Guid.NewGuid();    
        }

        public Message(string text) {
            ID = Guid.NewGuid();
            TimeStamp= DateTime.Now;    
            Text = text;
        }

    }

    public class MessageLogger {

        public Message[] Messages { get; set; }

        public MessageLogger() {
            Messages = new Message[1000];
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

        public ActionRequest() {
            RequestID = Guid.NewGuid();
        }

    }

    public class ActionResponse {

        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }
        public string Output { get; set; }

        public ActionResponse() {
            ResponseID = Guid.NewGuid(); 
        }
    }

    public class ActionResolver {

        // PROPERTIES
        public MessageLogger Logger { get; set; }

        // CTOR
        public ActionResolver() {

        }

        // METHODS
        public ActionResponse Execute(ActionRequest request) {


            ActionResponse response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;

            MessageLogger logger = new MessageLogger();

            Message message = new Message();
            message.Text = "EXECUTION START";
            message.TimeStamp = DateTime.Now;

            logger.Messages[0] = message;
            
            try {

                switch (request.Action) {
                    case ActionEnum.Convert:
                        response.Output = Convert(request.Input);
                        break;

                    case ActionEnum.Uppercase:
                        response.Output = Uppercase(request.Input);
                        break;

                    case ActionEnum.Reverse:
                        response.Output = Reverse(request.Input);
                        break;

                    default:
                        // TODO: ERRORMESSAGE!
                        break;
                }
            }
            catch (Exception ex) {
                Message message2 = new Message();
                message2.Text = ex.Message;
                message2.TimeStamp = DateTime.Now;

                logger.Messages[1] = message2;
            }
            finally {

                Message message3 = new Message();
                message3.Text = "EXECUTION END";
                message3.TimeStamp = DateTime.Now;

                logger.Messages[0] = message3;
            }
            

            return response;
        }

        public string Convert(string input) {
            // “Convert” you must check if the Input is a decimal number and convert it to binary.

            return string.Empty;
        }

        public string Uppercase(string input) {
            // “Uppercase” you must check if the Input is a string and has more than
            // one words(separated by a space), then find the longest word in the
            // Input string and convert it to uppercase.

            return string.Empty;
        }

        public string Reverse(string input) {
            // “Reverse” you must check if the Input is a string and reverse it.

            return string.Empty;

        }


    }
}
