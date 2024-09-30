//HintName: G.ICorporaClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create, manage, and update corpora and their associated settings for administration purposes<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ICorporaClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}