namespace webprogramlamaodev.Models
{
	public class Randevu
	{
		public string Id { get; set; }
		public DateTime Tarih { get; set; }
		public int IslemId { get; set; }
		public Islem Islem { get; set; }
		public string MusteriAd { get; set; }
		public string MusteriId { get; set; }
		public string MusteriTelefon { get; set; }
		public Musteri Musteri { get; set; }
		public string PersonelId { get; set; }
		public Personel Personel { get; set; }
		public decimal ToplamUcret { get; set; }
	}
}
