using ApoCan.BLL.Patterns.Repository.ConcRep;
using ApoCan.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApoCan.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace ApoCan.Controllers
{
    public class ProfessionalController : Controller
    {
        private ProductRepository _pRep;
        public ProfessionalController()
        {
            _pRep = new ProductRepository();
        }
        // GET: Professional
        public ActionResult Professionals()
        {
            List<Product> products = _pRep.GetAll();
            string a = Request.Url.AbsoluteUri.ToString();
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View(products);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            //return View(products);

        }

        public PartialViewResult GetProduct(int id)
        {
            Product pro = _pRep.Where(x => x.ID == id).FirstOrDefault();
            ViewBag.choosenProduct = pro;
            return PartialView("_productView");
        }

        public ActionResult ProductDetail(int id)
        {
            Product p = _pRep.Find(id);
            return View(p);

        }

        public ActionResult ProfessionalMain()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public ActionResult ProfessionalInfo()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }


        public ActionResult NeukundenInfo()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public ActionResult Download()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }


        public ActionResult ProducktrelevanteInformation()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public ActionResult Dronabinol()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public ActionResult Cannabidiol()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public ActionResult Extrakte()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public ActionResult Bluten()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }


        public ActionResult ProductSearch()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public ActionResult Analysenzertifikate()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public ActionResult CannabidiolAnalysenzertifikate()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public ActionResult DronabinolAnalysenzertifikate()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public ActionResult ExtrakteAnalysenzertifikate()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }


        public ActionResult BlutenAnalysenzertifikate()
        {
            string a = Request.Url.AbsoluteUri;
            if (a.Contains("timestamp") || Session["logged"] != null)
            {
                Session["logged"] = "logged";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }


        //public ActionResult ProductResult()
        //{
        //    string a = Request.Url.AbsoluteUri;
        //    if (a.Contains("timestamp") || Session["logged"] != null)
        //    {
        //        Session["logged"] = "logged";
        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("Login", "Home");
        //    }

        //}

        public ActionResult ProductResult(string number)
        {
            if (number == null)
            {
                return RedirectToAction("ProductResult");
            }
            else
            {
                var client = new RestClient("https://api.businesscentral.dynamics.com/v2.0/d997d32d-0bb9-49fb-8882-dded649bae98/APOCAN_Test/api/v2.0/companies(54a794bd-ddf5-eb11-a1de-0022485b536e)/items");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", "Basic a3BlY2tlcjpmVWNEeUdGUkl6TFlraTBLUkQyZE10cGZTS0ZzL0krcUcyQjlCSXRoaTA0PQ==");
                IRestResponse response = client.Execute(request);
                var tempResponse = JsonConvert.DeserializeObject<ErpBaseResponse<ErpProductDTO>>(response.Content);
                var choosenProduct = tempResponse.value.FirstOrDefault(x => x.number == number);
                var variants = GetItemVariant(choosenProduct.id);
                ViewBag.variants = variants;
                return View(choosenProduct);
            }

        }

        public List<ItemVariant> GetItemVariant(string id)
        {
            var client = new RestClient($"https://api.businesscentral.dynamics.com/v2.0/d997d32d-0bb9-49fb-8882-dded649bae98/APOCAN_Test/api/v2.0/companies(54a794bd-ddf5-eb11-a1de-0022485b536e)/items({id})/itemVariants");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Basic a3BlY2tlcjpmVWNEeUdGUkl6TFlraTBLUkQyZE10cGZTS0ZzL0krcUcyQjlCSXRoaTA0PQ==");
            IRestResponse response = client.Execute(request);
            var tempResponse = JsonConvert.DeserializeObject<ErpBaseResponse<ItemVariant>>(response.Content);
            var variants = tempResponse.value;


            var imageLink = GetItemPicture(id);
            ViewBag.imageLink = imageLink;
            return variants;
        }

        public string GetItemPicture(string id)
        {
            var client = new RestClient($"https://api.businesscentral.dynamics.com/v2.0/d997d32d-0bb9-49fb-8882-dded649bae98/APOCAN_Test/api/v2.0/companies(54a794bd-ddf5-eb11-a1de-0022485b536e)/items({id})/picture");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Basic a3BlY2tlcjpmVWNEeUdGUkl6TFlraTBLUkQyZE10cGZTS0ZzL0krcUcyQjlCSXRoaTA0PQ==");
            IRestResponse response = client.Execute(request);
            var tempResponse = JsonConvert.DeserializeObject<ErpProductImageModel>(response.Content);
            return tempResponse.mediaReadLink;
        }


    }
}