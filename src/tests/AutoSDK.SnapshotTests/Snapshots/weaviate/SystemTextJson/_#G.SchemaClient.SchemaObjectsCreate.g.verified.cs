//HintName: G.SchemaClient.SchemaObjectsCreate.g.cs

#nullable enable

namespace G
{
    public partial class SchemaClient
    {
        partial void PrepareSchemaObjectsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.Class request);
        partial void PrepareSchemaObjectsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.Class request);
        partial void ProcessSchemaObjectsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSchemaObjectsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a collection.<br/>
        /// Create a new data object collection. &lt;br/&gt;&lt;br/&gt;If [AutoSchema](https://weaviate.io/developers/weaviate/config-refs/schema#auto-schema) is enabled, Weaviate will attempt to infer the schema from the data at import time. However, manual schema definition is recommended for production environments. &lt;br/&gt;&lt;br/&gt;For further discussions of parameters, please see the [schema reference page](https://weaviate.io/developers/weaviate/config-refs/schema).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Class> SchemaObjectsCreateAsync(
            global::G.Class request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareSchemaObjectsCreateArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/schema",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSchemaObjectsCreateRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSchemaObjectsCreateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSchemaObjectsCreateResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::G.Class.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a collection.<br/>
        /// Create a new data object collection. &lt;br/&gt;&lt;br/&gt;If [AutoSchema](https://weaviate.io/developers/weaviate/config-refs/schema#auto-schema) is enabled, Weaviate will attempt to infer the schema from the data at import time. However, manual schema definition is recommended for production environments. &lt;br/&gt;&lt;br/&gt;For further discussions of parameters, please see the [schema reference page](https://weaviate.io/developers/weaviate/config-refs/schema).
        /// </summary>
        /// <param name="class1">
        /// Name of the collection (a.k.a. class). Multiple words should be concatenated in CamelCase, e.g. `ArticleAuthor`.
        /// </param>
        /// <param name="vectorConfig">
        /// Configure named vectors (https://weaviate.io/developers/weaviate/config-refs/schema/multi-vector). Either use this field or `vectorizer`, `vectorIndexType`, and `vectorIndexConfig` fields. Available from `v1.24.0`.
        /// </param>
        /// <param name="vectorIndexType">
        /// Name of the vector index to use, eg. (HNSW)<br/>
        /// Default Value: hnsw
        /// </param>
        /// <param name="vectorIndexConfig">
        /// Vector index type specific settings. See the [vector index configuration page](https://weaviate.io/developers/weaviate/config-refs/schema/vector-index) for more details
        /// </param>
        /// <param name="shardingConfig">
        /// Specify how the index should be sharded and distributed in the cluster
        /// </param>
        /// <param name="replicationConfig">
        /// Configure how replication is executed in a cluster
        /// </param>
        /// <param name="invertedIndexConfig">
        /// Configure the inverted index built into Weaviate
        /// </param>
        /// <param name="multiTenancyConfig">
        /// Configuration related to multi-tenancy within a class
        /// </param>
        /// <param name="vectorizer">
        /// Vectorizer for this collection (e.g. `text2vec-transformers`). This will override any cluster-wide default set by an environment variable. &lt;br/&gt;&lt;br/&gt;If `none`, you must import a vector with each object yourself.
        /// </param>
        /// <param name="moduleConfig">
        /// Configuration specific to modules in a collection context.
        /// </param>
        /// <param name="description">
        /// Description of the collection for documentation purposes.
        /// </param>
        /// <param name="properties">
        /// Define properties of the collection.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Class> SchemaObjectsCreateAsync(
            string class1,
            global::G.ClassVectorConfig? vectorConfig = default,
            global::G.VectorIndexType? vectorIndexType = global::G.VectorIndexType.Hnsw,
            object? vectorIndexConfig = default,
            global::G.ShardingConfig? shardingConfig = default,
            global::G.ReplicationConfig? replicationConfig = default,
            global::G.InvertedIndexConfig? invertedIndexConfig = default,
            global::G.MultiTenancyConfig? multiTenancyConfig = default,
            global::G.Vectorizer? vectorizer = default,
            global::G.ClassModuleConfig? moduleConfig = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::G.Property>? properties = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.Class
            {
                Class1 = class1,
                VectorConfig = vectorConfig,
                VectorIndexType = vectorIndexType,
                VectorIndexConfig = vectorIndexConfig,
                ShardingConfig = shardingConfig,
                ReplicationConfig = replicationConfig,
                InvertedIndexConfig = invertedIndexConfig,
                MultiTenancyConfig = multiTenancyConfig,
                Vectorizer = vectorizer,
                ModuleConfig = moduleConfig,
                Description = description,
                Properties = properties,
            };

            return await SchemaObjectsCreateAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}