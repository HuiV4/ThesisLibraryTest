using ThesisLibrary.DataModel;

namespace ThesisLibraryTest
{
    [TestClass]
    public class ThesisTest
    {
        [TestMethod]
        public void LoadThesisListTest_LoadedData_IsOfType_List()
        {
            var thesis = new Thesis();
            var result = thesis.LoadThesisList();
            Assert.IsInstanceOfType(result, typeof(List<Thesis>));
        }

        [TestMethod]
        public void LoadThesisListTest_ListIsNotNull()
        {
            var thesis = new Thesis();
            var result = thesis.LoadThesisList();
            Assert.IsNotNull(result);
        }
    }
}