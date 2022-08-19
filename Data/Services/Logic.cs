using SPWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPWebApplication.Data.Services
{
    public class Logic : ILogicServices
    {
        //Injecting AppDpContext 
        private readonly AppDbContext _context;
        public Logic(AppDbContext context)
        {
            _context = context;
        }

        public void Add(FAQ fAQ)
        {
             _context.Add(fAQ);
            _context.SaveChanges();
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<FAQ>GetAll()
        {
            var result = _context.FAQs.ToList();
            return result;
        }

        public FAQ GetById(int id)
        {
            throw new NotImplementedException();
        }

        public FAQ Update(int id, FAQ newFAQ)
        {
            throw new NotImplementedException();
        }
    }
}
