﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    class DbJobApplication : IDataAccess<JobApplication>
    {
        DbConnection conn = new DbConnection();
        public bool Create(JobApplication obj)

        {
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    try
                    {
                        //cmd.CommandText = "INSERT INTO JobCV (Title, ApplierId) VALUES (@Title, @ApplierId)";
                        //cmd.Parameters.AddWithValue("Title", obj.Title);
                        //cmd.Parameters.AddWithValue("ApplierId", obj.ApplierId);
                        //cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException)
                    {
                        return false;
                    }
                }
            }

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public JobApplication Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<JobApplication> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(JobApplication obj)
        {
            throw new NotImplementedException();
        }
    }
}
