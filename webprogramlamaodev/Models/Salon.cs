namespace webprogramlamaodev.Models
{
	public class Salon
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Adres { get; set; }
		public string Telefon { get; set; }
		public string CalismaSaatleri { get; set; }
		public List<Personel> Personeller { get; set; } = new();
		public List<Islem> Islemler { get; set; } = new();

	}
}
