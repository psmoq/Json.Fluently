using Json.Fluently.Builders.Abstract;
using Json.Fluently.Syntax;
using Newtonsoft.Json.Linq;
using System;

namespace Json.Fluently.Builders
{
  public class JsonObjectBuilder
  {
    private JObject _jObject;

    public IJsonObjectSyntax CreateNew(IFluentJsonBuilder builder)
    {
      _jObject = new JObject();

      return new JsonObjectSyntax(_jObject, builder);
    }

    private class JsonObjectSyntax : IJsonObjectSyntax
    {
      private readonly JObject _jObject;

      private readonly IFluentJsonBuilder _builder;

      public JsonObjectSyntax(JObject jObject, IFluentJsonBuilder builder)
      {
        _jObject = jObject;
        _builder = builder;
      }

      public IJsonObjectSyntax WithProperty(string propertyName, string value)
      {
        _jObject.Add(propertyName, value);

        return this;
      }

      public IJsonObjectSyntax WithProperty(string propertyName, decimal value)
      {
        _jObject.Add(propertyName, value);

        return this;
      }

      public IJsonObjectSyntax WithProperty(string propertyName, bool value)
      {
        _jObject.Add(propertyName, value);

        return this;
      }

      public IJsonObjectSyntax WithObject(string objectName, JObject jObject)
      {
        _jObject.Add(objectName, jObject);

        return this;
      }

      public IJsonObjectSyntax WithArray(string arrayName, JArray jArray)
      {
        _jObject.Add(arrayName, jArray);

        return this;
      }

      public IJsonObjectSyntax WithObject(string objectName, Func<IFluentJsonBuilder, IJsonObjectBuilder> objectSyntaxFunc)
      {
        var syntax = objectSyntaxFunc(_builder);

        _jObject.Add(objectName, syntax.Build());

        return this;
      }

      public IJsonObjectSyntax WithArray(string arrayName, Func<IJsonArraySyntax, IJsonArrayBuilder> arraySyntaxFunc)
      {
        var arraySyntax = new JsonArrayBuilder().CreateNew(_builder);

        var syntax = arraySyntaxFunc(arraySyntax);

        _jObject.Add(arrayName, syntax.Build());

        return this;
      }

      public JObject Build()
      {
        return _jObject;
      }
    }
  }
}
