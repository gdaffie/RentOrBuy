using System;

namespace RentOrBuyV2
{
    class RentOrBuy
    {
        public static void Main(string[] args)
        {
            double mainMenu = 0;
            double primaryPay = 0;
            string nameAndSurname = "";
            double secondaryPay = 0;
            double necessities = 0;
            double luxuries = 0;
            double monthlyTax = 0;
            double monthlyPayments = 0;
            double entertainment = 0;
            double totalMonthlyPayment = 0;
            double totalExpenses = 0;
            double interestAmount = 0;
            double totalPay = 0;
            double grossPay = 0;
            double status = 0;

            /* Loop Menu */

            while (mainMenu != 999)
                switch (mainMenu)
                {
                    case 0:     /* Main Menu */
                        Console.WriteLine("======================================\n");
                        Console.WriteLine("Welcome to Rent or Buy!\n");

                        /* Income  */
                        Console.WriteLine("======================================");
                        Console.WriteLine("PERSONAL INFO");
                        Console.WriteLine("Enter your name & surname: ");
                        nameAndSurname = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("INCOME");
                        Console.WriteLine("Enter primary income: ");
                        primaryPay = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter secondary income: ");
                        secondaryPay = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("======================================");
                        Console.WriteLine("\n");

                        /* Expenses */
                        Console.WriteLine("EXPENSES");
                        Console.WriteLine("Enter monthly tax deductions: ");
                        monthlyTax = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter amount spent on necessities: ");
                        necessities = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter amount spent on luxuries: ");
                        luxuries = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter amount spent on monthly payments: ");
                        monthlyPayments = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter amount spent on entertainment:");
                        entertainment = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("======================================");
                        Console.WriteLine("\n");

                        /* Calculate pay after expenses */
                        grossPay = primaryPay + secondaryPay;
                        totalPay = (primaryPay + secondaryPay) - monthlyTax - necessities - luxuries - monthlyPayments - entertainment;
                        totalExpenses = monthlyTax + necessities + luxuries + monthlyPayments + entertainment;

                        Console.WriteLine("Choose to rent or buy a house: \n1.Rent\n2.Buy");
                        mainMenu = Convert.ToDouble(Console.ReadLine());
                        break;

                    case 1:     /* Rent a home */
                        Console.WriteLine("\nRENT A HOME");
                        Console.WriteLine("Enter the rent per month");
                        totalMonthlyPayment = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("======================================");

                        /* Not affordable */
                        if (totalMonthlyPayment > (totalPay * 0.33))
                        {
                            Console.WriteLine("CONCLUSION");
                            Console.WriteLine("Pay after deductions= R" + totalPay);
                            Console.WriteLine("Total monthly payment= R" + totalMonthlyPayment);
                            Console.WriteLine("\nYOU'RE NOT ABLE TO AFFORD THIS PROPERTY AS THE MONTLY PAYMENT IS MORE THAN A 3RD OF YOUR PAY AFTER DEDUCTIONS!");
                            Console.WriteLine("\n\nPress 1 to rent a different home.");
                            Console.WriteLine("Press 2 to buy a different home.");
                            Console.WriteLine("Press 3 to show all Account info.");
                            Console.WriteLine("Press 0 to restart the program.");
                            mainMenu = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("======================================\n\n\n\n");
                        }

                        /* Affordable */
                        else if (totalMonthlyPayment < (totalPay * 0.33))
                        {
                            Console.WriteLine("CONCLUSION");
                            Console.WriteLine("Pay after deductions= R" + totalPay);
                            Console.WriteLine("Total monthly payment= R" + totalMonthlyPayment);
                            Console.WriteLine("\nYOU'RE ABLE TO AFFORD THIS PROPERTY AS THE MONTLY PAYMENT IS LESS THAN A 3RD OF YOUR PAY AFTER DEDUCTIONS!!");
                            Console.WriteLine("\n\nPress 1 to rent a different home.");
                            Console.WriteLine("Press 2 to buy a different home.");
                            Console.WriteLine("Press 3 to show all Account info.");
                            Console.WriteLine("Press 0 to restart the program.");
                            mainMenu = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("======================================\n\n\n\n");
                            }
                        break;

                    case 2:     /* Buy a home */
                        Console.WriteLine("\nBUY A HOME");
                        Console.WriteLine("Enter purchase price: ");
                        double purchasePrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter deposit amount: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter interest rate: ");
                        double interestRate = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter number of months to repay ");
                        double monthsToRepay = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("======================================");

                        /* Calculate monthly payment amount */
                        interestAmount = (purchasePrice + depositAmount) * (interestRate / 100);
                        totalMonthlyPayment = (purchasePrice + depositAmount + interestAmount) / monthsToRepay;


                        /* Not affordable */
                        if (totalMonthlyPayment > (totalPay * 0.33))
                        {
                            Console.WriteLine("CONCLUSION\n");
                            Console.WriteLine("Pay after deductions= R" + totalPay);
                            Console.WriteLine("Total monthly payment= R" + totalMonthlyPayment);
                            Console.WriteLine("\nYOU'RE NOT ABLE TO AFFORD THIS PROPERTY AS THE MONTLY PAYMENT IS MORE THAN A 3RD OF YOUR PAY AFTER DEDUCTIONS!!");
                            Console.WriteLine("\n\nPress 1 to rent a different home.");
                            Console.WriteLine("Press 2 to buy a different home.");
                            Console.WriteLine("Press 3 to show all Account info.");
                            Console.WriteLine("Press 0 to restart the program.");
                            mainMenu = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("======================================\n\n\n\n");
                        }

                        /* Affordable */
                        else if (totalMonthlyPayment < (totalPay * 0.33))
                        {
                            Console.WriteLine("CONCLUSION\n");
                            Console.WriteLine("Pay after deductions= R" + totalPay);
                            Console.WriteLine("Total monthly payment= R" + totalMonthlyPayment);
                            Console.WriteLine("\nYOU'RE ABLE TO AFFORD THIS PROPERTY AS THE MONTLY PAYMENT IS LESS THAN A 3RD OF YOUR PAY AFTER DEDUCTIONS!!");
                            Console.WriteLine("\n\nPress 1 to rent a different home.");
                            Console.WriteLine("Press 2 to buy a different home.");
                            Console.WriteLine("Press 3 to show all Account info.");
                            Console.WriteLine("Press 0 to restart the program.");
                            mainMenu = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("======================================\n\n\n\n");
                        }
                        break;

                    case 3:     /* Display all information */

                        status = totalPay * 0.33;
                        Console.WriteLine("======================================");
                        Console.WriteLine("PERSONAL INFO");
                        Console.WriteLine("Name & Surname: " + nameAndSurname);
                        Console.WriteLine("Pay before expenses: R" + grossPay);
                        Console.WriteLine("Total expenses per month: R" + totalExpenses);
                        Console.WriteLine("Pay after expenses: R" + totalPay);
                        Console.WriteLine("House payment per month: R" + totalMonthlyPayment);

                        /* Calclate loan status */
                        if (totalMonthlyPayment >= status)
                        {
                            Console.WriteLine("Status: Not Affordable");
                            Console.WriteLine("======================================");
                        }  
                        else if (totalMonthlyPayment <= status)
                        {
                            Console.WriteLine("Status: Affordable");
                            Console.WriteLine("======================================");
                        }
                        Console.WriteLine("\n\nPress 1 to rent a different home.");
                        Console.WriteLine("Press 2 to buy a different home.");
                        Console.WriteLine("Press 0 to restart the program.");
                        mainMenu = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("======================================\n\n\n\n");   
                        break;


                    default:    /* Invalid Option Handling */
                        {
                            Console.WriteLine("Please enter a valid option: ");
                            mainMenu = Convert.ToDouble(Console.ReadLine());

                        }
                        break;
                    }
                }
            }
        }