namespace CoreService
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CoreData;
    using CoreRepository;

    public class UserProfileService : IUserProfileService
    {
        private IRepository<UserProfile> userProfileRepository;

        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }

        public UserProfile GetUserProfile(long id)
        {
            return this.userProfileRepository.Get(id);
        }
    }
}