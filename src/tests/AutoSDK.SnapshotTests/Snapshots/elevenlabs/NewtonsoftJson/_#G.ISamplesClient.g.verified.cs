//HintName: G.ISamplesClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Access to your samples. A sample is any audio file you attached to a voice. A voice can have one or more samples.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ISamplesClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}