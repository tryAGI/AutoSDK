//HintName: G.SchemaClient.SchemaObjectsUpdate.g.cs

#nullable enable

namespace G
{
    public partial class SchemaClient
    {
        partial void PrepareSchemaObjectsUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string className,
            global::G.Class request);
        partial void PrepareSchemaObjectsUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string className,
            global::G.Class request);
        partial void ProcessSchemaObjectsUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSchemaObjectsUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update an existing collection.<br/>
        /// Alter an existing collection definition. &lt;br/&gt;&lt;br/&gt;Note that not all settings are mutable ([see this list](https://weaviate.io/developers/weaviate/config-refs/schema#mutability)). To update any other (i.e. immutable) setting, you need to delete the collection, re-create it with the correct setting and then re-import the data. &lt;br/&gt;&lt;br/&gt;This endpoint cannot be used to modify properties. Instead use POST /v1/schema/{className}/properties. A typical use case for this endpoint is to update a index configuration, such as `vectorIndexConfig/dynamicEfFactor`. &lt;br/&gt;&lt;br/&gt;You should attach a body to this PUT request with the entire new configuration of the collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Class> SchemaObjectsUpdateAsync(
            string className,
            global::G.Class request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareSchemaObjectsUpdateArguments(
                httpClient: _httpClient,
                className: ref className,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/schema/{className}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareSchemaObjectsUpdateRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                className: className,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSchemaObjectsUpdateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSchemaObjectsUpdateResponseContent(
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
        /// Update an existing collection.<br/>
        /// Alter an existing collection definition. &lt;br/&gt;&lt;br/&gt;Note that not all settings are mutable ([see this list](https://weaviate.io/developers/weaviate/config-refs/schema#mutability)). To update any other (i.e. immutable) setting, you need to delete the collection, re-create it with the correct setting and then re-import the data. &lt;br/&gt;&lt;br/&gt;This endpoint cannot be used to modify properties. Instead use POST /v1/schema/{className}/properties. A typical use case for this endpoint is to update a index configuration, such as `vectorIndexConfig/dynamicEfFactor`. &lt;br/&gt;&lt;br/&gt;You should attach a body to this PUT request with the entire new configuration of the collection.
        /// </summary>
        /// <param name="className"></param>
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
        public async global::System.Threading.Tasks.Task<global::G.Class> SchemaObjectsUpdateAsync(
            string className,
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

            return await SchemaObjectsUpdateAsync(
                className: className,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}