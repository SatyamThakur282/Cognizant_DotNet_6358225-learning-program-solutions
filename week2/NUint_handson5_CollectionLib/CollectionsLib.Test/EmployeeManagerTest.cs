using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLib.Test
{
    [TestFixture]
    public class EmployeeManagerTests
    {
        private EmployeeManager _manager;

        [SetUp]
        public void Setup()
        {
            _manager = new EmployeeManager();
        }

        [Test]
        public void GetEmployees_NoNullValues_AllItemsNotNull()
        {
            var employees = _manager.GetEmployees();

            Assert.That(employees, Is.All.Not.Null);
        }

        [Test]
        public void GetEmployees_EmployeeWithId100Exists_ReturnsTrue()
        {
            var employees = _manager.GetEmployees();

            bool exists = employees.Any(e => e.EmpId == 100);

            Assert.That(exists, Is.True);
        }

        [Test]
        public void GetEmployees_AllEmployeesHaveUniqueEmpIds_ListIsUnique()
        {
            var employees = _manager.GetEmployees();

            var uniqueEmpIds = employees.Select(e => e.EmpId).Distinct().Count();

            Assert.That(uniqueEmpIds, Is.EqualTo(employees.Count));
        }

        [Test]
        public void GetEmployees_And_GetEmployeesWhoJoinedInPreviousYears_AreEqual_ClassicAssert()
        {
            var list1 = _manager.GetEmployees();
            var list2 = _manager.GetEmployeesWhoJoinedInPreviousYears();

            CollectionAssert.AreEqual(list1, list2); // classic model
        }

        [Test]
        public void GetEmployees_And_GetEmployeesWhoJoinedInPreviousYears_AreEqual_ConstraintModel()
        {
            var list1 = _manager.GetEmployees();
            var list2 = _manager.GetEmployeesWhoJoinedInPreviousYears();

            Assert.That(list1, Is.EqualTo(list2)); // constraint model
        }
    }
}
