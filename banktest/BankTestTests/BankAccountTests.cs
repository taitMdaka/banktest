using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTest.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void TestExceptionCase()
        {
            BankAccount bank = new BankAccount("Tait", 0);
            try
            {
                bank.Debit(2);
            }
            catch (ArgumentException e)
            {

                StringAssert.Contains(e.Message, "amount <= 0 orngfd,m");
                return;
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Balance = 0 ");
                return;
            }
            Assert.Fail("No exception was thrown");
        }
        [TestMethod()]
        public void TestCreditCase()
        {
            BankAccount bank = new BankAccount("yyy", 2);
            bank.Debit(2);
            Assert.AreEqual(2, bank.Balace);
 
         }
        [TestMethod()]
        public void TestCreditDebitCase()
        {
            BankAccount bank = new BankAccount("yyy", 2);
            bank.Debit(2);
            bank.Credit(2);
            Assert.AreEqual(2, bank.Balace);

        }

    }
}