using Microsoft.EntityFrameworkCore;

namespace RateMyFood.MVC.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly RateMyFoodDbContext _rateMyFoodDbContext;

        public PieRepository(RateMyFoodDbContext rateMyFoodDbContext)
        {
             _rateMyFoodDbContext = rateMyFoodDbContext;
        }
        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _rateMyFoodDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _rateMyFoodDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public void CreatePie(Pie pie)
        {
            throw new NotImplementedException();
        }

        public Pie? GetPieById(int pieId)
        {
            return _rateMyFoodDbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public void UpdatePie(Pie pie)
        {
            throw new NotImplementedException();
        }
    }
}
