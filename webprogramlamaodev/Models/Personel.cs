namespace webprogramlamaodev.Models
{
	public class Personel
	{
		public string Id { get; set; }
		public string Ad { get; set; }
		public string Uzmanlik { get; set; }
		public bool Musaitlik { get; set; }
		public List<Islem> Islemler { get; set; } = new();	
	}
}
