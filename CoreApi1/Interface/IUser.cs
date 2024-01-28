using CoreApi1.Model;

namespace CoreApi1.Interface
{
    public interface IUser
    {
         Task<List<User>> GetUserList();
         Task<User> GetUserListById(Guid ID);
         bool InsertUserData(User user);
         bool UpdateUserData(User user);
         bool DeleteUserData(Guid ID);
    }
}
