using System.Collections.Immutable;
using System.Text.RegularExpressions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;
using AutoSDK.TypeMapping;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using static AutoSDK.Serialization.Json.SystemTextJsonSerializer;

namespace AutoSDK.UnitTests;

public partial class JsonTests
{
    private static TypeData T(TypeData type) => type.WithCSharpComputedValues();

    private static void AssertGeneratedSourcesCompile(params FileWithName[] files)
    {
        var parseOptions = new CSharpParseOptions(documentationMode: DocumentationMode.Diagnose);
        var syntaxTrees = files
            .Select(file => CSharpSyntaxTree.ParseText(
                file.Text,
                parseOptions,
                path: file.Name))
            .ToArray();
        var references = ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!)
            .Split(Path.PathSeparator)
            .Where(static path => !string.IsNullOrWhiteSpace(path))
            .Select(static path => MetadataReference.CreateFromFile(path))
            .ToArray();
        var compilation = CSharpCompilation.Create(
            assemblyName: "AutoSDKGeneratedSources",
            syntaxTrees: syntaxTrees,
            references: references,
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
        var diagnostics = compilation.GetDiagnostics()
            .Where(static diagnostic => diagnostic.Severity == DiagnosticSeverity.Error)
            .Select(static diagnostic => diagnostic.ToString())
            .ToArray();

        diagnostics.Should().BeEmpty(
            "generated sources should compile. Found:{0}{1}",
            Environment.NewLine,
            string.Join(Environment.NewLine + Environment.NewLine, diagnostics));
    }

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
    public void JsonSerializerContext_WithNoTypes_EmitsConcreteEmptyContext()
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
            Id: "EmptyContext",
            ClassName: "EmptyContextClient",
            FileNameWithoutExtension: "G",
            InterfaceFileNameWithoutExtension: "IG",
            BaseUrl: string.Empty,
            Clients: ImmutableArray<PropertyData>.Empty,
            Summary: string.Empty,
            BaseUrlSummary: string.Empty,
            Settings: settings,
            GlobalSettings: settings,
            Converters: ImmutableArray<string>.Empty);

        var file = Sources.JsonSerializerContext(
            client,
            ImmutableArray<TypeData>.Empty.AsEquatableArray());

        file.Name.Should().Be("G.JsonSerializerContext.g.cs");
        file.Text.Should().Contain(
            "public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext");
        file.Text.Should().Contain(
            "protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;");
        file.Text.Should().Contain(
            "public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)");
        file.Text.Should().NotContain("JsonSerializable(typeof(");
        AssertGeneratedSourcesCompile(file);
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
        file.Text.Should().NotContain("JsonSerializable(typeof(global::G.JsonSerializerContextTypes))");
        file.Text.Should().Contain("JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))");
        file.Text.Should().Contain("JsonSerializable(typeof(global::System.Text.Json.JsonElement?))");
        Regex.Matches(file.Text, "\\[global::System.Text.Json.Serialization.JsonSerializable").Count
            .Should().Be(523);
    }

    [TestMethod]
    public void JsonSerializerContext_SplitsAdvantageSizedContextsWithoutAggregateRegistration()
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
            Id: "AdvantageSizedContext",
            ClassName: "AdvantageSizedContextClient",
            FileNameWithoutExtension: "G",
            InterfaceFileNameWithoutExtension: "IG",
            BaseUrl: string.Empty,
            Clients: ImmutableArray<PropertyData>.Empty,
            Summary: string.Empty,
            BaseUrlSummary: string.Empty,
            Settings: settings,
            GlobalSettings: settings,
            Converters: ImmutableArray<string>.Empty);
        var types = Enumerable.Range(0, 3347)
            .Select(index => T(TypeData.Default with
            {
                Namespace = "G",
                GeneratedNamespace = "G",
                CSharpTypeRaw = $"global::G.Model{index}",
            }))
            .ToImmutableArray()
            .AsEquatableArray();

        var file = Sources.JsonSerializerContext(client, types);

        Regex.Matches(file.Text, "internal sealed partial class SourceGenerationContextChunk").Count
            .Should().Be(7);
        Regex.Matches(file.Text, "\\[global::System.Text.Json.Serialization.JsonSerializable").Count
            .Should().Be(3350);
        file.Text.Should().NotContain("JsonSerializable(typeof(global::G.JsonSerializerContextTypes))");
    }

    [TestMethod]
    public void JsonSerializerContext_DoesNotRegisterCollapsedReferenceModelsAsNullableValueTypes()
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
            Id: "CollapsedReferenceContext",
            ClassName: "CollapsedReferenceContextClient",
            FileNameWithoutExtension: "G",
            InterfaceFileNameWithoutExtension: "IG",
            BaseUrl: string.Empty,
            Clients: ImmutableArray<PropertyData>.Empty,
            Summary: string.Empty,
            BaseUrlSummary: string.Empty,
            Settings: settings,
            GlobalSettings: settings,
            Converters: ImmutableArray<string>.Empty);
        var types = Enumerable.Range(0, 501)
            .Select(index => T(TypeData.Default with
            {
                Namespace = "G",
                GeneratedNamespace = "G",
                CSharpTypeRaw = $"global::G.Model{index}",
            }))
            .Append(T(TypeData.Default with
            {
                Namespace = "G",
                GeneratedNamespace = "G",
                CSharpTypeRaw = "global::G.CollapsedReferenceModel",
                CSharpTypeNullability = true,
                IsValueType = true,
                SubTypes = ImmutableArray.Create([
                    T(TypeData.Default with
                    {
                        Namespace = "G",
                        GeneratedNamespace = "G",
                        CSharpTypeRaw = "global::G.CollapsedReferenceModel",
                    }).Box(),
                ]),
            }))
            .ToImmutableArray()
            .AsEquatableArray();

        var file = Sources.JsonSerializerContext(client, types);

        file.Text.Should().Contain("JsonSerializable(typeof(global::G.CollapsedReferenceModel))");
        file.Text.Should().NotContain("JsonSerializable(typeof(global::G.CollapsedReferenceModel?)");
    }

    [TestMethod]
    public void JsonSerializerContext_ChunksOversizedGuardSetsLinearly()
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
            Id: "VercelSizedContext",
            ClassName: "VercelSizedContextClient",
            FileNameWithoutExtension: "G",
            InterfaceFileNameWithoutExtension: "IG",
            BaseUrl: string.Empty,
            Clients: ImmutableArray<PropertyData>.Empty,
            Summary: string.Empty,
            BaseUrlSummary: string.Empty,
            Settings: settings,
            GlobalSettings: settings,
            Converters: ImmutableArray<string>.Empty);
        var collidingTypes = Enumerable.Range(0, 600)
            .SelectMany(index => new[]
            {
                T(TypeData.Default with
                {
                    Namespace = "G",
                    GeneratedNamespace = "G",
                    CSharpTypeRaw = $"global::G.Model{index}",
                    CSharpTypeNullability = true,
                    IsValueType = true,
                }),
                T(TypeData.Default with
                {
                    Namespace = "G",
                    GeneratedNamespace = "G",
                    CSharpTypeRaw = $"global::G.NullableModel{index}",
                    IsValueType = true,
                }),
            });
        var regularTypes = Enumerable.Range(0, 600)
            .Select(index => T(TypeData.Default with
            {
                Namespace = "G",
                GeneratedNamespace = "G",
                CSharpTypeRaw = $"global::G.RegularModel{index}",
            }));
        var types = collidingTypes
            .Concat(regularTypes)
            .ToImmutableArray()
            .AsEquatableArray();

        var file = Sources.JsonSerializerContext(client, types);

        Regex.Matches(file.Text, "\\[global::System.Text.Json.Serialization.JsonSerializable").Count
            .Should().BeLessThan(3100);
        Regex.Matches(file.Text, "internal sealed partial class SourceGenerationContextChunk").Count
            .Should().BeGreaterThan(1);
        file.Text.Should().Contain("global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(");
    }
}
