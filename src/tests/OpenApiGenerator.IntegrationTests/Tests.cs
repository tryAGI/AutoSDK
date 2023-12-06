using System.Text.Json;

namespace OpenApiGenerator.IntegrationTests;

[TestClass]
public class NSwagGeneratorTests
{
    [TestMethod]
    public void Models()
    {
        var json = JsonSerializer.Serialize(new Error
        {
            Error1 = new(),
        });
        
        var error = JsonSerializer.Deserialize<Error>(json);
        error.Should().NotBeNull();
        error!.Error1.Should().BeEquivalentTo(new Error.Error_());
    }
}