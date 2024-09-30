//HintName: G.IApplicationClientsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Manage app clients, and perform authentication operations for admin-level access control<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApplicationClientsClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}