//HintName: G.ISecretScanningClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Retrieve secret scanning alerts from a repository.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ISecretScanningClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}