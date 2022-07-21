using MustafaEraslanGraduationProject.Entities;

namespace MustafaEraslanGraduationProject.Service
{
    public interface IMovieService
    {
        Mytable GetMovieDetail(long id);
        List<Mytable> GetMovieList(int genreId);
        List<Mytable> GetMovieList(decimal rateFilter);
        List<Mytable> GetMovieList(string releaseDate);
        List<Mytable> Search(string title);
        void AddMovie(Mytable movie);
        void UpdateMovie(long id,Mytable movie);
        void DeleteMovie(long id);
    }
}
