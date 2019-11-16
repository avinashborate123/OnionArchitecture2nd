namespace CoreService
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CoreData;

    public interface IUserProfileService
    {
        UserProfile GetUserProfile(long id);
    }
}