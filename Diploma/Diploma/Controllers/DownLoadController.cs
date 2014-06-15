using System.IO;
using System.Net;
using System.Web.Mvc;
using Diploma.DataHelpers;
using Ionic.Zip;

namespace Diploma.Controllers
{
    public class DownloadController : BaseController
    {
        public FileResult GetPages()
        {
            if (Request.Url != null)
            {
                var zip = new ZipFile();
                zip.AddDirectoryByName("Content");
                zip.AddDirectory(Server.MapPath("~/Content/"), "Content");
                var paths = DtoHelper.GetPaths();
                foreach (var path in paths)
                {
                    var url = Url.Action(path.Action, path.Controller, null, Request.Url.Scheme);
                    if (url != null)
                    {
                        var request = WebRequest.Create(string.Concat(url, Constants.Resources.DownloadParameter));
                        request.Credentials = CredentialCache.DefaultCredentials;
                        var response = (HttpWebResponse)request.GetResponse();
                        var dataStream = response.GetResponseStream();
                        {
                            if (dataStream != null)
                            {
                                zip.AddEntry(path.FileName, dataStream);
                            }
                        }
                    }
                }
                var stream = new MemoryStream();
                zip.Save(stream);
                stream.Position = 0;
                return new FileStreamResult(stream, "application/zip") { FileDownloadName = Constants.Resources.DownloadName };

            }
            return null;
        }
    }
}
