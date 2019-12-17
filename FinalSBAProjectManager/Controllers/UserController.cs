using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityProjectManager;
using BusinessLayerProjectManager;

namespace FinalSBAProjectManager.Controllers
{
    public class UserController : ApiController
    {
        BLUser obj = new BLUser();

        [Route("api/User")]
        public HttpResponseMessage GET()
        {
            try
            {
                var entity = obj.GetAllUser();
                if (entity != null)
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound, "No record found");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [Route("api/User")]
        public HttpResponseMessage POST([FromBody]EntityUser user)
        {
            try
            {
                obj.AddUser(user);
                var message = Request.CreateResponse(HttpStatusCode.Created, user);
                message.Headers.Location = new Uri(Request.RequestUri + user.employeeId.ToString());
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
