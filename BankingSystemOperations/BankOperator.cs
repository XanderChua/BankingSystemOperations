using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemOperations
{
    class BankOperator
    {
        public int operatorID { get; set; }
        public string operatorName { get; set; }
        public bool applyLoan { get; set; }
        public bool docVerification { get; set; }
        public double negotiateLoan { get; set; }
        public bool finalApproval { get; set; }
        public double withdrawLoan { get; set; }
        public BankOperator(int id, string name, bool applyloan, bool verification, double nego, bool final, double withdraw)
        {
            operatorID = id;
            operatorName = name;
            applyLoan = applyloan;
            docVerification = verification;
            negotiateLoan = nego;
            finalApproval = final;
            withdrawLoan = withdraw;
        }
    }
    
}
