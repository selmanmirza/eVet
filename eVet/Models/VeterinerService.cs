namespace eVet.Models   
{
    public class VeterinerService           // çoka çok tablo
    {
        public int VeterinerId { get; set; }    //foreign
        public Veteriner? Veteriner { get; set; }

        public int ServiceId { get; set; }      // foreign
        public Service? Service { get; set; }   // vs.Service.Ad diye erişilebilir.
    }
}