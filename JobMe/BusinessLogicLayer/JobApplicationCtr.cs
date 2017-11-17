﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    class JobApplicationCtr : IController<JobApplication>
    {
        private DbJobApplication dbJobApplication = new DbJobApplication();

        /// <summary>
        /// Creates a jobapplication by calling the method Jobapplication in DBAccesLayer
        /// </summary>
        /// <param name="obj"></param>
        public void Create(JobApplication obj)
        {
            dbJobApplication.Create(obj);
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
