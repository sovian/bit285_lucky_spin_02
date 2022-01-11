using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {

        private LuckyNumber lucky;

        public SpinnerController(LuckyNumber Lucky)
        {
            lucky = Lucky;
        }
        public IActionResult Index(int luck)
        {
            lucky.Luck = luck;
            return new ContentResult { Content = lucky.Output, ContentType = "text/html" };
        }
    }
}
