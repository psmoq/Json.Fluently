## Json.Fluently

# Description

**Json.Fluently** is a very simple JSON object builder written in C# (.NET Standard) using fluent design approach. It is built on top of **Newtonsoft.Json** library. This library makes JSON object creation easier and more human-readable.

# Usage
Example car JSON representation:

	var car = builder.CreateNew()
        .WithProperty("name", "Audi")
        .WithProperty("doorCount", 4)
        .WithObject("engine",
          objBuilder =>
          {
            return objBuilder
              .WithProperty("capacity", (decimal)2.0)
              .WithProperty("fuel", "diesel")
              .WithProperty("horsePower", 150);
          })
        .WithArray("wheels", arrBuilder =>
        {
          return arrBuilder.WithItems(objectBuilder => new[]
          {
            objectBuilder.CreateNew()
              .WithProperty("position", "front-left"),
            objectBuilder.CreateNew()
              .WithProperty("position", "front-right"),
            objectBuilder.CreateNew()
              .WithProperty("position", "rear-left"),
            objectBuilder.CreateNew()
              .WithProperty("position", "rear-right")
              .WithProperty("isFlat", true)
          });
        })
        .Build();
