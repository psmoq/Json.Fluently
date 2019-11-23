using JsonFluently.Builders.Abstract;
using JsonFluently.Syntax;

namespace JsonFluently.Builders
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
