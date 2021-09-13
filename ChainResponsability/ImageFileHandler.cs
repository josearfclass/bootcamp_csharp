using System;

namespace ChainResponsability
{
    public class ImageFileHandler : Handler
    {
        public Handler handler { set; get; }
        public string handlerName { set; get; }

        public ImageFileHandler(string handlerName)
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
                Console.WriteLine("ImageFileHandler process the file: " + file.fileName);
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