//HintName: G.IBackupsClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create, restore and check the status of backups. &lt;br/&gt;&lt;br/&gt;See the [backups page](https://weaviate.io/developers/weaviate/configuration/backups) for a general introduction, configuration, and tech background of backups.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IBackupsClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}