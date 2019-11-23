using JsonFluently.Syntax;

namespace JsonFluently.Builders.Abstract
{
  public interface IFluentJsonBuilder
  {
    IJsonObjectSyntax CreateNew();
  }
}
