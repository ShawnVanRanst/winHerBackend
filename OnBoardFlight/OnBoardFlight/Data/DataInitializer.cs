using OnBoardFlight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnBoardFlight.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext _dbContext;

        public DataInitializer(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public void InitializeData()
        {
            Flight f = new Flight() { Id = 2, Destination = "test", Origin = "testa" };
            _dbContext.Flights.Add(f);
            _dbContext.SaveChanges();
        }
    }
}
