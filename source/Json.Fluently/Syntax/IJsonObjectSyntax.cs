using Json.Fluently.Builders.Abstract;
using Newtonsoft.Json.Linq;
using System;

namespace Json.Fluently.Syntax
{
  public interface IJsonObjectSyntax : IJsonObjectBuilder
  {
    IJsonObjectSyntax WithProperty(string propertyName, string value);

    IJsonObjectSyntax WithProperty(string propertyName, decimal value);

    IJsonObjectSyntax WithProperty(string propertyName, bool value);

    IJsonObjectSyntax WithObject(string objectName, JObject jObject);

    IJsonObjectSyntax WithArray(string arrayName, JArray jArray);

    IJsonObjectSyntax WithObject(string objectName, Func<IJsonObjectSyntax, IJsonObjectBuilder> objectSyntaxFunc);

    IJsonObjectSyntax WithArray(string arrayName, Func<IJsonArraySyntax, IJsonArrayBuilder> arraySyntaxFunc);
  }
}
