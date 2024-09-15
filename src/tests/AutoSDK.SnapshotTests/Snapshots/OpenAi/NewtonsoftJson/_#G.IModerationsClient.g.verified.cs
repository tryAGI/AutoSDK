//HintName: G.IModerationsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Given a input text, outputs if the model classifies it as potentially harmful.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IModerationsClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}