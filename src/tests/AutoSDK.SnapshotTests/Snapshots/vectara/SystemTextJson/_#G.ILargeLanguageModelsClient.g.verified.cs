//HintName: G.ILargeLanguageModelsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List LLMs for text summarization, chat, and other generation tasks<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ILargeLanguageModelsClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}