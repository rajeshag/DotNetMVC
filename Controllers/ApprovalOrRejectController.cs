using Microsoft.AspNetCore.Mvc;

namespace AR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApprovalOrRejectController(IVistor myService): ControllerBase
    {

        [HttpPost("/vistor/approvedOrRejected")]
        public string vistorApprovedOrRejected(Vistor vistor)
        {
            myService.edit(vistor);
            VistorServices mailService = (VistorServices)myService; 
            return mailService.sendMail(vistor);
            //return Ok();
        }

    }
}
   