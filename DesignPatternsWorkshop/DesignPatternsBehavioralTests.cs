using System;
using System.Collections.Generic;
using DesignPatternsWorkshop.Behavioral;
using DesignPatternsWorkshop.Creational;
using DesignPatternsWorkshop.Structural;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DesignPatternsWorkshop
{
    [TestClass]
    public class DesignPatternsBehavioralTests
    {
        [TestMethod]
        public void ObserverPattern_TestIfObbserversWerNotified()
        {
            // Arrange
            var subject = new SubjectObserver();
            var observerA = new ObserverA(subject);
            var observerB = new ObserverB(subject);

            // Act
            const string state = "bla bla";
            subject.BuisnessMethod(state);
            subject.Notify();

            // Assert
            Assert.AreEqual(observerA.State, state);
            Assert.AreEqual(observerB.State, state);
        }

        [TestMethod]
        public void StrategyPattern_TestIfStrategy1WasCalled()
        {
            // Arrange
            var strategy1 = new Strategy1();
            var context = new Context(strategy1);

            // Act
            var result = context.Compute();
            const int excpetedResult = 1;

            // Assert
            Assert.AreEqual(result, excpetedResult);
        }

        [TestMethod]
        public void IteratorPattern_TestIfMethodResultIsIterable()
        {
            var result = IteratorPattern.EnumerateMe();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        [TestMethod]
        public void TemplateMethodPattern_TestIfStepsInTemplateMethodWereCalled()
        {
            // Arrange
            var mock = new Mock<ConcreteClass>();

            // Act
            mock.Object.TemplateMethod();

            // Assert
            mock.Verify(x => x.PrimitiveOperation1(), Times.Exactly(1));
            mock.Verify(x => x.PrimitiveOperation2(), Times.Exactly(1));
        }
        
        [TestMethod]
        public void CommandPattern_TestUseOfCommand()
        {
            var receiver = new Receiver();
            var command = new ConcreteCommand(receiver);
            var invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }

        [TestMethod]
        public void NullObjectPattern_TestIfNoExceptionThrown()
        {
            // Arrange
            var operationsCollection = new List<AbstractOperation>
            {
                new RealOperation(),
                new NullOperation()
            };

            // Act & Assert no exception thrown
            foreach (var item in operationsCollection)
            {
                item.Operation();
            }
        }

        [TestMethod]
        public void VisitorPatter_TestUseOfVisitor()
        {
            var person = new Person();
            person.Assets.Add(new BankAccount { Amount = 1000, MonthlyInterest = 0.01 });
            person.Assets.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02 });
            person.Assets.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500 });
            person.Assets.Add(new Loan { Owed = 40000, MonthlyPayment = 40 });

            var netWorthVisitor = new NetWorthVisitor();
            var incomeVisitor = new IncomeVisitor();

            person.Accept(netWorthVisitor);
            person.Accept(incomeVisitor);

            Console.WriteLine(netWorthVisitor.Total);
            Console.WriteLine(incomeVisitor.Amount);
        }

        [TestMethod]
        public void RulesPattern_TestUseOfRules()
        {
            var customer = new Customer();
            var evaluator = new RulesDiscountEvaulator();
            evaluator.CalculateDiscountPercentage(customer);
        }

        [TestMethod]
        public void StatePattern_TestUseOfState()
        {
            // Setup context in a state
            var context = new ContextState(new ConcreteStateA());

            // Issue requests, which toggles state
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }
}
