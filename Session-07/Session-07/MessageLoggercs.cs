using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {

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
            TimeStamp = DateTime.Now;
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
}
