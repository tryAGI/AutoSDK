//HintName: G.IWellKnownClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `.well-known` endpoints. If OpenID Connect (OIDC) authentication is enabled, this endpoint includes OIDC configuration details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IWellKnownClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}