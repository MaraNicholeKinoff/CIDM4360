

namespace OnlineAuction.Models
{
    /// <summary>
    /// This defines a generic user class for derived classes to share the properties and methods from
    /// </summary>
    public class User
    {
        #region Properties

            public string UserName { get; set; }
            public string Password { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            
        #endregion

        #region Methods

            public static void CreateAccount() {}
            public static void Login() {}
            public static void LogOut() {}
            public static void ChangeStatus() {}
            
        #endregion
    }
}