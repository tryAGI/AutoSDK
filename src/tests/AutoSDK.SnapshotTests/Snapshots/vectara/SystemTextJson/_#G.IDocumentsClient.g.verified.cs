//HintName: G.IDocumentsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Retrieve and manage documents stored in a corpus for administrative tasks<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IDocumentsClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}