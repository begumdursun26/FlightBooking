using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.ViewComponents
{
    public class _BookingAreaComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
         return View();
        }   
    }
}
