using PersonalFitnessCare.Server.Common.Constants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace PersonalFitnessCare.Server.Common.Extensions
{
    public static class ApiControllerExtensions
    {
        //public static FormattedContentResult<ResultObject> Data(this ApiController apiController, object data)
        //{
        //    if (data == null)
        //    {
        //        return apiController.Data(false, CommonConstants.RequestedResourceWasNotFound);
        //    }

        //    return new FormattedContentResult<ResultObject>(HttpStatusCode.OK, new ResultObject(data), new BrowserJsonFormatter(), null, apiController);
        //}

        //public static FormattedContentResult<ResultObject> Data(this ApiController apiController, bool success, string errorMessage, object data = null)
        //{
        //    return new FormattedContentResult<ResultObject>(HttpStatusCode.OK, new ResultObject(success, errorMessage, data), new BrowserJsonFormatter(), null, apiController);
        //}

        //public static FileResult File(this ApiController apiController, FileStream fileStream, string fileName)
        //{
        //    return new FileResult(fileStream, fileName);
        //}
    }
}