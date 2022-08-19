using SPWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPWebApplication.Data.Services
{
    public interface ILogicServices
    {

        IEnumerable<FAQ> GetAll(); //Get all FAQ method
        FAQ GetById(int id); // Get by ID method
        void Add(FAQ fAQ); // Create FAQ method
        FAQ Update(int id, FAQ newFAQ); //Update FAQ record
        void Delete(int id); // Delete single FAQ record
    }
}
