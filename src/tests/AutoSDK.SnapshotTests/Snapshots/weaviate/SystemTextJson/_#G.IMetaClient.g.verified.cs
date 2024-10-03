//HintName: G.IMetaClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Retrieve information about the server such as the hostname, location, versions and modules.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IMetaClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}