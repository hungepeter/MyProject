using Microsoft.AspNetCore.Mvc;

using coreproject2.Models;

namespace coreproject2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IList<Food> List=new List<Food>();

            List.Add(new Food { 編號 = "F01", 名稱 = "屯京拉麵", 單價 = 280 });

            List.Add(new Food { 編號 = "F02", 名稱 = "金三角生角片", 單價 = 540 });

            List.Add(new Food { 編號 = "F03", 名稱 = "幽靈肉粽", 單價 = 30 });


            return View(List);
        }
    }
}
