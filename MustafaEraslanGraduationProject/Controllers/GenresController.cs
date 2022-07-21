using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MustafaEraslanGraduationProject.Entities;
using MustafaEraslanGraduationProject.Service;

namespace MustafaEraslanGraduationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] //AllowAnonymous olmayan methodlardan jwt token alınmasını zorunlu kılmak için kullanıldı.
    public class GenresController : ControllerBase //Genre için controller oluşturdum.
    {
        private IGenreService _genreService;
        public GenresController(IGenreService genreService) 
        {
            _genreService = genreService;
        }
        // GET: api/<GenresController>
        [HttpGet]
        [AllowAnonymous]
        public List<Genres> ListGenres(long movieId) //movieId'ye göre genre dönmeyi sağladım.
        {
            return _genreService.ListGenres(movieId);
        }


        // POST api/<GenresController>
        [HttpPost]
        public void AddGenre(long movieId, [FromBody]  Genres genre) //MovieID'ye göre genre eklenilmesi sağlandı. Genre son kullanıcıdan alınıyor
        {
            _genreService.AddGenre(movieId, genre);
            
        }

        // PUT api/<GenresController>/5
        [HttpPut("{movieId}")]
        public void UpdateGenre(long movieId,int genreId, [FromBody] Genres genre) //movieId değerine göre genre güncelleme işlemi
        {
            _genreService.UpdateGenre(movieId,genreId,genre);
            
        }

        // DELETE api/<GenresController>/5
        [HttpDelete("{movieId}")] //movieId değerine göre genre silme işlemi
        public void DeleteGenre(long movieId, int genreId)
        {
            _genreService.DeleteGenre(movieId,genreId); 
        }
    }
}