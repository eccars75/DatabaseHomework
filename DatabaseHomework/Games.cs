using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;

namespace DatabaseHomework
{
    class Games
    {
        public MongoDB.Bson.BsonObjectId _id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Developer { get; set; }
        public string Engine { get; set; }
    }
}
