﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ShareCar.Entity;
using ShareCar.Data;

namespace ShareCar.Repository
{
    public class UserRepo
    {
        
        public Boolean UserLogin(User user)
        {
            try
            {
                string query = "select * from user where username = '" + user.username + "' and password = '" + user.password + "';";
                var dt = DataAccess.GetDataTable(query);

                if (dt.DataSet.Tables[0].Rows.Count == 1)
                {
                    return true;
                }
                else
                    return false;

            }
            catch (Exception exception)
            {
                //MessageBox.Show(Console.WriteLine(ex));
                return false;
            }

        }
    }
}
