﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

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
      var isThisGoodInput = false;
      do
      {
        var stringInput = PromptForString(prompt);
        int numberInput;
        isThisGoodInput = Int32.TryParse(stringInput, out numberInput);
        if(isThisGoodInput){

          return numberInput;
        }
        else
        {
          Console.WriteLine("That input was not valid.");
        }
      };//End do
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
        Console.WriteLine("[S]ow Transactions");
        Console.WriteLine("[B]alances");
        Console.WriteLine("[Q]uit");
        Console.WriteLine();
      }
    static void Main(string[] args)
    {
      

      var keepGoing = true;
      while (keepGoing)
      {
        ShowMenu();
        // Console.WriteLine("> ");
        // var menuOption = Console.ReadLine().ToUpper();
        var menuOption = PromptForString("> ");   
        if(menuOption == "W"){}
        else
        if(menuOption == "D"){}
        else
        if(menuOption == "S"){}
        else
        if(menuOption == "B"){}
        else
        if(menuOption == "Q"){
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
