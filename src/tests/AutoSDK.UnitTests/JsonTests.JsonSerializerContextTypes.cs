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
            SubTypes = [
                TypeData.Default with { CSharpTypeRaw = "string" }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("IListString");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpTypeRaw = "global::System.Collections.Generic.Dictionary<string, int>",
            SubTypes = [
                TypeData.Default with { CSharpTypeRaw = "string" },
                TypeData.Default with { CSharpTypeRaw = "int" }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("DictionaryStringInt32");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpTypeRaw = "global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>",
            IsArray = true,
            SubTypes = [
                TypeData.Default with
                {
                    CSharpTypeRaw = "global::System.Collections.Generic.IList<string>",
                    IsArray = true,
                    SubTypes = [
                        TypeData.Default with { CSharpTypeRaw = "string" }
                    ],
                }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("IListIListString");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpTypeRaw = "global::System.Collections.Generic.IList<global::System.Guid>",
            IsArray = true,
            SubTypes = [
                TypeData.Default with { 
                    Namespace = "System",
                    CSharpTypeRaw = "global::System.Guid" }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("IListGuid");

        GetContextType(TypeData.Default with
        {
            CSharpTypeRaw = "byte[]",
            IsBinary = true,
            SubTypes = [
                TypeData.Default with { CSharpTypeRaw = "byte" }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("ByteArray");
        
        GetContextType(TypeData.Default with
        {
            CSharpTypeRaw = "byte[][]",
            IsBinary = true,
            SubTypes = [
                TypeData.Default with
                {
                    CSharpTypeRaw = "byte[]",
                    IsBinary = true,
                    SubTypes = [
                        TypeData.Default with { CSharpTypeRaw = "byte" }
                    ],
                }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("ByteArrayArray");
        
        GetContextType(TypeData.Default with
        {
            CSharpTypeRaw = "global::System.Collections.Generic.IList<byte[]>",
            IsArray = true,
            SubTypes = [
                TypeData.Default with
                {
                    CSharpTypeRaw = "byte[]",
                    IsBinary = true,
                    SubTypes = [
                        TypeData.Default with { CSharpTypeRaw = "byte" }
                    ],
                }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("IListByteArray");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "G",
            IsValueType = true,
            CSharpTypeRaw = "global::G.AllOf<Integration?, AppsCreateFromManifestResponse>",
            SubTypes = [
                TypeData.Default with
                {
                    CSharpTypeRaw = "Integration",
                    CSharpTypeNullability = true,
                },
                TypeData.Default with
                {
                    CSharpTypeRaw = "AppsCreateFromManifestResponse"
                },
            ],
        }, makeNullableRootIfValueType: true).Should().Be("NullableAllOfIntegrationAppsCreateFromManifestResponse");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "Cohere",
            IsValueType = true,
            CSharpTypeRaw = "global::Cohere.OneOf<global::Cohere.NonStreamedChatResponse, global::Cohere.StreamedChatResponse?>",
            SubTypes = [
                TypeData.Default with
                {
                    Namespace = "Cohere",
                    CSharpTypeRaw = "global::Cohere.NonStreamedChatResponse"
                },
                TypeData.Default with
                {
                    Namespace = "Cohere",
                    CSharpTypeRaw = "global::Cohere.StreamedChatResponse",
                    CSharpTypeNullability = true,
                    IsValueType = true,
                }
            ],
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
            SubTypes = [
                TypeData.Default with
                {
                    CSharpTypeRaw = "byte[][]",
                    IsBinary = true,
                    SubTypes = [
                        TypeData.Default with
                        {
                            CSharpTypeRaw = "byte[]",
                            IsBinary = true,
                            SubTypes = [
                                TypeData.Default with { CSharpTypeRaw = "byte" }
                            ],
                        }
                    ],
                }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("IListByteArrayArray");
    }
}