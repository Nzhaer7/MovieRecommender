using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommender
{
    internal class Movies
    {
        public int Id { get; set; }

        public string MovieType { get; set; }
        public string MovieName  { get; set; }

        public int MovieYear { get; set;}

        public int MovieScore { get; set;}
    }
}
