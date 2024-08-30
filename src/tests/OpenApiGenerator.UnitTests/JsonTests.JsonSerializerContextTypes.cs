using OpenApiGenerator.Core.Models;
using static OpenApiGenerator.Core.Serialization.Json.SystemTextJsonSerializer;

namespace OpenApiGenerator.UnitTests;

public partial class JsonTests
{
    [TestMethod]
    public void ContextTypes()
    {
        GetContextType(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpType = "global::System.Collections.Generic.IList<string>",
            IsArray = true,
            SubTypes = [
                TypeData.Default with { CSharpType = "string" }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("IListString");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpType = "global::System.Collections.Generic.Dictionary<string, int>",
            SubTypes = [
                TypeData.Default with { CSharpType = "string" },
                TypeData.Default with { CSharpType = "int" }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("DictionaryStringInt32");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "System.Collections.Generic",
            CSharpType = "global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>",
            IsArray = true,
            SubTypes = [
                TypeData.Default with
                {
                    CSharpType = "global::System.Collections.Generic.IList<string>",
                    IsArray = true,
                    SubTypes = [
                        TypeData.Default with { CSharpType = "string" }
                    ],
                }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("IListIListString");
        
        GetContextType(TypeData.Default with
        {
            CSharpType = "byte[]",
            IsBinary = true,
            SubTypes = [
                TypeData.Default with { CSharpType = "byte" }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("ByteArray");
        
        GetContextType(TypeData.Default with
        {
            CSharpType = "byte[][]",
            IsBinary = true,
            SubTypes = [
                TypeData.Default with
                {
                    CSharpType = "byte[]",
                    IsBinary = true,
                    SubTypes = [
                        TypeData.Default with { CSharpType = "byte" }
                    ],
                }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("ByteArrayArray");
        
        GetContextType(TypeData.Default with
        {
            CSharpType = "global::System.Collections.Generic.IList<byte[]>",
            IsArray = true,
            SubTypes = [
                TypeData.Default with
                {
                    CSharpType = "byte[]",
                    IsBinary = true,
                    SubTypes = [
                        TypeData.Default with { CSharpType = "byte" }
                    ],
                }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("IListByteArray");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "System",
            IsValueType = true,
            CSharpType = "global::System.AllOf<Integration?, AppsCreateFromManifestResponse>",
            SubTypes = [
                TypeData.Default with
                {
                    CSharpType = "Integration?",
                },
                TypeData.Default with
                {
                    CSharpType = "AppsCreateFromManifestResponse"
                },
            ],
        }, makeNullableRootIfValueType: true).Should().Be("NullableAllOfIntegrationAppsCreateFromManifestResponse");
        
        GetContextType(TypeData.Default with
        {
            Namespace = "System",
            IsValueType = true,
            CSharpType = "global::System.OneOf<global::Cohere.NonStreamedChatResponse, global::Cohere.StreamedChatResponse?>",
            SubTypes = [
                TypeData.Default with
                {
                    Namespace = "Cohere",
                    CSharpType = "global::Cohere.NonStreamedChatResponse"
                },
                TypeData.Default with
                {
                    Namespace = "Cohere",
                    CSharpType = "global::Cohere.StreamedChatResponse?",
                    IsValueType = true,
                }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("NullableOneOfNonStreamedChatResponseNullableStreamedChatResponse");
        
        GetContextType(TypeData.Default with
        {
            CSharpType = "bool",
            IsValueType = true,
        }, makeNullableRootIfValueType: true).Should().Be("NullableBoolean");
        
        GetContextType(TypeData.Default with
        {
            CSharpType = "global::System.Collections.Generic.IList<byte[][]>",
            IsArray = true,
            SubTypes = [
                TypeData.Default with
                {
                    CSharpType = "byte[][]",
                    IsBinary = true,
                    SubTypes = [
                        TypeData.Default with
                        {
                            CSharpType = "byte[]",
                            IsBinary = true,
                            SubTypes = [
                                TypeData.Default with { CSharpType = "byte" }
                            ],
                        }
                    ],
                }
            ],
        }, makeNullableRootIfValueType: true).Should().Be("IListByteArrayArray");
    }
}