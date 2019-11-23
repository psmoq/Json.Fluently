# Json.Fluently

**Json.Fluently** is a very simple JSON object builder written in C# (.NET Standard) using fluent design approach. It is built on top of **Newtonsoft.Json** library. This library makes JSON object creation easier and more human-readable.

## Usage

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

## License

MIT License

Copyright (c) 2019 psmoq

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
