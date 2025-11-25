namespace CarRentalManagement.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int? Year { get; set; }
        public string? LicensePlateNumber { get; set; }
        public string? MakeId { get; set; }
        public string? ModelId { get; set; }
        public string? ColourId { get; set; }

    }
}
