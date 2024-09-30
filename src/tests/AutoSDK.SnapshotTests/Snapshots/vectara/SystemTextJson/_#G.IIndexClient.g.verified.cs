//HintName: G.IIndexClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Index and manage core and structured documents for efficient search and retrieval<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IIndexClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}