//HintName: G.IEmbeddingsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Get a vector representation of a given input.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IEmbeddingsClient : global::System.IDisposable
    {
        /// <summary>
        /// Ollama server URL
        /// </summary>
        public const string BaseUrl = "http://localhost:11434/api";

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}