using JsonFluently.Builders.Abstract;
using Newtonsoft.Json.Linq;
using System;

namespace JsonFluently.Syntax
{
  public interface IJsonArraySyntax : IJsonArrayBuilder
  {
    IJsonArrayBuilder WithItems(JObject[] items);

    IJsonArrayBuilder WithItems(Func<IFluentJsonBuilder, IJsonObjectBuilder[]> arraySyntaxFunc);
  }
}
