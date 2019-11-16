namespace CoreService
{
    using System.Collections.Generic;
    using CoreData;
    using CoreRepository;
    using CoreService;

    public class UserService : IUserService
    {
        private IRepository<User> userRepository;
        private IRepository<UserProfile> userProfileRepository;

        public UserService(
            IRepository<User> userRepository,
            IRepository<UserProfile> userProfileRepository)
        {
            this.userRepository = userRepository;
            this.userProfileRepository = userProfileRepository;
        }

        public IEnumerable<User> GetUsers()
        {
            return this.userRepository.GetAll();
        }

        public User GetUser(long id)
        {
            return this.userRepository.Get(id);
        }

        public void InsertUser(User user)
        {
            this.userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            this.userRepository.Update(user);
        }

        public void DeleteUser(long id)
        {
            UserProfile userProfile = this.userProfileRepository.Get(id);
            this.userProfileRepository.Remove(userProfile);
            User user = this.GetUser(id);
            this.userRepository.Remove(user);
            this.userRepository.SaveChanges();
        }
    }
}