using LoanEase;

namespace LoanEaseClassUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Loan_BorrowerIsMember_InterestThreePercent()
        {
            //Arrange
            Borrower b = new Borrower("Bogart", "Makatigbas", true, 0);

            //Act and Assert
            Assert.AreEqual(Calculate.Loan(true, 100), 103);
        }

        [Test]
        public void Loan_BorrowerIsNotMember_InterestFivePercent()
        {
            //Arrange
            Borrower b = new Borrower("Bogart", "Makatigbas", false, 0);

            //Act and Assert
            Assert.AreEqual(Calculate.Loan(false, 100), 105);
        }
    }
}