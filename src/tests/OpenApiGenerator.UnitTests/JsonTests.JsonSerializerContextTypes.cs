using static OpenApiGenerator.Core.Json.SystemTextJsonSerializer;

namespace OpenApiGenerator.UnitTests;

public partial class JsonTests
{
    [TestMethod]
    public void ContextTypes()
    {
        GetContextType("global::System.Collections.Generic.List<string>").Should().Be("ListString");
        GetContextType("global::System.Collections.Generic.Dictionary<string, int>").Should().Be("DictionaryStringInt32");
        GetContextType("byte[]").Should().Be("ByteArray");
        GetContextType("byte[][]").Should().Be("ByteArrayArray");
        GetContextType("global::System.Collections.Generic.List<byte[]>").Should().Be("ListByteArray");
        GetContextType("global::System.Collections.Generic.List<byte[][]>").Should().Be("ListByteArrayArray");
        GetContextType("bool").Should().Be("NullableBoolean");
    }
}