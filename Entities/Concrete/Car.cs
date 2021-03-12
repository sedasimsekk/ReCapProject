using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
     public class Car:IEntity 
    {
        public int Id { get; set; } //kimlik 
        public int BrandId { get; set; } //marka kimliği
        public int ColorId { get; set; } //renk kimliği
        public int ModelYear { get; set; } //model yılı
        public string CarName { get; set; }
        public decimal DailyPrice { get; set; } //günlük fiyat
        public string Description { get; set; } //açıklama
    }
}
