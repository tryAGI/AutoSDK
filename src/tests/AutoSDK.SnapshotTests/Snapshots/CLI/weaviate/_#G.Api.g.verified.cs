﻿//HintName: G.Api.g.cs

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
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https:///v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.ReplicationConfigObjectDeletionConflictResolutionJsonConverter(),
                    new global::G.JsonConverters.ReplicationConfigObjectDeletionConflictResolutionNullableJsonConverter(),
                    new global::G.JsonConverters.StopwordConfigPresetJsonConverter(),
                    new global::G.JsonConverters.StopwordConfigPresetNullableJsonConverter(),
                    new global::G.JsonConverters.PatchDocumentObjectOpJsonConverter(),
                    new global::G.JsonConverters.PatchDocumentObjectOpNullableJsonConverter(),
                    new global::G.JsonConverters.PatchDocumentActionOpJsonConverter(),
                    new global::G.JsonConverters.PatchDocumentActionOpNullableJsonConverter(),
                    new global::G.JsonConverters.VectorizerJsonConverter(),
                    new global::G.JsonConverters.VectorizerNullableJsonConverter(),
                    new global::G.JsonConverters.VectorIndexTypeJsonConverter(),
                    new global::G.JsonConverters.VectorIndexTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TokenizationJsonConverter(),
                    new global::G.JsonConverters.TokenizationNullableJsonConverter(),
                    new global::G.JsonConverters.DataTypeItemJsonConverter(),
                    new global::G.JsonConverters.DataTypeItemNullableJsonConverter(),
                    new global::G.JsonConverters.BackupCreateStatusResponseStatusJsonConverter(),
                    new global::G.JsonConverters.BackupCreateStatusResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BackupRestoreStatusResponseStatusJsonConverter(),
                    new global::G.JsonConverters.BackupRestoreStatusResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BackupConfigCompressionLevelJsonConverter(),
                    new global::G.JsonConverters.BackupConfigCompressionLevelNullableJsonConverter(),
                    new global::G.JsonConverters.BackupCreateResponseStatusJsonConverter(),
                    new global::G.JsonConverters.BackupCreateResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BackupListResponseItemStatusJsonConverter(),
                    new global::G.JsonConverters.BackupListResponseItemStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BackupRestoreResponseStatusJsonConverter(),
                    new global::G.JsonConverters.BackupRestoreResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.NodeStatusStatusJsonConverter(),
                    new global::G.JsonConverters.NodeStatusStatusNullableJsonConverter(),
                    new global::G.JsonConverters.StatisticsStatusJsonConverter(),
                    new global::G.JsonConverters.StatisticsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BatchReferenceResponseVariant2ResultStatusJsonConverter(),
                    new global::G.JsonConverters.BatchReferenceResponseVariant2ResultStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsGetResponseVariant3ResultStatusJsonConverter(),
                    new global::G.JsonConverters.ObjectsGetResponseVariant3ResultStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BatchDeleteOutputJsonConverter(),
                    new global::G.JsonConverters.BatchDeleteOutputNullableJsonConverter(),
                    new global::G.JsonConverters.BatchDeleteResponseOutputJsonConverter(),
                    new global::G.JsonConverters.BatchDeleteResponseOutputNullableJsonConverter(),
                    new global::G.JsonConverters.BatchDeleteResponseResultsObjectStatusJsonConverter(),
                    new global::G.JsonConverters.BatchDeleteResponseResultsObjectStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ClassificationStatusJsonConverter(),
                    new global::G.JsonConverters.ClassificationStatusNullableJsonConverter(),
                    new global::G.JsonConverters.WhereFilterOperatorJsonConverter(),
                    new global::G.JsonConverters.WhereFilterOperatorNullableJsonConverter(),
                    new global::G.JsonConverters.TenantActivityStatusJsonConverter(),
                    new global::G.JsonConverters.TenantActivityStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BatchObjectsCreateRequestFieldJsonConverter(),
                    new global::G.JsonConverters.BatchObjectsCreateRequestFieldNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsListOrderJsonConverter(),
                    new global::G.JsonConverters.ObjectsListOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsCreateConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.ObjectsCreateConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsUpdateConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.ObjectsUpdateConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsDeleteConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.ObjectsDeleteConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsPatchConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.ObjectsPatchConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassGetConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassGetConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassPutConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassPutConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassDeleteConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassDeleteConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassHeadConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassHeadConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassPatchConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassPatchConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassReferencesPutConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassReferencesPutConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassReferencesCreateConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassReferencesCreateConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassReferencesDeleteConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.ObjectsClassReferencesDeleteConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.BatchObjectsCreateConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.BatchObjectsCreateConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.BatchObjectsDeleteConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.BatchObjectsDeleteConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.BatchReferencesCreateConsistencyLevelJsonConverter(),
                    new global::G.JsonConverters.BatchReferencesCreateConsistencyLevelNullableJsonConverter(),
                    new global::G.JsonConverters.NodesGetOutputJsonConverter(),
                    new global::G.JsonConverters.NodesGetOutputNullableJsonConverter(),
                    new global::G.JsonConverters.NodesGetClassOutputJsonConverter(),
                    new global::G.JsonConverters.NodesGetClassOutputNullableJsonConverter(),
                    new global::G.JsonConverters.BatchReferenceResponseJsonConverter(),
                    new global::G.JsonConverters.ObjectsGetResponseJsonConverter(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// The root of the API. Note the base url is `/v1`.
        /// </summary>
        public RootClient Root => new RootClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Operate on the database schema. &lt;br/&gt;&lt;br/&gt;Note an 'Object class' in Weaviate is being renamed to a 'collection'. &lt;br/&gt;&lt;br/&gt;See &lt;a href='https://weaviate.io/developers/weaviate/manage-data/collections'&gt;this page&lt;/a&gt; for client code examples.
        /// </summary>
        public SchemaClient Schema => new SchemaClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, update and delete objects and cross-references.
        /// </summary>
        public ObjectsClient Objects => new ObjectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, update and delete multiple objects and references at once. &lt;br/&gt;&lt;br/&gt;Note that object-level errors may be reported even in a successful batch request. Accordingly, we recommend you check the response body for errors.
        /// </summary>
        public BatchClient Batch => new BatchClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create, restore and check the status of backups. &lt;br/&gt;&lt;br/&gt;See the [backups page](https://weaviate.io/developers/weaviate/configuration/backups) for a general introduction, configuration, and tech background of backups.
        /// </summary>
        public BackupsClient Backups => new BackupsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Retrieve information about the server such as the hostname, location, versions and modules.
        /// </summary>
        public MetaClient Meta => new MetaClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Retrieve information about the cluster.
        /// </summary>
        public ClusterClient Cluster => new ClusterClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Retrieve information about relevant nodes in the cluster. The query can be for the entire cluster, or for a particular collection.
        /// </summary>
        public NodesClient Nodes => new NodesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// `.well-known` endpoints. If OpenID Connect (OIDC) authentication is enabled, this endpoint includes OIDC configuration details.
        /// </summary>
        public WellKnownClient WellKnown => new WellKnownClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Query data using the GraphQL query language. See the [Weaviate GraphQL documentation](https://weaviate.io/developers/weaviate/api/graphql) for query syntax details.
        /// </summary>
        public GraphqlClient Graphql => new GraphqlClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Perform classification operations
        /// </summary>
        public ClassificationsClient Classifications => new ClassificationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}