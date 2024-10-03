//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// # Introduction<br/>
    ///  Weaviate is an open source, AI-native vector database that helps developers create intuitive and reliable AI-powered applications. <br/>
    ///  ### Base Path <br/>
    /// The base path for the Weaviate server is structured as `[YOUR-WEAVIATE-HOST]:[PORT]/v1`. As an example, if you wish to access the `schema` endpoint on a local instance, you would navigate to `http://localhost:8080/v1/schema`. Ensure you replace `[YOUR-WEAVIATE-HOST]` and `[PORT]` with your actual server host and port number respectively. <br/>
    ///  ### Questions? <br/>
    /// If you have any comments or questions, please feel free to reach out to us at the community forum [https://forum.weaviate.io/](https://forum.weaviate.io/). <br/>
    /// ### Issues? <br/>
    /// If you find a bug or want to file a feature request, please open an issue on our GitHub repository for [Weaviate](https://github.com/weaviate/weaviate). <br/>
    /// ### Want more documentation? <br/>
    /// For a quickstart, code examples, concepts and more, please visit our [documentation page](https://weaviate.io/developers/weaviate).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// The root of the API. Note the base url is `/v1`.
        /// </summary>
        public RootClient Root { get; }

        /// <summary>
        /// Operate on the database schema. &lt;br/&gt;&lt;br/&gt;Note an 'Object class' in Weaviate is being renamed to a 'collection'. &lt;br/&gt;&lt;br/&gt;See &lt;a href='https://weaviate.io/developers/weaviate/manage-data/collections'&gt;this page&lt;/a&gt; for client code examples.
        /// </summary>
        public SchemaClient Schema { get; }

        /// <summary>
        /// Create, update and delete objects and cross-references.
        /// </summary>
        public ObjectsClient Objects { get; }

        /// <summary>
        /// Create, update and delete multiple objects and references at once. &lt;br/&gt;&lt;br/&gt;Note that object-level errors may be reported even in a successful batch request. Accordingly, we recommend you check the response body for errors.
        /// </summary>
        public BatchClient Batch { get; }

        /// <summary>
        /// Create, restore and check the status of backups. &lt;br/&gt;&lt;br/&gt;See the [backups page](https://weaviate.io/developers/weaviate/configuration/backups) for a general introduction, configuration, and tech background of backups.
        /// </summary>
        public BackupsClient Backups { get; }

        /// <summary>
        /// Retrieve information about the server such as the hostname, location, versions and modules.
        /// </summary>
        public MetaClient Meta { get; }

        /// <summary>
        /// Retrieve information about the cluster.
        /// </summary>
        public ClusterClient Cluster { get; }

        /// <summary>
        /// Retrieve information about relevant nodes in the cluster. The query can be for the entire cluster, or for a particular collection.
        /// </summary>
        public NodesClient Nodes { get; }

        /// <summary>
        /// `.well-known` endpoints. If OpenID Connect (OIDC) authentication is enabled, this endpoint includes OIDC configuration details.
        /// </summary>
        public WellKnownClient WellKnown { get; }

        /// <summary>
        /// Query data using the GraphQL query language. See the [Weaviate GraphQL documentation](https://weaviate.io/developers/weaviate/api/graphql) for query syntax details.
        /// </summary>
        public GraphqlClient Graphql { get; }

        /// <summary>
        /// Perform classification operations
        /// </summary>
        public ClassificationsClient Classifications { get; }

    }
}