using Newtonsoft.Json.Linq;

namespace Json.Fluently.Builders.Abstract
{
  public interface IJsonObjectBuilder
  {
    JObject Build();
  }
}
