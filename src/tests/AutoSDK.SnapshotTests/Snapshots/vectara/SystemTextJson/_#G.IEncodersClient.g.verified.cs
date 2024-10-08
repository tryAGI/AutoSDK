//HintName: G.IEncodersClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List available encoders (such as Boomerang) that turn text into vectors<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IEncodersClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}