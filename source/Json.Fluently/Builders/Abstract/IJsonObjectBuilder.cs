using Newtonsoft.Json.Linq;

namespace JsonFluently.Builders.Abstract
{
  public interface IJsonObjectBuilder
  {
    JObject Build();
  }
}
