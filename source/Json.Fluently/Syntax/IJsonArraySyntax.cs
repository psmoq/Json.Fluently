using Json.Fluently.Builders.Abstract;
using Newtonsoft.Json.Linq;
using System;

namespace Json.Fluently.Syntax
{
  public interface IJsonArraySyntax : IJsonArrayBuilder
  {
    IJsonArrayBuilder WithItems(JObject[] items);

    IJsonArrayBuilder WithItems(Func<IFluentJsonBuilder, IJsonObjectSyntax[]> arraySyntaxFunc);
  }
}
