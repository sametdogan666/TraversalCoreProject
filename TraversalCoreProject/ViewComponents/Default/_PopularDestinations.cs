using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = _destinationManager.GetList();
            return View(values);
        }
    }
}
