using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validator.Abstract;
using Validator.Concrete;
using Validator.Concrete.Strategies;

namespace ValidatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IValidator myValidator = new BasicValidator();
            myValidator.AddValidator((new PasswordValidator("rucsi", "rucsi")));
            myValidator.AddValidator(new EmailValidator("user@test.com"));
            myValidator.AddValidator(new IntervalValidator("10", 5, 11));
            Assert.AreEqual(true, myValidator.Validate());
            Assert.AreEqual(false, new PasswordValidator("rucsi", "pacsi").Validate());
            Assert.AreEqual(false, new EmailValidator("rucsmaster").Validate());
            Assert.AreEqual(false, new IntervalValidator("10", 11, 20).Validate());
        }
    }
}
