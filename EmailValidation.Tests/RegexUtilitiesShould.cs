using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EmailValidation.Tests
{
    [TestClass]
    public class RegexUtilitiesShould
    {
        private readonly string[] emailAddresses =
        {
            // Valid
            "david.jones@proseware.com",
            "d.j@server1.proseware.com",
            "jones@ms1.proseware.com",            
            "j@proseware.com9",
            "js#internal@proseware.com",
            "j_9@[129.126.118.1]",     
            "js@proseware.com9",
            "j.s@server1.proseware.com",
            "\"j\\\"s\\\"\"@proseware.com",
            "js@contoso.中国",
            "example+a@gmail.com",
            //Invalid
            "j.@server1.proseware.com",
             "j..s@proseware.com",
            "js*@proseware.com",
            "js@proseware..com"
        };

        [TestMethod]
        public void Return_true_when_the_email_is_email0()
        {
            var emailAddress = emailAddresses[0];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return_true_when_the_email_is_email1()
        {
            var emailAddress = emailAddresses[1];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return_true_when_the_email_is_email2()
        {
            var emailAddress = emailAddresses[2];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return_true_when_the_email_is_email3()
        {
            var emailAddress = emailAddresses[3];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return_true_when_the_email_is_email4()
        {
            var emailAddress = emailAddresses[4];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return_true_when_the_email_is_email5()
        {
            var emailAddress = emailAddresses[5];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return_true_when_the_email_is_email6()
        {
            var emailAddress = emailAddresses[6];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return_true_when_the_email_is_email7()
        {
            var emailAddress = emailAddresses[7];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return_true_when_the_email_is_email8()
        {
            var emailAddress = emailAddresses[8];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return_true_when_the_email_is_email9()
        {
            var emailAddress = emailAddresses[9];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return_true_when_the_email_is_email10()
        {
            var emailAddress = emailAddresses[10];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Return_false_when_the_email_is_email11()
        {
            var emailAddress = emailAddresses[11];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_false_when_the_email_is_email12()
        {
            var emailAddress = emailAddresses[12];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_false_when_the_email_is_email13()
        {
            var emailAddress = emailAddresses[13];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Return_false_when_the_email_is_email14()
        {
            var emailAddress = emailAddresses[14];

            var result = RegexUtilities.IsValidEmail(emailAddress);
            Assert.IsFalse(result);
        }
    }
}
