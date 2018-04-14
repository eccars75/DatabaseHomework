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

            UpdateList();
        }

        private void AddGame_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://Cliff:Cliff@cliffdb-isepc.mongodb.net/test");
            var db = client.GetDatabase("myDB");
            
            var coll = db.GetCollection<Games>("test");
            
            Games games = new Games();
            games.Title = TitleTextBox.Text;
            games.Description = DescriptionTextBox.Text;
            games.Genre = GenreTextBox.Text;
            games.Year = int.Parse(YearTextBox.Text);
            games.Developer = DeveloperTextBox.Text;
            games.Engine = EngineTextBox.Text;
            coll.InsertOne(games);          

            UpdateList();
        }

        private void UpdateGame_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://Cliff:Cliff@cliffdb-isepc.mongodb.net/test");
            var db = client.GetDatabase("myDB");

            var coll = db.GetCollection<Games>("test");

            //Games games = new Games();
            //games.Title = TitleTextBox.Text;
            //games.Description = DescriptionTextBox.Text;
            //games.Genre = GenreTextBox.Text;
            //games.Year = int.Parse(YearTextBox.Text);
            //games.Developer = DeveloperTextBox.Text;
            //games.Engine = EngineTextBox.Text;
            ////coll.InsertOne(games);
            //coll.UpdateOne()
            UpdateList();
        }

        private void DeleteGame_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://Cliff:Cliff@cliffdb-isepc.mongodb.net/test");
            var db = client.GetDatabase("myDB");

            var coll = db.GetCollection<Games>("test");

            UpdateList();
        }

        private void ListGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://Cliff:Cliff@cliffdb-isepc.mongodb.net/test");
            var db = client.GetDatabase("myDB");

            var coll = db.GetCollection<Games>("test");

            var title = ListGames.Text;

            var query = from gam in coll.AsQueryable<Games>()
                        where gam.Title == title
                        select gam;
            Games games = query.FirstOrDefault();

            TitleTextBox.Text = games.Title;
            DescriptionTextBox.Text = games.Description;
            GenreTextBox.Text = games.Genre;
            YearTextBox.Text = games.Year.ToString();
            DeveloperTextBox.Text = games.Developer;
            EngineTextBox.Text = games.Engine;
        }

        private void UpdateList()
        {
            var client = new MongoClient("mongodb+srv://Cliff:Cliff@cliffdb-isepc.mongodb.net/test");
            var db = client.GetDatabase("myDB");

            var coll = db.GetCollection<Games>("test"); 
            var query = from gam in coll.AsQueryable<Games>()
                        select gam.Title;

            List<string> li = query.ToList();

            ListGames.DataSource = li;
        }        
    }
}
