﻿namespace CarRentalManagement.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }
        public string? LicsencePlateNumber { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int ColourID { get; set; }
    }
}
