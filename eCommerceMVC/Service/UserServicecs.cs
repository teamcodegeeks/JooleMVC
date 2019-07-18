using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eCommerceMVC.Models;
using eCommerceMVC.Repository;
using eCommerceMVC.UoW;

namespace eCommerceMVC.Service
{
    //Webforms page life cycle
    public class UserServicecs
    {
        User tempuserinfo = new User();
        public User userinfo(string nameemail)
        {
            using (var unitofwork = new UnitofWork(new JoojleEntities()))
            {
                List<User> tempuser = unitofwork.UserRepository.Get(
                    filter: u => u.UserName == nameemail
                    ).ToList();
                if (tempuser.Count != 0) return tempuserinfo = tempuser[0];
                else
                {
                    tempuser = unitofwork.UserRepository.Get(
                        filter: u => u.Email == nameemail
                        ).ToList();
                    if (tempuser.Count != 0) return tempuserinfo = tempuser[0];
                }
                return null;
            }
        }
        public bool Login(string password) {
            string temppassword = tempuserinfo.Password;
            if (temppassword == password) return true;
            else return false;
        }
        public void register(string username, string password, string email, string imgUrl) {
            using (var unitofwork = new UnitofWork(new JoojleEntities())) {
                User tempuser = new User();
                tempuser.UserName = username;
                tempuser.Password = password;
                tempuser.Email = email;
                tempuser.Picture = imgUrl;
                tempuser.RoleDescription = "Customer";
                tempuser.UserRoleId = 2;
                unitofwork.UserRepository.Insert(tempuser);
                unitofwork.Save();
            }
        }
    }


}

