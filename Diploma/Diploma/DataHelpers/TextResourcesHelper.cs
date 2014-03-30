using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using Diploma.DTO.Shared;
using Diploma.Models;

namespace Diploma.DataHelpers
{
    public static partial class DtoHelper
    {
        public static IEnumerable<TextItemModel> ToTextItemModel()
        {
            using (var xmlSteam = new FileStream(HttpContext.Current.Server.MapPath(Constants.Resources.Shared), FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(Root));
                var dto = (Root)serializer.Deserialize(xmlSteam);
                var items = dto.Item.Select(GetTextItemModel);
                return items;
            }
        }

        public static TextItemModel GetTextItemModel(RootItem dtoItem)
        {
            var item = new TextItemModel
            {
                Guid = dtoItem.dataguid,
                Text = dtoItem.Value
            };
            return item;
        }
    }
}