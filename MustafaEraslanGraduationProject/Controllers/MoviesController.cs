using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MustafaEraslanGraduationProject.Entities;
using MustafaEraslanGraduationProject.Service;

namespace MustafaEraslanGraduationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] //AllowAnonymous olmayan methodlardan jwt token alınmasını zorunlu kılmak için kullanıldı.
    public class MoviesController : ControllerBase
    {
        private IMovieService _movieService;
        public MoviesController(IMovieService movieService) //ctrol tanımladım
        {
            _movieService = movieService;
        }

        [HttpGet("GetMovieDetail")] //id'ye göre movie detail dönüldü
        [AllowAnonymous]
        public Mytable GetMovieDetail(long id)
        {
            return _movieService.GetMovieDetail(id);
        }

        // GET api/<Movies>/5
        [HttpGet("GetMovieListGenre")]//Genre'ye göre movie dönüldü
        [AllowAnonymous]
        public List<Mytable> GetMovieList(int genreId)
        {
            return _movieService.GetMovieList(genreId);
        }

        [HttpGet("GetMovieListRate")]
        [AllowAnonymous]
        public List<Mytable> GetMovieList(decimal rateFilter)//rate değerine eşit ve büyük olanları getir.
        {
            return _movieService.GetMovieList(rateFilter);
        }

        [HttpGet("GetMovieListRelease")] // verilen tarihe sahip datayı getir
        [AllowAnonymous]
        public List<Mytable> GetMovieList(string releaseDate)
        {
            return _movieService.GetMovieList(releaseDate);
        }

        [HttpGet("Search")]//tittle olarak verilen kolon ile eşleşen filmi getir.
        [AllowAnonymous]
        public List<Mytable> Search(string title)
        {
            return _movieService.Search(title);
        }

        // POST api/<Movies>
        [HttpPost]//film ekle
        public void AddMovie([FromBody] Mytable mytable)
        {
            _movieService.AddMovie(mytable);
        }

        // PUT api/<Movies>/5
        [HttpPut("{id}")]//film güncelleme
        public void UpdateMovie(long id, [FromBody] Mytable mytable)
        {
            _movieService.UpdateMovie(id,mytable);
        }

        // DELETE api/<Movies>/5
        [HttpDelete("{id}")]//id bazlı silme işlemi sağlandı
        public void DeleteMovie(long id)
        {
            _movieService.DeleteMovie(id);
        }
    }
}
