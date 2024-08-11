using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.UnitTests;

[TestClass]
public partial class NamingTests
{
    [TestMethod]
    public void ArrayItems()
    {
        var settings = Settings.Default;
        var context = new SchemaContext
        {
            Parent = new SchemaContext
            {
                Parent = new SchemaContext
                {
                    Schema = new OpenApiSchema(),
                    Id = string.Empty,
                    Type = "class",
                    Settings = settings,
                },
            
                Schema = new OpenApiSchema(),
                Id = "Choices",
                Type = "array",
                Settings = settings,
            },
            
            Schema = new OpenApiSchema(),
            Id = "ChoicesItem",
            Type = "class",
            Settings = settings,
            
            Hint = Hint.ArrayItem,
        };
    }
}