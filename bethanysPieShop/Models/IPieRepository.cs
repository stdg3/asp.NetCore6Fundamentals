namespace bethanysPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; } // pie tanimlarken bool olarak tanimladigimiz bu degisken sayesinde listeleme yapmamiz mumkun olacak
        Pie? GetPieById(int id);
        IEnumerable<Pie> SearchPies(string searchQuery);
    }
}
