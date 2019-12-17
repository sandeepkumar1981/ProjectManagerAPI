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
    public class TaskController : ApiController
    {
        BLTask obj = new BLTask();

        [Route("api/Task")]
        public HttpResponseMessage GET()
        {
            try
            {
                var entity = obj.GetAllTask();
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

        [Route("api/Task")]
        public HttpResponseMessage POST([FromBody]EntityTask task)
        {
            try
            {
                obj.AddTask(task);
                var message = Request.CreateResponse(HttpStatusCode.Created, task);
                message.Headers.Location = new Uri(Request.RequestUri + task.taskId.ToString());
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [Route("api/Task/ID")]
        public HttpResponseMessage Put([FromBody]EntityTask task, int ID)
        {
            try
            {
                obj.UpdateTask(task, ID);
                return Request.CreateResponse(HttpStatusCode.OK, "Record updated successfully");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
