using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityAPI.Infrastructure;
using IdentityAPI.Models;
using IdentityAPI.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {

        private IdentityDbContext _busInfoContext;
        
        public SearchController(IdentityDbContext BusInfoContext)
        {
            this._busInfoContext = BusInfoContext;
            
        }
        [HttpPost("", Name = "GetSearchInfo")]
        public ActionResult<dynamic> GetSearchInfo(SearchModel searchmodel)
        {
            TryValidateModel(searchmodel);
            if (ModelState.IsValid)
            {
                var result = _busInfoContext.BusInfo.Where(a => a.FromLocation == searchmodel.FromLocation
                            && a.ToLocation == searchmodel.ToLocation && a.TravelDate == searchmodel.TravelDate).ToList();
                    
                    
                   
                if (result != null)
                {


                    return Ok(result);
                }
                else
                {
                    return Unauthorized();
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        
    }

}