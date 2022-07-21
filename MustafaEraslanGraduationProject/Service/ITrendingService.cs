using MustafaEraslanGraduationProject.Entities;

namespace MustafaEraslanGraduationProject.Service
{
    public interface ITrendingService
    {
        List<Mytable> ListMostViewedMovies();
        List<Mytable> ListTopRatedMovies();
    }
}
