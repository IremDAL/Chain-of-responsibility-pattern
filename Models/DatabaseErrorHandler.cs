using System.Collections.Generic;

namespace message.Models
{
    public class DatabaseErrorHandler : ErrorHandler
    {
        public override void Handle(string message, List<string> log)
        {
            if (message.ToLower().Contains("database"))
            {
                log.Add("DatabaseErrorHandler handled the message: " + message);
            }
            else if (NextHandler != null)
            {
                log.Add("DatabaseErrorHandler passed the message to the next handler.");
                NextHandler.Handle(message, log);
            }
            else
            {
                log.Add("DatabaseErrorHandler could not handle the message and there is no next handler.");
            }
        }
    }
}
