namespace RateMyFood.MVC.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie? GetPieById(int pieId);
        void CreatePie(Pie pie);
        IEnumerable<Pie> SearchPies(string searchQuery);
        void UpdatePie(Pie pie);

    }
}
