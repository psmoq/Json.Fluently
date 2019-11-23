using JsonFluently.Builders.Abstract;
using JsonFluently.Syntax;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace JsonFluently.Builders
{
  public class JsonArrayBuilder
  {
    private JArray _jArray;

    public IJsonArraySyntax CreateNew(IFluentJsonBuilder builder)
    {
      _jArray = new JArray();

      return new JsonArraySyntax(_jArray, builder);
    }

    private class JsonArraySyntax : IJsonArraySyntax
    {
      private JArray _jArray;

      private IFluentJsonBuilder _builder;

      public JsonArraySyntax(JArray jArray, IFluentJsonBuilder builder)
      {
        _jArray = jArray;
        _builder = builder;
      }

      public IJsonArrayBuilder WithItems(JObject[] items)
      {
        foreach (var item in items)
          _jArray.Add(item);

        return this;
      }

      public IJsonArrayBuilder WithItems(Func<IFluentJsonBuilder, IJsonObjectBuilder[]> arraySyntaxFunc)
      {
        var items = arraySyntaxFunc(_builder).Select(c => c.Build());

        foreach (var item in items)
          _jArray.Add(item);

        return this;
      }

      public JArray Build()
      {
        return _jArray;
      }
    }
  }
}
