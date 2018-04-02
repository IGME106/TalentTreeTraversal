using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentTreeTraversal
{
    class Program
    {
        public static TalentTreeNode TreeNode { get; set; }

        static void Main(string[] args)
        {
            TreeNode = new TalentTreeNode();
            TreeNode.HasLearned = true;
        }
    }
}
