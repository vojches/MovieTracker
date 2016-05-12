//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieTracker
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Net;
    using System.Text;
    using System.Windows.Forms;
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            this.Genres = new HashSet<Genre>();
        }
    
        public int Id { get; set; }
        public string ImdbID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Runtime { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Awards { get; set; }
        public string Language { get; set; }
        public string Image { get; set; }
        public decimal Rating { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<System.DateTime> Release { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Genre> Genres { get; set; }

        public override string ToString()
        {
            return Title + " - " + Year.ToString();
            //return base.ToString();
        }

        public void setPoster(PictureBox pictureBox, bool internet)
        {
            //string link;
            if (internet)
            {
                if (!Image.Equals("N/A"))
                {
                    var request = WebRequest.Create(Image);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox.Image = Bitmap.FromStream(stream);
                    }
                }
                else
                {
                    pictureBox.Image = Bitmap.FromFile(@"..\..\Pictures\default.png");
                }
            }
            else
            {
                pictureBox.Image = Bitmap.FromFile(@"..\..\Pictures\default.png");
            }
        }

        public string RatingMethod()
        {
            if (Rating == 0)
                return "N/A";
            else return string.Format("{0:0.0}", Rating); //.ToString();
        }

        public string RuntimeMethod()
        {
            if (Runtime == 0)
                return "N/A";
            else return Runtime.ToString() + " min";
        }

        public string ReleaseMethod()
        {
           
            if (Release.Value.Year != 1550)
                return Release.Value.Month + "." + Release.Value.Day + "." + Release.Value.Year;
            else
            {
                return "N/A";
            }
        }

        public string GenresMethod()
        {
            StringBuilder sb = new StringBuilder();
            //string last = " ";
            /*foreach (Genre g in Genres)
            {
                if (s.Equals(last))
                {
                    sb.Append(s);
                }
                else
                {
                    sb.Append(g.Name + ", ");
                //}
            }
            return sb.ToString();*/
            //return Genres.ToString();
            return "TREBA DA SE NAPRAVI !!!";
        }
    }
}
