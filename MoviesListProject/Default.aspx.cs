using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;



namespace MoviesListProject
{

    public partial class Default : System.Web.UI.Page
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["FN"] = txtFN.Text;
            String movieId = "";
            if (txtFN.Text == "")
            {
                 movieId = "550" + "/"+ "lists";
            }
            else
            {
                movieId = txtFN.Text;
            }

            string apiKey = "7837a96568777514c9441f035ef4583a";
            HttpWebRequest apiRequest = WebRequest.Create("https://api.themoviedb.org/3/movie/" + movieId + "?api_key=" + apiKey + "") as HttpWebRequest;

            string apiResponse = "";
            using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                apiResponse = reader.ReadToEnd();
            }
            ResponseSearchPeople rootObject = JsonConvert.DeserializeObject<ResponseSearchPeople>(apiResponse);

            ListBox1.Items.Clear();
            ListBox1.Items.Add("Movie Id :  "  + rootObject.id + " ");
            ListBox1.Items.Add("\n");
            ListBox1.Items.Add("Movie Name :  " + rootObject.original_title);
            ListBox1.Items.Add(" \n");
            ListBox1.Items.Add("OverView :  " + rootObject.overview);
            ListBox1.Items.Add("\n");
            Image1.ImageUrl = "https://image.tmdb.org/t/p/w500/" + rootObject.poster_path;


        }
    }
    public class ResponseSearchPeople
    {
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public List<idname> genres { get; set; }
        public string original_title { get; set; }
        public int id { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }

    }

    public class idname
    {
        public int id { get; set; }
        public string name { get; set; }
    }

}
