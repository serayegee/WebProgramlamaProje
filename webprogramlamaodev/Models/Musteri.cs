namespace webprogramlamaodev.Models
{
	public class Musteri
	{
		public string Id { get; set; }
		public string Ad { get; set; }
		public string MusteriTelefon { get; set; }
		public List<Randevu> Randevular { get; set; } = new();

	}
}
