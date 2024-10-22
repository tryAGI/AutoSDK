//HintName: G.ISchemaClient.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Operate on the database schema. &lt;br/&gt;&lt;br/&gt;Note an 'Object class' in Weaviate is being renamed to a 'collection'. &lt;br/&gt;&lt;br/&gt;See &lt;a href='https://weaviate.io/developers/weaviate/manage-data/collections'&gt;this page&lt;/a&gt; for client code examples.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ISchemaClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


    }
}