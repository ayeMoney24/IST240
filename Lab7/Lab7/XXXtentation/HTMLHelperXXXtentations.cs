using Newtonsoft.Json;
using System.Web;
using System.Web.Mvc;
public static class HTMLHelperXXXtentations
{
    public static HtmlString HTMLConvertToJson(this HtmlHelper htmlHelper, object Model)
    {
        var settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            Formatting = Formatting.Indented
        };

        return new HtmlString(JsonConvert.SerializeObject(Model, settings));
    }
}
