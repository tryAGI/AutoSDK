using System.Collections.Immutable;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;
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
}
