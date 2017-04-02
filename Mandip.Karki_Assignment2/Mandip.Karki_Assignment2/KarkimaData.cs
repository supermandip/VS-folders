using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandip.Karki_Assignment2
{
    class KarkimaData : EntertainData
    {
        public string Title{get; set;}
        public double Rating {get; set;}
        public string MusOrMov { get; set; }
        public string Genre { get; set; }

        public KarkimaData() { }

        public KarkimaData(string givenTitle, double givenRating, string MOM, string Gen) {
            Title = givenTitle;
            Rating = givenRating;
            Genre = Gen;
            MusOrMov = MOM;
        }

       

        public override string MusicOrMovie() {
            return MusOrMov;
        }
        public override string EntertainGenre()
        {
            return Genre;
        }
         public override string ToString()
        {
            return MusicOrMovie() + "/" + EntertainGenre() + " created by  " + EntertainName() + ": " + Title + " has a rating of "+ Rating;
        }

        
    }

}
