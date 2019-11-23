using Json.Fluently.Syntax;

namespace Json.Fluently.Builders.Abstract
{
  public interface IFluentJsonBuilder
  {
    IJsonObjectSyntax CreateNew();
  }
}
