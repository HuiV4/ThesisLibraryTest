using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using ThesisLibrary.DataModel;

namespace ThesisLibraryTest
{
    [TestClass]
    public class DepartmentTest
    {
        [TestMethod]
        public void LoadDepartmentList_LoadedList_IsNotNull()
        {
            var dept = new Department();

            var result = dept.LoadDepartments();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LoadDepartmentList_LoadedList_CountNotEqualsZero()
        {
            var dept = new Department();

            var result = dept.LoadDepartments();

            Assert.AreNotEqual(0, result.Count);
        }

        [TestMethod]
        public void LoadDepartmentList_LoadedList_CountEqualsCurrentDepartments()
        {
            var dept = new Department();
            int currentDepatrtments = 4;

            var result = dept.LoadDepartments();

            Assert.AreEqual(currentDepatrtments, result.Count);
        }
    }
}
