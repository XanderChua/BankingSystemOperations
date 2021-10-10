using System;
using System.Threading;
//I want to design a banking system here we perform different banking system operations . But all the operations has to be operated by different persons.
//And these operators are to be assigned by the manager everyday. you have to go to the bank continuously for one week to execute these following operations
//1. APPLAY FOR A LOAN  2. DOCUMENT VERIFICATION 3 . NEGOTIATING THE LOAN DETAILS 4. FINAL APPROVAL AND DEPOSIT  5. WITHDRAWAL OF
//Now show me the operations and their operator details of the bank for one week.

namespace BankingSystemOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            BankOperatorManagement bankOpMgmt = new BankOperatorManagement();
            string[] arrDay = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "ByeBye" };
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("--Banking System Operations--");
                Console.WriteLine("1. Add bank operator");
                Console.WriteLine("2. Assign bank operator");
                Console.WriteLine("3. End of week report");
                Console.WriteLine("4. Exit");
                int input = Int32.Parse(Console.ReadLine());
                if (input == 1)
                {
                    int bankOperatorID = 1;
                    foreach (var bankoperator in bankOpMgmt.BankOperatorDictObj)//auto generate unique ID
                    {
                        bankOperatorID++;
                    }
                    Console.WriteLine("Enter name:");
                    string bankOperatorName = Console.ReadLine();
                    bankOpMgmt.BankOperatorDictObj.Add(bankOperatorID, new BankOperator(bankOperatorID, bankOperatorName, false, false, 0, false, 0));
                    Console.WriteLine(bankOperatorName + " added!\n");
                }
                else if (input == 2)
                {
                    Console.WriteLine("List of bank operators:");
                    foreach (var bankoperator in bankOpMgmt.BankOperatorDictObj)
                    {
                        Console.WriteLine("ID: " + bankoperator.Key + " Name: " + bankoperator.Value.operatorName);
                    }
                    int inputAssign = Int32.Parse(Console.ReadLine());
                    BankOperator bankOperatorObj = null;
                    foreach (var bankoperator in bankOpMgmt.BankOperatorDictObj)
                    {
                        if (int.Equals(inputAssign, bankoperator.Key))
                        {
                            bankOperatorObj = bankoperator.Value;
                            if (bankOperatorObj != null)
                            {
                                if (arrDay[0] == "Monday")
                                {
                                    Console.WriteLine("--Monday Task--");
                                    Console.WriteLine("Apply loan?");
                                    Console.WriteLine("1) Yes");
                                    Console.WriteLine("2) No");
                                    int inputApplyLoan = Int32.Parse(Console.ReadLine());
                                    if (inputApplyLoan == 1)
                                    {
                                        bankOpMgmt.BankOperatorDictObj[inputAssign].applyLoan = true;
                                        Console.WriteLine("Loan applied");
                                        string s1 = "Loan application status: " + bankOpMgmt.BankOperatorDictObj[inputAssign].applyLoan +
                                            "\nApplied by: " + bankOpMgmt.BankOperatorDictObj[inputAssign].operatorName;
                                        bankOpMgmt.ReportList.Add(s1); //add report to list
                                        bankOpMgmt.BankOperatorDictObj.Remove(bankoperator.Key); //after selected remove bank operator
                                        arrDay[0] += 1; //move to next day
                                    }
                                    else if (inputApplyLoan == 2)
                                    {
                                        bankOpMgmt.BankOperatorDictObj[inputAssign].applyLoan = false;
                                        Console.WriteLine("Loan not applied");
                                    }
                                }
                                else if (arrDay[1] == "Tuesday")
                                {
                                    Console.WriteLine("--Tuesday Task--");
                                    Console.WriteLine("Verify documents?");
                                    Console.WriteLine("1) Yes");
                                    Console.WriteLine("2) No");
                                    int inputDocVerify = Int32.Parse(Console.ReadLine());
                                    if (inputDocVerify == 1)
                                    {
                                        bankOpMgmt.BankOperatorDictObj[inputAssign].docVerification = true;
                                        Console.WriteLine("Documents verified");
                                        string s2 = "Document verification status: " + bankOpMgmt.BankOperatorDictObj[inputAssign].docVerification +
                                            "\nApplied by: " + bankOpMgmt.BankOperatorDictObj[inputAssign].operatorName; ;
                                        bankOpMgmt.ReportList.Add(s2);
                                        bankOpMgmt.BankOperatorDictObj.Remove(bankoperator.Key);
                                        arrDay[1] += 1;
                                    }
                                    else if (inputDocVerify == 2)
                                    {
                                        bankOpMgmt.BankOperatorDictObj[inputAssign].docVerification = false;
                                        Console.WriteLine("Documents rejected");
                                    }
                                }
                                else if (arrDay[2] == "Wednesday")
                                {
                                    Console.WriteLine("--Wednesday Task--");
                                    Console.WriteLine("Negotiate Loan:");
                                    double inputLoan = Double.Parse(Console.ReadLine());
                                    bankOpMgmt.BankOperatorDictObj[inputAssign].negotiateLoan = inputLoan;
                                    Console.WriteLine("Negotiation done");
                                    string s3 = "Loan price negotiated: " + bankOpMgmt.BankOperatorDictObj[inputAssign].negotiateLoan +
                                        "\nApplied by: " + bankOpMgmt.BankOperatorDictObj[inputAssign].operatorName;
                                    bankOpMgmt.TempNegoLoanObj.Add(inputLoan);
                                    bankOpMgmt.ReportList.Add(s3);
                                    bankOpMgmt.BankOperatorDictObj.Remove(bankoperator.Key);
                                    arrDay[2] += 1;
                                }
                                else if (arrDay[3] == "Thursday")
                                {
                                    Console.WriteLine("--Thursday Task--");
                                    Console.WriteLine("Final approval confirmation");
                                    Console.WriteLine("1) Confirm");
                                    Console.WriteLine("2) Reject");
                                    int inputFinal = Int32.Parse(Console.ReadLine());
                                    if (inputFinal == 1)
                                    {
                                        bankOpMgmt.BankOperatorDictObj[inputAssign].finalApproval = true;
                                        Console.WriteLine("Final approval confirmed");
                                        string s4 = "Final approval status: " + bankOpMgmt.BankOperatorDictObj[inputAssign].finalApproval +
                                            "\nApplied by: " + bankOpMgmt.BankOperatorDictObj[inputAssign].operatorName; ;
                                        bankOpMgmt.ReportList.Add(s4);
                                        bankOpMgmt.BankOperatorDictObj.Remove(bankoperator.Key);
                                        arrDay[3] += 1;
                                    }
                                    else if (inputFinal == 2)
                                    {
                                        bankOpMgmt.BankOperatorDictObj[inputAssign].finalApproval = false;
                                        Console.WriteLine("Final approval denied");
                                    }
                                }
                                else if (arrDay[4] == "Friday")
                                {
                                    Console.WriteLine("--Friday Task--");
                                    Console.WriteLine("Loan successfully withdrawn!!\n");
                                    foreach (var loan in bankOpMgmt.TempNegoLoanObj)
                                    {
                                        string s5 = "Loan withdrawn amount: " + loan +
                                        "\nApplied by: " + bankOpMgmt.BankOperatorDictObj[inputAssign].operatorName;
                                        bankOpMgmt.ReportList.Add(s5);
                                        bankOpMgmt.BankOperatorDictObj.Remove(bankoperator.Key);                                       
                                    }
                                    foreach (var report in bankOpMgmt.ReportList)
                                    {
                                        Console.WriteLine(report);
                                    }
                                    Thread.Sleep(3000);
                                    Console.WriteLine("Goodbye...");
                                    loop = false;
                                }
                            }
                        }
                    }
                }//2
                if (input == 4)
                {
                    loop = false;
                }//while loop end
            }
        }
    }
}
