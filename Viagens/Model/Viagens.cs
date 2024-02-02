using System.ComponentModel.DataAnnotations.Schema;

namespace Viagens.Model
{


  [Table("viagens")]
  public class Viagen
  {



    [Column("id")]
    public int Id { get; set; }

    [Column("viagen_name")]
    public string Name { get; set; } = string.Empty;

    [Column("viagen_genre")]
    public string Genre { get; set; } = string.Empty;
    [Column("viagen_url")]
    public string viagenURL { get; set; } = string.Empty;

    [Column("viagen_price")] 
    public decimal Price { get; set; }






  }








}