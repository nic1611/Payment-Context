using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1(){
            var subscription = new Subscription(null);
            var student = new Student("Andre","lala","1234567","email@email.com");
            student.AddSubscriptions(subscription);

        }
    }
}