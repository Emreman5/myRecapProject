using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class CarImage:IEntity
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public int CarId { get; set; }
    }
}