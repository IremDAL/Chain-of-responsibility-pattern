using System.Collections.Generic;

namespace message.Models
{
    public class FileErrorHandler : ErrorHandler
    {
        public override void Handle(string message, List<string> log)
        {
            if (message.ToLower().Contains("file"))
            {
                log.Add("FileErrorHandler handled the message: " + message);
            }
            else if (NextHandler != null)
            {
                log.Add("FileErrorHandler passed the message to the next handler.");
                NextHandler.Handle(message, log);
            }
            else
            {
                log.Add("FileErrorHandler could not handle the message and there is no next handler.");
            }
        }
    }
}
