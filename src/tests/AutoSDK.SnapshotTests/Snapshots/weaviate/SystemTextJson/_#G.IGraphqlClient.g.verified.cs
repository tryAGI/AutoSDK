//HintName: G.IGraphqlClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Query data using the GraphQL query language. See the [Weaviate GraphQL documentation](https://weaviate.io/developers/weaviate/api/graphql) for query syntax details.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IGraphqlClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


    }
}