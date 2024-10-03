//HintName: G.IBatchClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create, update and delete multiple objects and references at once. &lt;br/&gt;&lt;br/&gt;Note that object-level errors may be reported even in a successful batch request. Accordingly, we recommend you check the response body for errors.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IBatchClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}