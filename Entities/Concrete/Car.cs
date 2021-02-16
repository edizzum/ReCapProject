using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public short CarId { get; set; }
        public short BrandId { get; set; }
        public short ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
    }
}
