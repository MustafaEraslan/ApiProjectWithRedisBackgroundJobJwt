using MustafaEraslanGraduationProject.Entities;
using Newtonsoft.Json;

namespace MustafaEraslanGraduationProject.Service.Imp
{
    public class MovieService : IMovieService
    {
        private readonly MoviesContext _context;

        public MovieService(MoviesContext context)
        {
            _context = context;
        }

        public void AddMovie(Mytable movie)
        {
            Genres genre = new Genres();
            List<Genres> genres = new List<Genres>();
            if (string.IsNullOrWhiteSpace(movie.Genres))
            {
                movie.Genres = "[]"; //Default değeri
            }
            if (string.IsNullOrWhiteSpace(movie.SpokenLanguages))
            {
                movie.SpokenLanguages = "[]";
            }
            if (string.IsNullOrWhiteSpace(movie.ProductionCompanies))
            {
                movie.ProductionCompanies = "[]";
            }
            if (string.IsNullOrWhiteSpace(movie.ProductionCompanies))
            {
                movie.ProductionCompanies = "[]";
            }

            _context.Add(movie);
            _context.SaveChanges();
        }

        public void DeleteMovie(long id)
        {
            var movie= _context.Mytables.Where(x => x.Id == id).FirstOrDefault();
            if(movie != null)
            {
                _context.Remove(movie); 
                _context.SaveChanges();
            }
        }

        public Mytable GetMovieDetail(long id)
        {
            Mytable movie = _context.Mytables.Where(x => x.Id == id).FirstOrDefault();
            return movie;
        }

        public List<Mytable> GetMovieList(int genreId)
        {
            List<Mytable> movie = _context.Mytables.ToList();
            movie = movie.Where( x=> x.Genres.IndexOf($"'id'={genreId}", StringComparison.InvariantCultureIgnoreCase) > -1).ToList();
            return movie;
        }

        public List<Mytable> GetMovieList(decimal rateFilter)
        {
            List<Mytable> movie = _context.Mytables.ToList();
            movie=movie.Where(x => x.VoteAverage >= rateFilter).ToList();
            return movie;
        }

        public List<Mytable> GetMovieList(string releaseDate)//asenc olacak. ve controller asencron olacak
        {
            List<Mytable> movie = _context.Mytables
                .ToList();
            movie = movie.Where(x => (!string.IsNullOrWhiteSpace(x.ReleaseDate)
             && x.ReleaseDate.Equals(releaseDate, StringComparison.InvariantCultureIgnoreCase)))
                .ToList();
            return movie;
        }

        public List<Mytable> Search(string title)//asenc olacak. ve controller asencron olacak
        {
            List<Mytable> movies = _context.Mytables.ToList();
            movies = movies.Where(x => (!string.IsNullOrWhiteSpace(x.Title) &&
            x.Title.IndexOf($"{title}",StringComparison.InvariantCultureIgnoreCase) > -1)).ToList();
            return movies;
        }

        public void UpdateMovie(long id, Mytable movie)
        {
            var mytable = _context.Mytables.Where(x=>x.Id == id).FirstOrDefault();
            if (mytable == null) return;
            Genres genre = new Genres();
            List<Genres> genres = new List<Genres>();
            if (string.IsNullOrWhiteSpace(movie.Genres))
            {
                movie.Genres = "[]";
            }
            if (string.IsNullOrWhiteSpace(movie.SpokenLanguages))
            {
                movie.SpokenLanguages = "[]";
            }
            if (string.IsNullOrWhiteSpace(movie.ProductionCompanies))
            {
                movie.ProductionCompanies = "[]";
            }
            if (string.IsNullOrWhiteSpace(movie.ProductionCompanies))
            {
                movie.ProductionCompanies = "[]";
            }

            _context.Update(movie);
            _context.SaveChanges();
        }
    }
}
