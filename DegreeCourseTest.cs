using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisLibrary.DataModel;

namespace ThesisLibraryTest
{
    [TestClass]
    public class DegreeCourseTest
    {
        [TestMethod]
        public void DegreeCourseList_LoadedList_IsNotNull()
        {
            DegreeCourse degree = new DegreeCourse();

            var result = degree.LoadDegreeCourses();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DegreeCourseList_LoadedList_CountNotEqualsZero()
        {
            DegreeCourse degree = new DegreeCourse();

            var result = degree.LoadDegreeCourses();

            Assert.AreNotEqual(0, result.Count);
        }

        [TestMethod]
        public void DegreeCourseList_LoadedList_EqualsCurrentDegreeCourses()
        {
            DegreeCourse degree = new DegreeCourse();
            int currentDegreeCourses = 19;

            var result = degree.LoadDegreeCourses();

            Assert.AreEqual(19, result.Count);
        }
    }
}
