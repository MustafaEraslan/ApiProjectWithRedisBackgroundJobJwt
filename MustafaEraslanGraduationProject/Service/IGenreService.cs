using MustafaEraslanGraduationProject.Entities;

namespace MustafaEraslanGraduationProject.Service
{
    public interface  IGenreService
    {
        List<Genres> ListGenres(long movieId);
        void AddGenre(long movieId, Genres genre);
        void UpdateGenre(long movieId,int genreId, Genres genre);
        void DeleteGenre(long movieId,int genreId);
        void DeleteByMovieAllGenre(long movieId);
    }
}
