using System.Collections.Immutable;
using System.Text.RegularExpressions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;
using AutoSDK.TypeMapping;
using static AutoSDK.Serialization.Json.SystemTextJsonSerializer;

namespace AutoSDK.UnitTests;

public partial class JsonTests
{
    private static TypeData T(TypeData type) => type.WithCSharpComputedValues();

    [TestMethod]
    public void ContextTypes()
    {
        GetContextType(T(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpTypeRaw = "global::System.Collections.Generic.IList<string>",
            IsArray = true,
            SubTypes = ImmutableArray.Create([
                T(TypeData.Default with { CSharpTypeRaw = "string" }).Box(),
            ]),
        }), makeNullableRootIfValueType: true).Should().Be("IListString");
        
        GetContextType(T(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpTypeRaw = "global::System.Collections.Generic.Dictionary<string, int>",
            SubTypes = ImmutableArray.Create([
                T(TypeData.Default with { CSharpTypeRaw = "string" }).Box(),
                T(TypeData.Default with { CSharpTypeRaw = "int" }).Box()
            ]),
        }), makeNullableRootIfValueType: true).Should().Be("DictionaryStringInt32");
        
        GetContextType(T(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpTypeRaw = "global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>",
            IsArray = true,
            SubTypes = ImmutableArray.Create([
                T(TypeData.Default with
                {
                    CSharpTypeRaw = "global::System.Collections.Generic.IList<string>",
                    IsArray = true,
                    SubTypes = ImmutableArray.Create([
                        T(TypeData.Default with { CSharpTypeRaw = "string" }).Box()
                    ]),
                }).Box()
            ]),
        }), makeNullableRootIfValueType: true).Should().Be("IListIListString");
        
        GetContextType(T(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpTypeRaw = "global::System.Collections.Generic.IList<global::System.Guid>",
            IsArray = true,
            SubTypes = ImmutableArray.Create([
                T(TypeData.Default with {
                    Namespace = "System",
                    CSharpTypeRaw = "global::System.Guid" }).Box()
            ]),
        }), makeNullableRootIfValueType: true).Should().Be("IListGuid");

        GetContextType(T(TypeData.Default with
        {
            CSharpTypeRaw = "byte[]",
            IsBinary = true,
            SubTypes = ImmutableArray.Create([
                T(TypeData.Default with { CSharpTypeRaw = "byte" }).Box()
            ]),
        }), makeNullableRootIfValueType: true).Should().Be("ByteArray");
        
        GetContextType(T(TypeData.Default with
        {
            CSharpTypeRaw = "byte[][]",
            IsBinary = true,
            SubTypes = ImmutableArray.Create([
                T(TypeData.Default with
                {
                    CSharpTypeRaw = "byte[]",
                    IsBinary = true,
                    SubTypes = ImmutableArray.Create([
                        T(TypeData.Default with { CSharpTypeRaw = "byte" }).Box()
                    ]),
                }).Box()
            ]),
        }), makeNullableRootIfValueType: true).Should().Be("ByteArrayArray");
        
        GetContextType(T(TypeData.Default with
        {
            CSharpTypeRaw = "global::System.Collections.Generic.IList<byte[]>",
            IsArray = true,
            SubTypes = ImmutableArray.Create([
                T(TypeData.Default with
                {
                    CSharpTypeRaw = "byte[]",
                    IsBinary = true,
                    SubTypes = ImmutableArray.Create([
                        T(TypeData.Default with { CSharpTypeRaw = "byte" }).Box()
                    ]),
                }).Box()
            ]),
        }), makeNullableRootIfValueType: true).Should().Be("IListByteArray");
        
        GetContextType(T(TypeData.Default with
        {
            Namespace = "G",
            IsValueType = true,
            CSharpTypeRaw = "global::G.AllOf<Integration?, AppsCreateFromManifestResponse>",
            SubTypes = ImmutableArray.Create([
                T(TypeData.Default with
                {
                    CSharpTypeRaw = "Integration",
                    CSharpTypeNullability = true,
                }).Box(),
                T(TypeData.Default with
                {
                    CSharpTypeRaw = "AppsCreateFromManifestResponse"
                }).Box(),
            ]),
        }), makeNullableRootIfValueType: true).Should().Be("NullableAllOfIntegrationAppsCreateFromManifestResponse");
        
        GetContextType(T(TypeData.Default with
        {
            Namespace = "Cohere",
            IsValueType = true,
            CSharpTypeRaw = "global::Cohere.OneOf<global::Cohere.NonStreamedChatResponse, global::Cohere.StreamedChatResponse?>",
            SubTypes = ImmutableArray.Create([
                T(TypeData.Default with
                {
                    Namespace = "Cohere",
                    CSharpTypeRaw = "global::Cohere.NonStreamedChatResponse"
                }).Box(),
                T(TypeData.Default with
                {
                    Namespace = "Cohere",
                    CSharpTypeRaw = "global::Cohere.StreamedChatResponse",
                    CSharpTypeNullability = true,
                    IsValueType = true,
                }).Box()
            ]),
        }), makeNullableRootIfValueType: true).Should().Be("NullableOneOfNonStreamedChatResponseNullableStreamedChatResponse");
        
        GetContextType(T(TypeData.Default with
        {
            CSharpTypeRaw = "bool",
            IsValueType = true,
        }), makeNullableRootIfValueType: true).Should().Be("NullableBoolean");
        
        GetContextType(T(TypeData.Default with
        {
            CSharpTypeRaw = "global::System.Collections.Generic.IList<byte[][]>",
            IsArray = true,
            SubTypes = ImmutableArray.Create([
                T(TypeData.Default with
                {
                    CSharpTypeRaw = "byte[][]",
                    IsBinary = true,
                    SubTypes = ImmutableArray.Create([
                        T(TypeData.Default with
                        {
                            CSharpTypeRaw = "byte[]",
                            IsBinary = true,
                            SubTypes = ImmutableArray.Create([
                                T(TypeData.Default with { CSharpTypeRaw = "byte" }).Box()
                            ]),
                        }).Box()
                    ]),
                }).Box()
            ]),
        }), makeNullableRootIfValueType: true).Should().Be("IListByteArrayArray");
    }

    [TestMethod]
    public void JsonSerializerContextTypes_UsesConfiguredSdkNamespace()
    {
        var settings = Settings.Default with
        {
            Namespace = "G",
        };
        var client = new Client(
            Id: "Converters",
            ClassName: string.Empty,
            FileNameWithoutExtension: "G.",
            InterfaceFileNameWithoutExtension: "G.I",
            BaseUrl: string.Empty,
            Clients: ImmutableArray<PropertyData>.Empty,
            Summary: string.Empty,
            BaseUrlSummary: string.Empty,
            Settings: settings,
            GlobalSettings: settings,
            Converters: ImmutableArray<string>.Empty);
        var systemEnvironment = T(TypeData.Default with
        {
            Namespace = "System",
            CSharpTypeRaw = "global::System.Environment",
        });

        var file = Sources.JsonSerializerContextTypes(
            client,
            ImmutableArray.Create(systemEnvironment).AsEquatableArray());

        file.Name.Should().Be("G.JsonSerializerContextTypes.g.cs");
        file.Text.Should().Contain("namespace G");
        file.Text.Should().NotContain("namespace System");
    }

    [TestMethod]
    public void JsonSerializerContext_ShortensHugeExplicitTypeInfoPropertyNames()
    {
        var policyNames = Enumerable.Range(1, 26)
            .Select(index => $"global::G.NewModerateModerateRequestPolicieVariant{index:D2}")
            .ToArray();
        var oneOfType = $"global::G.OneOf<{string.Join(", ", policyNames)}>";
        var settings = Settings.Default with
        {
            Namespace = "G",
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            JsonSerializerContext = "G.SourceGenerationContext",
            GenerateJsonSerializerContextTypes = true,
            FromCli = true,
        };
        var client = new Client(
            Id: "HugeUnion",
            ClassName: "HugeUnionClient",
            FileNameWithoutExtension: "G",
            InterfaceFileNameWithoutExtension: "IG",
            BaseUrl: string.Empty,
            Clients: ImmutableArray<PropertyData>.Empty,
            Summary: string.Empty,
            BaseUrlSummary: string.Empty,
            Settings: settings,
            GlobalSettings: settings,
            Converters: ImmutableArray<string>.Empty);
        var type = T(TypeData.Default with
        {
            Namespace = "G",
            GeneratedNamespace = "G",
            CSharpTypeRaw = $"{oneOfType}?",
            IsValueType = true,
            OneOfCount = policyNames.Length,
        });

        var file = Sources.JsonSerializerContext(
            client,
            ImmutableArray.Create(type).AsEquatableArray());
        var matches = Regex.Matches(file.Text, "TypeInfoPropertyName = \"([^\"]+)\"");
        var propertyNames = matches.Cast<Match>()
            .Select(match => match.Groups[1].Value)
            .ToArray();

        matches.Should().NotBeEmpty();
        propertyNames.Select(static value => value.Length).Max().Should().BeLessThanOrEqualTo(120);
        propertyNames.Should().OnlyContain(value => value.Contains("_", StringComparison.Ordinal));
    }

    [TestMethod]
    public void JsonSerializerContext_RegistersCollidingNullableValueTypeMetadataExplicitly()
    {
        var settings = Settings.Default with
        {
            Namespace = "G",
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            JsonSerializerContext = "G.SourceGenerationContext",
            GenerateJsonSerializerContextTypes = true,
            FromCli = true,
        };
        var client = new Client(
            Id: "NullableCollision",
            ClassName: "NullableCollisionClient",
            FileNameWithoutExtension: "G",
            InterfaceFileNameWithoutExtension: "IG",
            BaseUrl: string.Empty,
            Clients: ImmutableArray<PropertyData>.Empty,
            Summary: string.Empty,
            BaseUrlSummary: string.Empty,
            Settings: settings,
            GlobalSettings: settings,
            Converters: ImmutableArray<string>.Empty);
        var types = ImmutableArray.Create(
            T(TypeData.Default with
            {
                Namespace = "G",
                GeneratedNamespace = "G",
                CSharpTypeRaw = "global::G.SavedFunctionId",
                CSharpTypeNullability = true,
                IsValueType = true,
            }),
            T(TypeData.Default with
            {
                Namespace = "G",
                GeneratedNamespace = "G",
                CSharpTypeRaw = "global::G.NullableSavedFunctionId",
                IsValueType = true,
            }))
            .AsEquatableArray();

        var file = Sources.JsonSerializerContext(client, types);
        var contextTypesFile = Sources.JsonSerializerContextTypes(client, types);

        file.Text.Should().Contain("JsonSerializable(typeof(global::G.SavedFunctionId?), TypeInfoPropertyName = ");
        file.Text.Should().Contain("JsonSerializable(typeof(global::G.NullableSavedFunctionId), TypeInfoPropertyName = ");
        file.Text.Should().NotContain("TypeInfoPropertyName = \"NullableSavedFunctionId\"");
        contextTypesFile.Text.Should().NotContain("public global::G.SavedFunctionId? Type");
    }

    [TestMethod]
    public void JsonSerializerContext_RegistersCollidingConcreteListMetadataExplicitly()
    {
        var settings = Settings.Default with
        {
            Namespace = "G",
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            JsonSerializerContext = "G.SourceGenerationContext",
            GenerateJsonSerializerContextTypes = true,
            FromCli = true,
        };
        var client = new Client(
            Id: "ListCollision",
            ClassName: "ListCollisionClient",
            FileNameWithoutExtension: "G",
            InterfaceFileNameWithoutExtension: "IG",
            BaseUrl: string.Empty,
            Clients: ImmutableArray<PropertyData>.Empty,
            Summary: string.Empty,
            BaseUrlSummary: string.Empty,
            Settings: settings,
            GlobalSettings: settings,
            Converters: ImmutableArray<string>.Empty);
        var types = ImmutableArray.Create(
            T(TypeData.Default with
            {
                Namespace = "G",
                GeneratedNamespace = "G",
                CSharpTypeRaw = "global::G.ListChatResponse",
            }),
            T(TypeData.Default with
            {
                Namespace = "System.Collections.Generic",
                GeneratedNamespace = "G",
                CSharpTypeRaw = "global::System.Collections.Generic.IList<global::G.ChatResponse>",
                IsArray = true,
            }))
            .AsEquatableArray();

        var file = Sources.JsonSerializerContext(client, types);
        var contextTypesFile = Sources.JsonSerializerContextTypes(client, types);

        file.Text.Should().Contain("JsonSerializable(typeof(global::G.ListChatResponse), TypeInfoPropertyName = ");
        file.Text.Should().Contain("JsonSerializable(typeof(global::System.Collections.Generic.List<global::G.ChatResponse>), TypeInfoPropertyName = ");
        file.Text.Should().NotContain("TypeInfoPropertyName = \"ListChatResponse\"");
        contextTypesFile.Text.Should().NotContain("public global::G.ListChatResponse? Type");
        contextTypesFile.Text.Should().NotContain("public global::System.Collections.Generic.List<global::G.ChatResponse>? ListType");
    }

    [TestMethod]
    public void JsonSerializerContext_SplitsLargeContexts()
    {
        var settings = Settings.Default with
        {
            Namespace = "G",
            JsonSerializerType = JsonSerializerType.SystemTextJson,
            JsonSerializerContext = "G.SourceGenerationContext",
            GenerateJsonSerializerContextTypes = true,
            FromCli = true,
        };
        var client = new Client(
            Id: "LargeContext",
            ClassName: "LargeContextClient",
            FileNameWithoutExtension: "G",
            InterfaceFileNameWithoutExtension: "IG",
            BaseUrl: string.Empty,
            Clients: ImmutableArray<PropertyData>.Empty,
            Summary: string.Empty,
            BaseUrlSummary: string.Empty,
            Settings: settings,
            GlobalSettings: settings,
            Converters: ImmutableArray<string>.Empty);
        var types = Enumerable.Range(0, 520)
            .Select(index => T(TypeData.Default with
            {
                Namespace = "G",
                GeneratedNamespace = "G",
                CSharpTypeRaw = $"global::G.Model{index}",
            }))
            .ToImmutableArray()
            .AsEquatableArray();

        var file = Sources.JsonSerializerContext(client, types);

        file.Text.Should().Contain("internal sealed partial class SourceGenerationContextChunk0");
        file.Text.Should().Contain("internal sealed partial class SourceGenerationContextChunk1");
        file.Text.Should().Contain("global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(");
        file.Text.Should().Contain("public static SourceGenerationContext Default { get; } = new(DefaultOptions);");
        Regex.Matches(file.Text, "\\[global::System.Text.Json.Serialization.JsonSerializable").Count
            .Should().Be(521);
    }
}
