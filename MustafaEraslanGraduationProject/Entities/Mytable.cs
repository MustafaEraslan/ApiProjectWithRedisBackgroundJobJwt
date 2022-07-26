﻿namespace MustafaEraslanGraduationProject.Entities
{
    public partial class Mytable //ilk etapta migration aldığımda dbFirst ile oluşan datalar ve datatipleri bu şekilde
    { //Null özellikleri yine dbFirst ile default olarak gelmiş oldu.
        public string Adult { get; set; } = null!;
        public string? BelongsToCollection { get; set; }
        public string Budget { get; set; } = null!;
        public string Genres { get; set; } = "[]";//default değer verdim.
        public string? Homepage { get; set; }
        public long Id { get; set; }
        public string? ImdbId { get; set; }
        public string? OriginalLanguage { get; set; }
        public string OriginalTitle { get; set; } = null!;
        public string? Overview { get; set; }
        public string? Popularity { get; set; }
        public string? PosterPath { get; set; }
        public string? ProductionCompanies { get; set; } = "[]";
        public string? ProductionCountries { get; set; } = "[]";
        public string? ReleaseDate { get; set; }
        public int? Revenue { get; set; }
        public decimal? Runtime { get; set; }
        public string? SpokenLanguages { get; set; } = "[]";
        public string? Status { get; set; }
        public string? Tagline { get; set; }
        public string? Title { get; set; }
        public string? Video { get; set; }
        public decimal? VoteAverage { get; set; }
        public int? VoteCount { get; set; }
    }
}
