using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ClubRecord:IEntity
    {
        public int KayitNo { get; set; }
        public string Adi { get; set; }
        public string Sorumlu { get; set; }
    }
}
