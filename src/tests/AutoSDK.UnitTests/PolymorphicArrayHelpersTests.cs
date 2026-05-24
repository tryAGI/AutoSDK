using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class PolymorphicArrayHelpersTests
{
    [TestMethod]
    public void Helpers_WhenDisabled_OmitFile()
    {
        var settings = Settings.Default with { Namespace = "Demo" };

        var file = Sources.PolymorphicArrayHelpers(settings);

        file.Should().Be(FileWithName.Empty);
    }

    [TestMethod]
    public void Helpers_WhenEnabled_EmitBaseConverterAndAttribute()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GeneratePolymorphicArrayHelpers = true,
        };

        var file = Sources.PolymorphicArrayHelpers(settings);

        file.Name.Should().Be("Demo.AutoSDKPolymorphicFormat.g.cs");
        file.Text.Should().Contain("public abstract partial class AutoSDKPolymorphicFormat");
        file.Text.Should().Contain("public abstract string Type { get; }");
        file.Text.Should().Contain("public virtual bool IsBareString => false;");
        file.Text.Should().Contain("public sealed class AutoSDKPolymorphicFormatVariantAttribute : global::System.Attribute");
        file.Text.Should().Contain("public sealed class AutoSDKPolymorphicFormatJsonConverter<TBase>");
        file.Text.Should().Contain("where TBase : global::Demo.AutoSDKPolymorphicFormat");
        // Reads bare strings AND objects via type discriminator.
        file.Text.Should().Contain("if (reader.TokenType == global::System.Text.Json.JsonTokenType.String)");
        file.Text.Should().Contain("if (reader.TokenType != global::System.Text.Json.JsonTokenType.StartObject)");
        file.Text.Should().Contain("if (!document.RootElement.TryGetProperty(\"type\", out var typeElement)");
        // Writes the symmetric form.
        file.Text.Should().Contain("if (value.IsBareString)");
        file.Text.Should().Contain("writer.WriteStringValue(value.Type);");
        // AOT/trim diagnostics.
        file.Text.Should().Contain("RequiresDynamicCode");
        file.Text.Should().Contain("RequiresUnreferencedCode");
    }
}
