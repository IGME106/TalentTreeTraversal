using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentTreeTraversal
{
    class TalentTreeNode
    {
        public string AbilityName { get; set; }
        public bool HasLearned { get; set; }
        public TalentTreeNode LeftNode { get; set; }
        public TalentTreeNode RightNode { get; set; }

        public TalentTreeNode(string abilityName)
        {
            AbilityName = abilityName;
            HasLearned = false;


        }

        public void ListAllAbilities() { }
        public void ListKnownAbilities() { }
        public void ListPossibleAbilities() { }
    }
}
