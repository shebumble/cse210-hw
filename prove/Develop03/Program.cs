using System;
//Added multiple scriptures that are chosen at random for the user. As well the number of words hidden each time is random.
class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Moses", 1, 39);
        string text1 = "For behold this is my work and my glory to bring to pass the immortality and eternal life of man.";
        Scripture scripture1 = new Scripture(reference1, text1);

        Reference reference2 = new Reference("Abraham", 3, 22, 23);
        string text2 = "Now the Lord had shown unto me Abraham the intelligences that were organized before the world was and among all these there were many of the noble and great ones And God saw these souls that they were good and he stood in the midst of them and he said These I will make my rulers for he stood among those that were spirits and he saw that they were good and he said unto me Abraham thou art one of them thou wast chosen before thou wast born";
        Scripture scripture2 = new Scripture(reference2, text2);

        Reference reference3 = new Reference("Joshua", 1, 8);
        string text3 = "This book of the law shall not depart out of thy mouth but thou shalt meditate therein day and night that thou mayest observe to do according to all that is written therein for then thou shalt make thy way prosperous and then thou shalt have good success.";
        Scripture scripture3 = new Scripture(reference3, text3);

        List<Scripture> mastery = new List<Scripture> {scripture1, scripture2, scripture3};

        var r = new Random();
        int i = r.Next(mastery.Count);

        bool end = false;

        while(end != true)
        {
            Console.Clear();
            mastery[i].GetRenderedText();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string entry = Console.ReadLine();
                if (mastery[i].IsCompletelyHidden() == true)
                {
                    Environment.Exit(0);
                }
                if (entry == "quit")
                {
                    end = true;
                }
                else
                {
                    mastery[i].HideWords();

                }
                


        }
    }
}