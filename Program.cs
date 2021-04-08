using System;

namespace BudgetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AppBanner();
            AppLogic();
        }
        static void AppBanner()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("|                                    |");
            Console.WriteLine("|           Budget Your Money        |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        static string TakeUserInput(string question, String inputType, bool expenditures = false)
        {
            bool loopTheApp = true;
            string stringInput;
            double doubleInput;

            AskUserQuestion(question, expenditures);
            
            switch (inputType)
            {
                case "string":
                    stringInput = Console.ReadLine();

                    while (stringInput.Equals(""))
                    {
                        Console.WriteLine("Input cannot be empty, Please enter something!");
                    }
                    return stringInput;
                case "double":
 
                    while (loopTheApp)
                    {
                        try
                        {
                            doubleInput = Double.Parse(Console.ReadLine());
                            return doubleInput.ToString();
                        }
                        catch(Exception e)
                        {
                            Console.Write("\nPlease enter a valid value!!!");
                            AskUserQuestion(question, expenditures);
                        }
                    }

                    /* 
                     * The program is not supposed to get here 
                     * If it did then it means something went wrong
                     * Therefore this error message will show up on the console to let the user know that something went wrong
                     */

                    return "Something went wrong";
                default:
                    return "Selected Type is invalid choose between string, double or int";
            }
            

            
            
        }
        static string TakeUserChoiceInput(string question)
        {
            bool loopTheApp = true;
            int userChoice;

            AskUserQuestion(question, false);
            
            switch (inputType)
            {
                case "string":
                    stringInput = Console.ReadLine();

                    while (stringInput.Equals(""))
                    {
                        Console.WriteLine("Input cannot be empty, Please enter something!");
                    }
                    return stringInput;
                case "double":
 
                    while (loopTheApp)
                    {
                        try
                        {
                            doubleInput = Double.Parse(Console.ReadLine());
                            return doubleInput.ToString();
                        }
                        catch(Exception e)
                        {
                            Console.Write("\nPlease enter a valid value!!!");
                            AskUserQuestion(question, expenditures);
                        }
                    }

                    /* 
                     * The program is not supposed to get here 
                     * If it did then it means something went wrong
                     * Therefore this error message will show up on the console to let the user know that something went wrong
                     */

                    return "Something went wrong";
                default:
                    return "Selected Type is invalid choose between string, double or int";
            } 
        }
        static void AppLogic()
        {
            double grossMontlyIncome;
            double monthlyTaxDeducted;
            double [] monthlyExpenditures = new double[5];

            grossMontlyIncome = Convert.ToDouble(TakeUserInput("Gross monthly income (before deductions)", "double"));
            monthlyTaxDeducted = Convert.ToDouble(TakeUserInput("Gross Estimated monthly tax deducted", "double"));
            monthlyExpenditures[0] = Convert.ToDouble(TakeUserInput("Groceries", "double", true));
            monthlyExpenditures[1] = Convert.ToDouble(TakeUserInput("Water and lights", "double", true));
            monthlyExpenditures[2] = Convert.ToDouble(TakeUserInput("Travel costs (including petrol)", "double", true));
            monthlyExpenditures[3] = Convert.ToDouble(TakeUserInput("Tell phone and telephone", "double", true));
            monthlyExpenditures[4] = Convert.ToDouble(TakeUserInput("Other expenses", "double", true));


            Console.WriteLine(grossMontlyIncome);
 
        }

        static void AskUserQuestion(string question, bool expenditures = false, bool selectOption = false)
        {
            if (expenditures == true)
            {
                Console.Write($"\nEnter estimated monthly expenditures in {question}: ");
            }
            else
            {
                if(selectOption)
                {
                    Console.Write($"\nDo you wish to rent accommodation or buying a property " +
                        $"\nEnter 1 to Rent Accommodation or 2 to Buy Property: ");
                }
                else
                {
                    Console.Write($"\nEnter {question}: ");
                }
            }
        }
    }
}
