//HintName: G.ISpeechHistoryClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Accesses your speech history. Your speech history is a list of all your created audio including its metadata using our text-to-speech and speech-to-speech models.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ISpeechHistoryClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}