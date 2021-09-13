using System;

namespace ChainResponsability
{
    public class DocFileHandler : Handler
    {
        public Handler handler { set; get; }
        public string handlerName { set; get; }

        public DocFileHandler(string handlerName)
        {
            this.handlerName = handlerName;
        }

        public void SetHandler(Handler handler)
        {
            this.handler  =  handler;
        }

        public void Process(File file)
        {
            if (file.fileType.Equals("doc"))
            {
                Console.WriteLine("DocFileHandler process the file: " + file.fileName);
            } 
            else 
            {
                if (handler != null)
                {
                    this.handler.Process(file);
                }
                else
                {
                    Console.WriteLine("Error is not support " + file.fileName);   
                }
            }
        }

        public string GetHandlerName()
        {
            return this.handlerName;
        }
    }
}