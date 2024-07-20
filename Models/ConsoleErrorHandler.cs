using System.Collections.Generic;

namespace message.Models
{
    public class ConsoleErrorHandler : ErrorHandler
    {
        public override void Handle(string message, List<string> log)
        {
            if (message.ToLower().Contains("console"))
            {
                log.Add("ConsoleErrorHandler handled the message: " + message);
            }
            else if (NextHandler != null)
            {
                log.Add("ConsoleErrorHandler passed the message to the next handler.");
                NextHandler.Handle(message, log);
            }
            else
            {
                log.Add("ConsoleErrorHandler could not handle the message and there is no next handler.");
            }
        }
    }
}
