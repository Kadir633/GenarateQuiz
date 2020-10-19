using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;
using GenarateQuizWebUI.Models;
using GenerateQuiz.BUSINESS.Abstract;
using GenerateQuiz.ENTITIES;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace GenarateQuizWebUI.Controllers
{
 
    
    public class HomeController : Controller
    {
        private IQuizService _quizService;

        public HomeController(IQuizService quizService)
        {
            this._quizService = quizService;
        }

        [Authorize]
        public ActionResult Index()
        {
            var model = new NewsListViewModel();

            List<News> newsList = GetLatestFivePosts().Cast<News>().ToList();
            model.NewsList = newsList;

            return View(model);
        }
        [Authorize]
        public ActionResult NewsQuestion(string address)
        {
            var model = new NewsQuestionViewModel();
            model.NewsAddress = address;
            return View(model);
        }
        [Authorize]
        [HttpPost]
        public ActionResult NewsQuestion(QuestionModel  model)
        {

            var entity = new Question()
            {
                Link=model.Link,
                Baslik=DateTime.Now.ToString("dd/MM/yyyy"),
                Selection1=model.Selection1,
                Selection2=model.Selection2,
                Selection3=model.Selection3,
                Selection4=model.Selection4,
                CorrectAnswer1=model.CorrectAnswer1,
                CorrectAnswer2=model.CorrectAnswer2,
                CorrectAnswer3=model.CorrectAnswer3,
                CorrectAnswer4=model.CorrectAnswer4,
                A1=model.A1,B1=model.B1,
                C1=model.C1,D1=model.D1,

                A2= model.A2,
                B2= model.B2,
                C2= model.C2,
                D2= model.D2,

                A3 = model.A3,
                B3 = model.B3,
                C3 = model.C3,
                D3 = model.D3,
                                      
                A4 = model.A4,
                B4 = model.B4,
                C4 = model.C4,
                D4 = model.D4
            };
            _quizService.Create(entity);

            return Redirect("NewsList");

        }
        [Authorize]
        public ActionResult NewsList()
        {
            QuestionsModel model = new QuestionsModel
            {
                Questions = _quizService.GetAll().ToList(),
            };

            return View(model);
        }

        [Authorize]
        public ActionResult Delete(int ? id)
        {
            var data = _quizService.GetAll().Where(i => i.Id == id).FirstOrDefault();

            _quizService.Delete(data);
            return RedirectToAction("NewsList", "home");
            
        }
        [Authorize]
        public static IEnumerable<News> GetLatestFivePosts()
        {
            var reader = XmlReader.Create("https://www.wired.com/feed/rss");
            var feed = SyndicationFeed.Load(reader);
            reader.Close();
            return (from itm in feed.Items
                    select new News
                    {
                        Title = itm.Title.Text,
                        Link = itm.Links[0].Uri.ToString()
                    }).ToList().Take(7);
        }
        [Authorize]
        public ActionResult AjaxPost()
        {
       

            return View();
        }
        [Authorize]
        public ActionResult test(int? id)
        {
            QuestionsModel model = new QuestionsModel
            {
                Questions = _quizService.GetAll().Where(i => i.Id == id).ToList(),
            };

            return View(model);

        }
        [Authorize]
        [HttpPost]
        public ActionResult AjaxPost(string ad, string soyad)
        {
            string _ad = ad;

            return Json("Ok");
        }
    }
}
