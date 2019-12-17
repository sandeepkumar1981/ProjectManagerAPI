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
    public class ProjectController : ApiController
    {
        BLProject obj = new BLProject();

        [Route("api/Project")]
        public HttpResponseMessage GET()
        {
            try
            {
                var entity = obj.GetAllProject();
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

        [Route("api/Project")]
        public HttpResponseMessage POST([FromBody]EntityProject project)
        {
            try
            {
                obj.AddProject(project);
                var message = Request.CreateResponse(HttpStatusCode.Created, project);
                message.Headers.Location = new Uri(Request.RequestUri + project.projectId.ToString());
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
