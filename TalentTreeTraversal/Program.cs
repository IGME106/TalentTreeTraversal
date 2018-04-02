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

        public static TalentTreeNode Level1_0 { get; set; }
        public static TalentTreeNode Level1_1 { get; set; }

        public static TalentTreeNode Level2_00 { get; set; }
        public static TalentTreeNode Level2_01 { get; set; }
        public static TalentTreeNode Level2_10 { get; set; }
        public static TalentTreeNode Level2_11 { get; set; }

        static void Main(string[] args)
        {
            Level0 = new TalentTreeNode("Magic") { HasLearned = true };
            Level1_0 = new TalentTreeNode("Fireball") { HasLearned = true };
            Level1_1 = new TalentTreeNode("Magic Arrow") { HasLearned = false };

            Level2_00 = new TalentTreeNode("Crazy Big Fireball") { HasLearned = false };
            Level2_01 = new TalentTreeNode("1000 Tiny Fireballs") { HasLearned = true };
            Level2_10 = new TalentTreeNode("Ice Arrow") { HasLearned = false };
            Level2_11 = new TalentTreeNode("Exploding Arrow") { HasLearned = false };

            Level1_0.LeftNode = Level2_00;
            Level1_0.RightNode = Level2_01;
            Level1_1.LeftNode = Level2_10;
            Level1_1.RightNode = Level2_11;

            Level0.LeftNode = Level1_0;
            Level0.RightNode = Level1_1;

            Console.WriteLine("       All Possible Talents");
            Console.WriteLine("==================================");
            Level0.ListAllAbilities();
            Console.WriteLine();

            Console.WriteLine("        All Known Talents");
            Console.WriteLine("==================================");
            Level0.ListKnownAbilities();
            Console.WriteLine();

            Console.WriteLine(" All Unknown but Possible Talents");
            Console.WriteLine("==================================");
            Level0.ListPossibleAbilities();
            Console.WriteLine();
        }
    }
}
