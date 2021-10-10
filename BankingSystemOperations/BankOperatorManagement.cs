using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystemOperations
{
    class BankOperatorManagement
    {
        private Dictionary<int, BankOperator> _bankoperatordict;
        private List<string> _reportList;
        private List<double> _tempNegoLoan;
        
        public Dictionary<int, BankOperator> BankOperatorDictObj
        {
            get
            {
                if (_bankoperatordict == null)
                {
                    _bankoperatordict = new Dictionary<int, BankOperator>();
                }
                return _bankoperatordict;
            }
            private set
            {
                _bankoperatordict = value;
            }
        }
        public List<string> ReportList
        {
            get
            {
                if (_reportList == null)
                {
                    _reportList = new List<string>();
                }
                return _reportList;
            }
            private set
            {
                _reportList = value;
            }
        }
        public List<double> TempNegoLoanObj
        {
            get
            {
                if (_tempNegoLoan == null)
                {
                    _tempNegoLoan = new List<double>();
                }
                return _tempNegoLoan;
            }
            private set
            {
                _tempNegoLoan = value;
            }
        }
    }
}
