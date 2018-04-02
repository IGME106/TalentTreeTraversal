using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentTreeTraversal
{
    class Program
    {
        public static TalentTreeNode Level0 { get; set; }
        public static TalentTreeNode Level1Left { get; set; }
        public static TalentTreeNode Level1Right { get; set; }
        public static TalentTreeNode Level2LeftLeft { get; set; }
        public static TalentTreeNode Level2LeftRight { get; set; }
        public static TalentTreeNode Level2RightLeft { get; set; }
        public static TalentTreeNode Level2RightRight { get; set; }

        static void Main(string[] args)
        {
            Level0 = new TalentTreeNode("Magic") { HasLearned = true };
            Level1Left = new TalentTreeNode("Fireball") { HasLearned = true };
            Level1Right = new TalentTreeNode("Magic Arrow") { HasLearned = true };

            Level2LeftLeft = new TalentTreeNode("Crazy Big Firewall") { HasLearned = true };
            Level2LeftRight = new TalentTreeNode("1000 Tiny Fireballs") { HasLearned = true };
            Level2RightLeft = new TalentTreeNode("Ice Arrow") { HasLearned = true };
            Level2RightRight = new TalentTreeNode("Exploding Arrow") { HasLearned = true };

            Level1Left.LeftNode = Level2LeftLeft;
            Level1Left.RightNode = Level2LeftRight;
            Level1Right.LeftNode = Level2RightLeft;
            Level1Right.RightNode = Level2RightRight;

            Level0.LeftNode = Level1Left;
            Level0.RightNode = Level1Right;

            Level0.ListAllAbilities();
            Console.WriteLine();
            Level0.ListKnownAbilities();
            Console.WriteLine();
            Level0.ListPossibleAbilities();
            Console.WriteLine();
        }
    }
}
