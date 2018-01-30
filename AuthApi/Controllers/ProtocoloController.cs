using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AuthApi.Controllers
{
    [Authorize]
    public class ProtocoloController : ApiController
    {
        public HttpResponseMessage GetProtocolo()
        {
            string protocolo = string.Format("{0:yy}{1}", DateTime.Today, new Random().Next());
            return Request.CreateResponse(HttpStatusCode.OK, protocolo);
        }
    }
}