using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night___Part_1
{
    class Movie
    {
        #region Properties

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private int year;

        public int  Year
        {
            get { return year; }
            set { year = value; }
        }

        private string showtime;

        public string Showtime
        {
            get { return showtime; }
            set { showtime = value; }
        }

        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        #endregion

        #region Constructors

        public Movie()
        {

        }

        public Movie(int _id, string _title, int _year, string _showTime, string _genre)
        {
            Id = _id;
            Title = _title;
            Year = _year;
            Showtime = _showTime;
            Genre = _genre;
        }
        #endregion
    }
}
