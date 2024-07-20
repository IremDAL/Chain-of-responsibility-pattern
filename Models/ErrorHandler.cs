using System.Collections.Generic;

namespace message.Models
{
    public abstract class ErrorHandler
    {
        protected ErrorHandler NextHandler;

        public void SetNextHandler(ErrorHandler nextHandler)
        {
            NextHandler = nextHandler;
           
        }
       
        public abstract void Handle(string message, List<string> log);
    }

}
