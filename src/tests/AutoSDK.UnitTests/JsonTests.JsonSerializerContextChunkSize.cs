using System.Collections.Immutable;
using System.Text.RegularExpressions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.UnitTests;

public partial class JsonTests
{
    private static Client ChunkSizeClient(int chunkSize)
    {
        var settings = Settings.Default with
        {
            Namespace = "G",
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            JsonSerializerContext = "G.SourceGenerationContext",
            GenerateJsonSerializerContextTypes = true,
            FromCli = true,
            JsonSerializerContextChunkSize = chunkSize,
        };
        return new Client(
            Id: "ChunkSize", ClassName: "ChunkSizeClient", FileNameWithoutExtension: "G",
            InterfaceFileNameWithoutExtension: "IG", BaseUrl: string.Empty,
            Clients: ImmutableArray<PropertyData>.Empty, Summary: string.Empty,
            BaseUrlSummary: string.Empty, Settings: settings, GlobalSettings: settings,
            Converters: ImmutableArray<string>.Empty);
    }

    [TestMethod]
    public void JsonSerializerContext_ChunkSizeSettingsRoundTrip()
    {
        Settings.Default.JsonSerializerContextChunkSize.Should().Be(500);
        CSharpSettings.Default.JsonSerializerContextChunkSize.Should().Be(500);
        var settings = Settings.Default with { JsonSerializerContextChunkSize = 2000 };
        CSharpSettings.FromSettings(settings).ToSettings().JsonSerializerContextChunkSize.Should().Be(2000);
    }

    [TestMethod]
    [DataRow(100, 520)]
    [DataRow(500, 520)]
    [DataRow(1000, 520)]
    [DataRow(2000, 520)]
    [DataRow(2000, 2050)]
    public void JsonSerializerContext_CustomChunkSizePreservesRegistrations(int chunkSize, int typeCount)
    {
        var types = Enumerable.Range(0, typeCount).Select(index => T(TypeData.Default with
        {
            Namespace = "G", GeneratedNamespace = "G", CSharpTypeRaw = $"global::G.Model{index}",
        })).ToImmutableArray().AsEquatableArray();
        var source = Sources.JsonSerializerContext(ChunkSizeClient(chunkSize), types).Text;
        for (var index = 0; index < typeCount; index++)
        {
            source.Should().Contain($"JsonSerializable(typeof(global::G.Model{index})");
        }
        var partitions = source.Split("internal sealed partial class SourceGenerationContextChunk");
        if (typeCount <= chunkSize)
        {
            partitions.Should().HaveCount(1);
            source.Should().Contain("public sealed partial class SourceGenerationContext :");
        }
        else
        {
            partitions.Length.Should().BeGreaterThan(2);
            // Each chunk's attributes precede its declaration. The final facade has none.
            foreach (var partition in partitions)
            {
                Regex.Matches(partition, @"\[global::System.Text.Json.Serialization.JsonSerializable")
                    .Count.Should().BeLessThanOrEqualTo(chunkSize);
            }
            source.Should().NotContain("JsonSerializable(typeof(global::G.JsonSerializerContextTypes))");
        }
    }

    [TestMethod]
    [DataRow(-1)]
    [DataRow(0)]
    [DataRow(2001)]
    public void JsonSerializerContext_RejectsUnsafeChunkSize(int chunkSize)
    {
        Action generate = () => Sources.JsonSerializerContext(
            ChunkSizeClient(chunkSize), ImmutableArray<TypeData>.Empty.AsEquatableArray());
        generate.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("*between 1 and 2000*");
    }
}
