//HintName: G.IEmbeddingsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Get a vector representation of a given input that can be easily consumed by machine learning models and algorithms.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IEmbeddingsClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}