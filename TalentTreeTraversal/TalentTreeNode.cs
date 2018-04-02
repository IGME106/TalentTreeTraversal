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

        public void ListAllAbilities()
        {
            if (this.LeftNode.LeftNode != null)
            {
                this.LeftNode.ListAllAbilities();
            }
            else
            {
                Console.WriteLine(this.LeftNode.AbilityName);
            }

            Console.WriteLine(this.AbilityName);

            if (this.RightNode.RightNode != null)
            {
                this.RightNode.ListAllAbilities();
            }
            else
            {
                Console.WriteLine(this.RightNode.AbilityName);
            }
        }


        public void ListKnownAbilities()
        {
            if (this.HasLearned == true)
            {
                Console.WriteLine(this.AbilityName);

                if (this.LeftNode != null)
                {
                    this.LeftNode.ListKnownAbilities();
                }
                
                if (this.RightNode != null)
                {
                    this.RightNode.ListKnownAbilities();
                }                
            }            
        }


        public void ListPossibleAbilities()
        {
            if (!this.HasLearned)
            {
                Console.WriteLine(this.AbilityName);
            }
            if ((this.LeftNode.LeftNode != null) && (this.LeftNode.HasLearned == true))
            {
                this.LeftNode.ListPossibleAbilities();
            }
            else
            {
                if (this.HasLearned & !this.LeftNode.HasLearned)
                {
                    Console.WriteLine(this.LeftNode.AbilityName);
                }                
            }
            
            if ((this.RightNode.RightNode != null) && (this.RightNode.HasLearned == true))
            {
                this.RightNode.ListPossibleAbilities();
            }
            else
            {
                if (this.HasLearned & !this.RightNode.HasLearned)
                {
                    Console.WriteLine(this.RightNode.AbilityName);
                }                
            }
        }

        public override string ToString()
        {
            return "AbilityName : " + this.AbilityName + "      HasLearned : " + this.HasLearned;
        }
    }
}
