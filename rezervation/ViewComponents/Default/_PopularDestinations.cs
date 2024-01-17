using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessLayer.concerete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;




namespace rezervation.ViewComponents.Default
{
    public class _PopularDestinations:ViewComponent
    {
        DestiantionManager destiantionManager = new DestiantionManager(new EfDestinationsDal());
                                                                              //????


        public IViewComponentResult Invoke()
        {
            var values = destiantionManager.TGetList(); 
            return View(values);
        }
    }
}
