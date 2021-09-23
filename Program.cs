using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.IO;
// using CsvHelper;
// using CsvHelper.Configuration;

namespace FirstBankOfSuncoast
{
  class Program
  {
    //            1)NAME      
    //                              2)INPUT
    //       3)OUTPUT 
    static string PromptForString(string prompt){
      //4)WORK
      Console.Write(prompt);
      var userInput = Console.ReadLine();
      return userInput;
    }//End of PromptForString

    static int PromptForInteger(string prompt){
      Console.Write(prompt);
      int numberInput;
      var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out numberInput);
      if(isThisGoodInput)
      {
        return numberInput;
      }
      else
      {
        Console.WriteLine("Sorry. Invalid input.");
        return 0;
      }
    }//end PromptForInteger      
      
    //Name ShowGreeting
    //Input none (void)
    //Output none (void)
    //Work A bunch of WriteLines
    //Access Level Public or Private
    static void ShowMenu(){
      Console.WriteLine("Welcome to First Bank of Suncoast.");
      Console.WriteLine();
      Console.WriteLine("Choose an option from this menu: ");
      Console.WriteLine();
      Console.WriteLine("[W]ithdraw");
      Console.WriteLine("[D]eposit");
      Console.WriteLine("[S]how Transactions");
      Console.WriteLine("[B]alances");
      Console.WriteLine("[Q]uit");
      Console.WriteLine();
    }
    static void Main(string[] args)
    {
      var sampleTransaction = new Transaction(){};
      //lets get some d*mmy data 
      //if a user deposits 10 to their savings, 
      //******* STYLE 1******* (my preferred style - step by step)
      // var tenDollarSavingsDeposit = new Transaction();
      // tenDollarSavingsDeposit.Type = "Deposit";
      // tenDollarSavingsDeposit.Amount = 10;
      // tenDollarSavingsDeposit.Account = "Savings"
      
      //*******STYLE 2*******
      //included the new transaction into the other format above so I am commenting out the line bellow
      //  var tenDollarSavingsDeposit = transactions.Add(tenDollarSavingsDeposit);//I just made a deposit
      //then withdraws 8 from their savings, 
      //included the new transaction into the other format above so I am commenting out the line bellow
      // var eightDollarWithdraw = transactions.Add(eightDollarWithdraw); 
      //then deposits 25 to their checking, 
      //included the new transaction into the other format above so I am commenting out the line bellow
      // var twentyFiveDollarDeposit = transactions.Add(twentyFiveDollarDeposit);
      //they have three transactions to consider. 
      //Compute the checking and saving balance
      //using the transaction list, when needed. 
      //In this case, their savings balance is 
      //2 and their checking balance is 25.

      Console.WriteLine(sampleTransaction.Description());

      var keepGoing = true;
      //empty list of transactions
      var transactions = new List<Transaction>(){
        new Transaction()
        {
        Amount = 10,
        Type = "Deposit",
        Account = "Savings"
        },
        new Transaction()
        {
        Amount = 8,
        Type = "Withdraw",
        Account = "Savings"
        },
        new Transaction()
        {
        Type = "Deposit",
        Account = "Checking",
        Amount = 25,
        }
      };
      while (keepGoing)
      {
        ShowMenu();
        // Console.WriteLine("> ");
        // var menuOption = Console.ReadLine().ToUpper();
        var menuOption = PromptForString("> ");   
        if(menuOption == "W"){
          //I need to check if the amount is multiple of twenty and if not, ask the user to enter only multiple of 20
          //
          //I need to check the currentBalance to make sure is greater than the withdraw amount
          //Substract amount being withdrawn from the current balance
          //Ask user if he/she would like to print a receipt
          //Ask user if she /he would like to perform another transaction
        }
        else
        if(menuOption == "D"){
          //All I need to know is the amount and if the amount will be deposited into checkings or savings
          //Add amount being deposited to current balance
          //Display a message that says ATM deposits may take 3 business days to be processed
          //Ask the user if he/she would like to print a receipt
          //Ask the user if they would like to perform another transaction
          //If user does not want to perform another transaction, system quits.
        }
        else
        if(menuOption == "S"){
          //Show transactions
          //Print the number of transactions
          Console.WriteLine($"There are {transactions.Count} transactions");
          //For each transaction on our transactions list make
          foreach (var transaction in transactions)
          {
          //-Description of that transaction
          var descriptionOfTransaction = transaction.Description();  

          //-Print the description to the user
          Console.WriteLine(descriptionOfTransaction);
          }
        }
        else
        if(menuOption == "B"){
          //Displays Balances
          //Is going to require existing transactions
        }
        else
        if(menuOption == "Q"){
          //Quits
          keepGoing = false;
        }
        else{Console.WriteLine("Unknown menu option.");}
    }

      // The application should store a history of transactions in a SINGLE List<Transaction>. 
      //Your task is to design the Transaction class to support both checking and savings as well as deposits and withdraws.
      // The application should load past transactions from a file when it first starts.
      // As a user I should be able to see the list of transactions designated savings.
      // As a user I should be able to see the list of transactions designated checking.
      // Never allow withdrawing more money than is available. That is, we cannot allow our checking or savings balances to go negative.
      // When prompting for an amount to deposit or withdraw always ensure the amount is positive. The value we store in the Transaction shall be positive as well. (e.g. a Transaction that is a withdraw of 25 both inputs and records a positive 25)
      // As a user I should have a menu option to make a deposit transaction for savings.
      // As a user I should have a menu option to make a deposit transaction for checking.
      // As a user I should have a menu option to make a withdraw transaction for savings.
      // As a user I should have a menu option to make a withdraw transaction for checking.
      // As a user I should have a menu option to see the balance of my savings and checking.
      // The application should, after each transaction, write all the transactions to a file. This is the same file the application loads.
    }//end of Main
  }//end of program
}//end of namespace
