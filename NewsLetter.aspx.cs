using System;
using System.Collections.Generic;
using System.Linq;
using sucesso_e_motivacao.Data;
using sucesso_e_motivacao.Models;

namespace sucesso_e_motivacao
{
    public partial class NewsLetter : System.Web.UI.Page
    {
        public class NewsItem
        {
            public long Id { get; set; }
            public string ImageName { get; set; }
            public string Title { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var context = new NewsLatterContext())
            {
                try
                {
                    var newsQuery = from noo in context.News
                                    join img in context.Image on noo.ImagesId equals img.Id
                                    select new NewsItem
                                    {
                                        Id = noo.Id,
                                        ImageName = img.Name,
                                        Title = noo.Title
                                    };

                    int cont = 0;
                    string responseText = "";

                    foreach (var item in newsQuery)
                    {
                        if (cont % 3 == 0)
                        {
                            responseText += "<div class='row'>";
                        }

                        responseText += "<div class='col-lg-4 poster text-center'>";
                        responseText += "<a class='noticias' href='Noticia.aspx?id=" + item.Id + "'>";
                        responseText += "<img class='img-thumbnail' style='max-height: 200px; style='mim-height: 200px;' src='/Content/Images/" + item.ImageName + "' title='" + item.Title + "' />";
                        responseText += "<br />";
                        responseText += "<div class='noticias titulo'>" + item.Title + "</div>";
                        responseText += "</a>";
                        responseText += "</div>";

                        cont++;

                        if (cont % 3 == 0)
                        {
                            responseText += "</div>";
                        }
                    }

                    LiteralResponseText.Text = responseText;
                }
                catch (Exception ex)
                {
                    Response.Write("Erro: " + ex.Message);
                }
            }
        }
    }
}
