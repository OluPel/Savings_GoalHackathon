using System;

namespace BudgetingTool {
    class Program {
        static void Main(string[] args) {
            // Define variables for the user's financial information
            double income;
            double expensesPercentage;
            double savingsPercentage;
            double savingsGoal;
            double savings = 0; // Initialize savings to zero

            // Define an array for the budget categories
            string[] budgetCategories = { "Housing", "Transportation", "Food", "Utilities", "Entertainment", "Other" };
            double[] budgetAmounts = new double[budgetCategories.Length];

            // Get input from the user
            Console.Write("Enter your monthly income: ");
            income = double.Parse(Console.ReadLine());

            Console.Write("Enter your monthly expenses percentage: ");
            expensesPercentage = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Enter your monthly savings percentage: ");
            savingsPercentage = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Enter your savings goal: ");
            savingsGoal = double.Parse(Console.ReadLine());

            // Calculate the expense and savings amounts
            double expenses = income * expensesPercentage;
            double savingsPerMonth = income * savingsPercentage;

            // Print the user's financial information
            Console.WriteLine("Your monthly income is $" + income);
            Console.WriteLine("Your monthly expenses are $" + expenses);
            Console.WriteLine("Your savings goal is $" + savingsGoal);
            Console.WriteLine("You need to save $" + savingsPerMonth + " each month to reach your savings goal.");

            // Get input from the user for the budget amounts
            Console.WriteLine("Enter the budget amounts for each category:");
            for (int i = 0; i < budgetCategories.Length; i++) {
                Console.Write(budgetCategories[i] + ": $");
                budgetAmounts[i] = double.Parse(Console.ReadLine());
            }

            // Calculate the total budget and remaining funds
            double totalBudget = 0;
            for (int i = 0; i < budgetAmounts.Length; i++) {
                totalBudget += budgetAmounts[i];
            }
            double remainingFunds = income - expenses - totalBudget;

            // Print the budget information
            Console.WriteLine("\nBudget:");
            for (int i = 0; i < budgetCategories.Length; i++) {
                Console.WriteLine(budgetCategories[i] + ": $" + budgetAmounts[i]);
            }
            Console.WriteLine("Total Budget: $" + totalBudget);
            Console.WriteLine("Remaining Funds: $" + remainingFunds);

            // Ask the user to input their savings each month
            Console.Write("\nEnter your savings for this month: ");
            double currentSavings = double.Parse(Console.ReadLine());

            // Add the user's savings to their total savings
            savings += currentSavings;

            // Check if the user has reached their savings goal
            if (savings >= savingsGoal) {
                Console.WriteLine("Congratulations! You have reached your savings goal!");
            }
            else {
                Console.WriteLine("You are " + (savingsGoal - savings) + " away from your savings goal.");
            }

            Console.ReadLine();
        }
    }
}


