using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace EFCorePractise.Models;

public class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    public string? Genre { get; set; }
}
