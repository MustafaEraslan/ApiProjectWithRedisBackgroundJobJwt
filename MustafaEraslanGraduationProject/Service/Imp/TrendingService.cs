using MustafaEraslanGraduationProject.Entities;

namespace MustafaEraslanGraduationProject.Service.Imp
{
    public class TrendingService : ITrendingService
    {
        private MoviesContext _context;
        public TrendingService(MoviesContext context)
        {
            _context = context; // Db için ctor tanımı
        }
        public List<Mytable> ListMostViewedMovies()
        {
            List<Mytable> movie = _context.Mytables.OrderByDescending(x => x.Popularity).Take(100).ToList();//populer 100 film seçimi
            return movie;
        }

        public List<Mytable> ListTopRatedMovies()
        {
            List<Mytable> movie = _context.Mytables.OrderByDescending(x=>x.VoteAverage).Take(100).ToList();
            return movie;
        }
    }
}
