using System.ComponentModel.DataAnnotations;

namespace MustafaEraslanGraduationProject.Entities
{
    [Serializable] //json convert etme işlemlerimizde Serializable edilebilir olduğunu belittim.
    public class Genres //Genre datası da json formatında olduğu için bu şekilde ayrı bir entities klasöründe oluşturdum.
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
