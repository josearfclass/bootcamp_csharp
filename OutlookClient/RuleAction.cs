using System.Collections.Generic;
using System.Linq;

namespace OutlookClient
{
    public interface IRuleAction
    {
        void ExecuteAction(IMessage message);
    }
    
    //ResendMessage
    public class MoveToFolderAction : IRuleAction
    {
        public string FolderToMove { get; set; }
        public List<IFolder> FoldersClient;

        public MoveToFolderAction(string folderToMove, List<IFolder> foldersClient)
        {
            this.FolderToMove = folderToMove;
            this.FoldersClient = foldersClient;
        }
        public void ExecuteAction(IMessage message)
        {
            
            IFolder folder = this.FoldersClient.Where((folder => folder.Name.Contains(this.FolderToMove))).First();
            folder.AddMessage(message);
        }
    }
}