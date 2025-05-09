using System.Collections.Immutable;
using AutoSDK.Helpers;
using AutoSDK.Models;
using static AutoSDK.Serialization.Json.SystemTextJsonSerializer;

namespace AutoSDK.UnitTests;

public partial class JsonTests
{
    [TestMethod]
    public void ContextTypes()
    {
        GetContextType(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpTypeRaw = "global::System.Collections.Generic.IList<string>",
            IsArray = true,
            SubTypes = ImmutableArray.Create([
                (TypeData.Default with { CSharpTypeRaw = "string" }).Box(),
            ]),
        }, makeNullableRootIfValueType: true).Should().Be("IListString");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpTypeRaw = "global::System.Collections.Generic.Dictionary<string, int>",
            SubTypes = ImmutableArray.Create([
                (TypeData.Default with { CSharpTypeRaw = "string" }).Box(),
                (TypeData.Default with { CSharpTypeRaw = "int" }).Box()
            ]),
        }, makeNullableRootIfValueType: true).Should().Be("DictionaryStringInt32");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpTypeRaw = "global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>",
            IsArray = true,
            SubTypes = ImmutableArray.Create([
                (TypeData.Default with
                {
                    CSharpTypeRaw = "global::System.Collections.Generic.IList<string>",
                    IsArray = true,
                    SubTypes = ImmutableArray.Create([
                        (TypeData.Default with { CSharpTypeRaw = "string" }).Box()
                    ]),
                }).Box()
            ]),
        }, makeNullableRootIfValueType: true).Should().Be("IListIListString");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpTypeRaw = "global::System.Collections.Generic.IList<global::System.Guid>",
            IsArray = true,
            SubTypes = ImmutableArray.Create([
                (TypeData.Default with { 
                    Namespace = "System",
                    CSharpTypeRaw = "global::System.Guid" }).Box()
            ]),
        }, makeNullableRootIfValueType: true).Should().Be("IListGuid");

        GetContextType(TypeData.Default with
        {
            CSharpTypeRaw = "byte[]",
            IsBinary = true,
            SubTypes = ImmutableArray.Create([
                (TypeData.Default with { CSharpTypeRaw = "byte" }).Box()
            ]),
        }, makeNullableRootIfValueType: true).Should().Be("ByteArray");
        
        GetContextType(TypeData.Default with
        {
            CSharpTypeRaw = "byte[][]",
            IsBinary = true,
            SubTypes = ImmutableArray.Create([
                (TypeData.Default with
                {
                    CSharpTypeRaw = "byte[]",
                    IsBinary = true,
                    SubTypes = ImmutableArray.Create([
                        (TypeData.Default with { CSharpTypeRaw = "byte" }).Box()
                    ]),
                }).Box()
            ]),
        }, makeNullableRootIfValueType: true).Should().Be("ByteArrayArray");
        
        GetContextType(TypeData.Default with
        {
            CSharpTypeRaw = "global::System.Collections.Generic.IList<byte[]>",
            IsArray = true,
            SubTypes = ImmutableArray.Create([
                (TypeData.Default with
                {
                    CSharpTypeRaw = "byte[]",
                    IsBinary = true,
                    SubTypes = ImmutableArray.Create([
                        (TypeData.Default with { CSharpTypeRaw = "byte" }).Box()
                    ]),
                }).Box()
            ]),
        }, makeNullableRootIfValueType: true).Should().Be("IListByteArray");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "G",
            IsValueType = true,
            CSharpTypeRaw = "global::G.AllOf<Integration?, AppsCreateFromManifestResponse>",
            SubTypes = ImmutableArray.Create([
                (TypeData.Default with
                {
                    CSharpTypeRaw = "Integration",
                    CSharpTypeNullability = true,
                }).Box(),
                (TypeData.Default with
                {
                    CSharpTypeRaw = "AppsCreateFromManifestResponse"
                }).Box(),
            ]),
        }, makeNullableRootIfValueType: true).Should().Be("NullableAllOfIntegrationAppsCreateFromManifestResponse");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "Cohere",
            IsValueType = true,
            CSharpTypeRaw = "global::Cohere.OneOf<global::Cohere.NonStreamedChatResponse, global::Cohere.StreamedChatResponse?>",
            SubTypes = ImmutableArray.Create([
                (TypeData.Default with
                {
                    Namespace = "Cohere",
                    CSharpTypeRaw = "global::Cohere.NonStreamedChatResponse"
                }).Box(),
                (TypeData.Default with
                {
                    Namespace = "Cohere",
                    CSharpTypeRaw = "global::Cohere.StreamedChatResponse",
                    CSharpTypeNullability = true,
                    IsValueType = true,
                }).Box()
            ]),
        }, makeNullableRootIfValueType: true).Should().Be("NullableOneOfNonStreamedChatResponseNullableStreamedChatResponse");
        
        GetContextType(TypeData.Default with
        {
            CSharpTypeRaw = "bool",
            IsValueType = true,
        }, makeNullableRootIfValueType: true).Should().Be("NullableBoolean");
        
        GetContextType(TypeData.Default with
        {
            CSharpTypeRaw = "global::System.Collections.Generic.IList<byte[][]>",
            IsArray = true,
            SubTypes = ImmutableArray.Create([
                (TypeData.Default with
                {
                    CSharpTypeRaw = "byte[][]",
                    IsBinary = true,
                    SubTypes = ImmutableArray.Create([
                        (TypeData.Default with
                        {
                            CSharpTypeRaw = "byte[]",
                            IsBinary = true,
                            SubTypes = ImmutableArray.Create([
                                (TypeData.Default with { CSharpTypeRaw = "byte" }).Box()
                            ]),
                        }).Box()
                    ]),
                }).Box()
            ]),
        }, makeNullableRootIfValueType: true).Should().Be("IListByteArrayArray");
    }
}