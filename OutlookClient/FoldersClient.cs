using System;
using System.Collections.Generic;
using System.Linq;

namespace OutlookClient
{
    public class FoldersClient
    {
        public List<IFolder> Folders;

        public FoldersClient()
        {
            this.Folders = new List<IFolder>();
            SetDefaultFolder();
        }

        public void SetDefaultFolder()
        {
            this.Folders.Add(new Folder(name: "inbox"));
        }

        public void CreateFolder(string name)
        {
            bool folder_exist = this.Folders.Any(folder => folder.Name.Contains(name));
            if (!folder_exist)
            {
                this.Folders.Add(new Folder(name: name));
            }            
        }

        public void DeleteFolder(string name)
        {
            IFolder folderToDelete = this.Folders.Where(folder => folder.Name.Contains(name)).First();
            if (folderToDelete != null && name != "inbox" )
            {
                this.Folders.Remove(folderToDelete);
            }            
        }
        
        public void MoveMessage(Message message, Folder from, Folder to)
        {
            to.AddMessage(message);
            from.RemoveMessage(message);
        }
    }
}