using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace DatabaseHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb+srv://Cliff:Cliff@cliffdb-isepc.mongodb.net/test");
            var db = client.GetDatabase("myDB");

            var coll = db.GetCollection<Games>("test");
            //var q = from gam in coll.AsQueryable<Games>         
            var query = from gam in coll.AsQueryable<Games>()                       
                        select gam.Title;

            List<string> li = query.ToList();

            ListGames.DataSource = li;
            
        }

        private void AddGame_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://Cliff:Cliff@cliffdb-isepc.mongodb.net/test");
            var db = client.GetDatabase("myDB");
            
            var coll = db.GetCollection<Games>("test");
            
            Games games = new Games();
            games.Title = "cool";
            games.Description = "cool";
            games.Genre = "cool";
            games.Year = 1;
            games.Developer = "cool";
            games.Engine = "cool";
            coll.InsertOne(games);

            var query = from gam in coll.AsQueryable<Games>()
                        where gam.Title == "cool"
                        select gam;
            Games result = query.FirstOrDefault<Games>();

        }

        private void DisplayGame_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://Cliff:<Q0Jf8WHeruuOKqCu>@cliffdb-isepc.mongodb.net/test");
            var db = client.GetDatabase("myDB");

            foreach (var item in db.ListCollections().ToList())
            {

            }
        }

        private void ListGames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
