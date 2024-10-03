//HintName: G.INodesClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Retrieve information about relevant nodes in the cluster. The query can be for the entire cluster, or for a particular collection.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface INodesClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}