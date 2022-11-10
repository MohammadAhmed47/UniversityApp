using markustei.DL;
using markustei.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace markustei.BL
{
    public class UserPostBL
    {
        #region UserPost
        public List<UserPost> GetActiveUserPostList()
        {
            return new UserPostDL().GetActiveUserPostsList();
        }

        public List<UserPost> GetInactiveUserPostList()
        {
            return new UserPostDL().GetInactiveUserPosts();
        }

        public UserPost GetUserPostbyId(int _id, DatabaseEntities de = null)
        {
            return new UserPostDL().getUserPostById(_id, de);
        }

        public bool AddUserPost(UserPost _UserPost)
        {
            if (_UserPost.IsActive == null || _UserPost.CreatedAt == null)
                return false;
            return new UserPostDL().AddUserPost(_UserPost);
        }

        public bool UpdateUserPost(UserPost _UserPost, DatabaseEntities de = null)
        {
            if (_UserPost.IsActive == null || _UserPost.CreatedAt == null)
                return false;
            return new UserPostDL().UpdateUserPost(_UserPost, de);
        }

        #endregion
    }
}