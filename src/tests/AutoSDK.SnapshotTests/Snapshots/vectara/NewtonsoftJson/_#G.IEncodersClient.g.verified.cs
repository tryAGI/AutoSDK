//HintName: G.IEncodersClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List encoders that turn text into vectors such as Boomerang<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IEncodersClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}