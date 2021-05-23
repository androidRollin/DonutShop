using System;

namespace DoughnutShop
{
    public class DoughnutShop
    {
        public static double totalCost = 0;
        static void Main(string[] args)
        {

            bool isRestart = true;
            char ans = 'Y';
            int numTransaction = 0;

            while(isRestart)
            {
                displayOrderTotalPhp();
                DoughnutShop.PrintChoices();
                DoughnutShop.chooseDoughnut();
                Console.WriteLine("\n ...Add Another Dozen of Donut? [Y/N]");
                ans = Console.ReadLine()[0];
                if (ans == 'N' || ans == 'n')
                {
                    Console.Clear();
                    Console.WriteLine("Please pay Php {0} to the Cashier, thanks", totalCost);
                    Console.WriteLine("Thank you for ordering");
                    Console.ReadLine();
                    break;
                }
                numTransaction++;
                Console.Clear();
                if (ans != 'y' || ans != 'Y')
                {
                    Console.WriteLine("You inputted an invalid key, please try again");
                }

            }
        }

        public static void askAddOrderConfirmation(double singleDonutPrice)
        {
            char ansifAddOrder = 'N';
            Console.WriteLine("\n ...Confirm add to orders? [Y/N]");
            ansifAddOrder = Console.ReadLine()[0];
            if (ansifAddOrder == 'Y' || ansifAddOrder == 'y')
            {
                addTotalAmountDue(singleDonutPrice);
                Console.Clear();
                Console.WriteLine("Order successfully added....");
                displayOrderTotalPhp();
            }

        }

        public static void displayOrderTotalPhp()
        {
            Console.WriteLine("Amount Due: Php {0}\n", totalCost);
        }

        public static double multiplytoDozen(double singleDonutPrice)
        {
            double dozenBoxPrice;
            dozenBoxPrice = Convert.ToDouble(singleDonutPrice * 12);
            return dozenBoxPrice;
        }

        public static void printAmountDueinDozen(double singleDonutPrice)
        {
            double dozenBoxPrice;
            dozenBoxPrice = multiplytoDozen(singleDonutPrice);
            Console.WriteLine("Price per Dozen = {0}", dozenBoxPrice);
        }

        public static void addTotalAmountDue(double singleDonutPrice)
        {
            Console.WriteLine(totalCost);
            double dozenBoxPrice;
            dozenBoxPrice = Convert.ToDouble(multiplytoDozen(singleDonutPrice));
            totalCost += dozenBoxPrice;
        }

        public static void PrintChoices()
        {
            Console.WriteLine("Doughnut Shop");
            Console.WriteLine("Select an Order of Dozen:\n");
            Console.WriteLine("[1] Plain Doughnut \n" +
                              "[2] Plain Choco \n" +
                              "[3] Plain Strawberry \n" +
                              "[4] Choco Crunch \n" +
                              "[5] Strawberry Sprinkles \n" +
                              "[6] Cinnamon Crunch \n");
        }

        public static void chooseDoughnut()
        {
            int choice;
            double cost = 0;
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    PlainDoughnut plainDoughnut = new PlainDoughnut();
                    cost = plainDoughnut.ComputeCost();
                    //Console.WriteLine("Your bill is Php " + plainDoughnut.ComputeCost());
                    printAmountDueinDozen(cost);
                    askAddOrderConfirmation(cost);
                    break;
                case 2:
                    PlainChoco plainChoco = new PlainChoco();
                    cost = plainChoco.ComputeCost();
                    //Console.WriteLine("Your bill is Php " + plainChoco.ComputeCost());
                    printAmountDueinDozen(cost);
                    askAddOrderConfirmation(cost);
                    break;
                case 3:
                    PlainStrawberry plainStrawberry = new PlainStrawberry();
                    //Console.WriteLine("Your bill is Php " + plainStrawberry.ComputeCost());
                    cost = plainStrawberry.ComputeCost();
                    printAmountDueinDozen(cost);
                    askAddOrderConfirmation(cost);
                    break;
                case 4:
                    ChocoCrunch chocoCrunch = new ChocoCrunch();
                    //Console.WriteLine("Your bill is Php " + chocoCrunch.ComputeCost());
                    cost = chocoCrunch.ComputeCost();
                    printAmountDueinDozen(cost);
                    askAddOrderConfirmation(cost);
                    break;
                case 5:
                    StrawberrrySprinkles strawberrrySprinkles = new StrawberrrySprinkles();
                    //Console.WriteLine("Your bill is Php " + strawberrrySprinkles.ComputeCost());
                    cost = strawberrrySprinkles.ComputeCost();
                    printAmountDueinDozen(cost);
                    askAddOrderConfirmation(cost);
                    break;
                case 6:
                    CinnamonCrunch cinnamonCrunch = new CinnamonCrunch();
                    //Console.WriteLine("Your bill is Php " + cinnamonCrunch.ComputeCost());
                    cost = Convert.ToDouble(cinnamonCrunch.ComputeCost());
                    Console.WriteLine("The cost is" + cost);
                    printAmountDueinDozen(cost);
                    askAddOrderConfirmation(cost);
                    break;
                default:
                    Console.WriteLine("Sorry Ma'am/Sir, chosen number is not on the list");
                    break;

            }
        }
    }

}
