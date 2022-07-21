namespace MustafaEraslanGraduationProject.Entities
{
    [Serializable]
    public class BelongsToCollection //BelongToCollection json formatında ve birden fazla parametreye sahip. 
    { //bu sebeple bu kolonu ayrı bir entities'te tutmak istedim. ve nesene türettim.
        public int Id { get; set; }

        public string? Name { get; set; }

        public string Poster_Path { get; set; }

        public string BackDrop_Path { get; set; }

    }
}
