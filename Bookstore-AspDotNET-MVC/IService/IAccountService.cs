﻿using Bookstore_AspDotNET_MVC.DTO;
using Bookstore_AspDotNET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_AspDotNET_MVC.IService
{
    public interface IAccountService
    {
        AccountPagineDTO GetAccounts(int currentPage);

        Userinfor findUserById(long id);

        Task<bool> addUser(Userinfor user);


        Task<bool> updateUser(Userinfor user);
        Task<bool> deleteUser(Userinfor user);

        long getTotalUser();

        string checkUserExist(Userinfor userinfor);
        string checkUserUpdateExist(Userinfor userinfor);


    }
}
