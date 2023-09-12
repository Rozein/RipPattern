using Microsoft.AspNetCore.Mvc;

namespace BootcampCustValidation.Controllers
{ 
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost(Name = "AddCustomer")]
        public string InsertCustomer([FromBody]UserDetailDto ust)
        {

            var userFactoryClass = new UserFactoryClass().Create(ust.CustomerType, ust);
            return userFactoryClass.ResponseClass();
        }
    }
}
