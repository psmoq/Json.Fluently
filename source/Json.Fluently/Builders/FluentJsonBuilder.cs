using Json.Fluently.Builders.Abstract;
using Json.Fluently.Syntax;

namespace Json.Fluently.Builders
{
  public class FluentJsonBuilder : IFluentJsonBuilder
  {
    private JsonObjectBuilder _builder;

    public IJsonObjectSyntax CreateNew()
    {
      _builder = new JsonObjectBuilder();

      return _builder.CreateNew(this);
    }
  }
}
