using markustei.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace markustei.DL
{
    public class UserPostDL
    {
        DatabaseEntities db;
        #region UserPost
        public List<UserPost> GetActiveUserPostsList()
        {
            List<UserPost> UserPosts;
            DatabaseEntities db = new DatabaseEntities();
            UserPosts = db.UserPosts.Where(x => x.IsActive == 1).ToList();
            return UserPosts;
        }

        public List<UserPost> GetInactiveUserPosts()
        {
            List<UserPost> UserPost;
            DatabaseEntities db = new DatabaseEntities();
            UserPost = db.UserPosts.Where(x => x.IsActive == 0).ToList();
            return UserPost;
        }

        public UserPost getUserPostById(int _Id, DatabaseEntities de = null)
        {
            DatabaseEntities db = new DatabaseEntities();
            if (de != null)
            {
                UserPost UserPosts = de.UserPosts.Where(x => x.IsActive == 1).FirstOrDefault(x => x.Id == _Id);
                return UserPosts;
            }
            UserPost UserPost = db.UserPosts.Where(x => x.IsActive == 1).FirstOrDefault(x => x.Id == _Id);

            return UserPost;
        }

        public bool AddUserPost(UserPost _UserPost)
        {
            using (db = new DatabaseEntities())
            {
                db.UserPosts.Add(_UserPost);
                db.SaveChanges();
            }
            return true;
        }

        public bool UpdateUserPost(UserPost _UserPost, DatabaseEntities de = null)
        {
            try
            {
                if (de != null)
                {
                    de.Entry(_UserPost).State = System.Data.Entity.EntityState.Modified;
                    de.SaveChanges();
                    return true;
                }
                using (db = new DatabaseEntities())
                {
                    db.Entry(_UserPost).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

        }

        #endregion
    }
}