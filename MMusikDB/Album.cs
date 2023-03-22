using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace MMusikDB
{
    internal class Album
    {
        public int ID { get; set; }

        public string AlbumName { get; set; }

        public String  ArtistName { get; set; }

        public int Year { get; set; }

        public String ImageUrl { get; set; }

        public String Description { get; set; }
    }
}
