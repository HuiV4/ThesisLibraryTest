using System.Windows.Controls;
using ThesisLibrary.DataModel;

namespace ThesisLibraryTest
{
    [TestClass]
    public class UserTest
    {
        /*
            Students, professors and admins are always a type of user and inherit the base properties. 
            By loading a userList the special parameters are given to distinguish every usertype. 
            Therefore I don't think it is necessary to test every usertype, since they use the 
            loading function from the Users class!
        */

        [TestMethod]
        public void LoadUsersList_LoadedData_IsNotNull()
        {
            var users = new Users();
            var list = new List<Users>();

            var result = users.LoadUsers(list, 2);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LoadUsersList_LoadedData_IsZero()
        {
            var users = new Users();
            var list = new List<Users>();

            var result = users.LoadUsers(list, 17);
            int numberOfData = result.Count;

            Assert.AreEqual(0, numberOfData);
        }

        [TestMethod]
        public void LoadUsersList_LoadedData_Users()
        {
            var users = new Users();
            var list = new List<Users>();

            var result = users.LoadUsers(list, 2);

            Assert.IsInstanceOfType(result, typeof(List<Users>));
        }
    }
}