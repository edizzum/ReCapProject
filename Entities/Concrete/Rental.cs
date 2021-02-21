using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rental:IEntity
    {
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
