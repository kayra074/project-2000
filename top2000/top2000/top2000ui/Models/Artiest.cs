using System;
using System.Collections.Generic;

#nullable disable

namespace top2000ui.Models
{
    public partial class Artiest
    {
        public Artiest()
        {
            Songs = new HashSet<Song>();
        }

        public int Artiestid { get; set; }
        public string Naam { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
