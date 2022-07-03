using PasswordValidator;

namespace PasswordValidator.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            //Arrange
            string password = "hgtyU#8g";
            bool expected = true;
            //Act
            bool actual = PasswordValidator_ClassLib.PasswordValidator.ValidatePassword (password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_4Symbols_ReturnsFalse()
        {
            //Arrange
            string password = "qtgb&";
            //Act
            bool actual = PasswordValidator_ClassLib.PasswordValidator.ValidatePassword(password);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void Check_30Symbols_ReturnsFalse()
        {
            //Arrange
            string password = "POGTREWWQasdfghjkl;$3gfd21";
            bool expected = false;
            //Act
            bool actual = PasswordValidator_ClassLib.PasswordValidator.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithDigits_ReturnsTrue()
        {
            //Arrange
            string password = "bgtvfrcde123#A";
            bool expected = true;
            //Act
            bool actual = PasswordValidator_ClassLib.PasswordValidator.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutDigits_ReturnsFalse()
        {
            //Arrange
            string password = "Zseqscawdx()";
            bool expected = false;
            //Act
            bool actual = PasswordValidator_ClassLib.PasswordValidator.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Check_PasswordWithSpecSymbols_ReturnsTrue()
        {
            //Arrange
            string password = "Bg123!@#qazwsx";
            bool expected = true;
            //Act
            bool actual = PasswordValidator_ClassLib.PasswordValidator.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Check_PasswordWithoutSpecSymbols_ReturnsFalse()
        {
            //Arrange
            string password = "pkmlijlgtyh";
            bool expected = false;
            //Act
            bool actual = PasswordValidator_ClassLib.PasswordValidator.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithCapsSymbols_ReturnsTrue()
        {
            //Arrange
            string password = "GFD$#1frtgbn";
            bool expected = true;
            //Act
            bool actual = PasswordValidator_ClassLib.PasswordValidator.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutCapsSymbols_ReturnsFalse()
        {
            //Arrange
            string password = "tfcngrfyhb";
            bool expected = false;
            //Act
            bool actual = PasswordValidator_ClassLib.PasswordValidator.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithLowerSymbols_ReturnsTrue()
        {
            //Arrange
            string password = "#$3IjHyGbGf";
            bool expected = true;
            //Act
            bool actual = PasswordValidator_ClassLib.PasswordValidator.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutLowerSymbols_ReturnsFalse()
        {
            //Arrange
            string password = "TYUGHJBNM";
            bool expected = false;
            //Act
            bool actual = PasswordValidator_ClassLib.PasswordValidator.ValidatePassword(password);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}