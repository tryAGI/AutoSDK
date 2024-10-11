//HintName: G.ObjectsClient.ObjectsCreate.g.cs

#nullable enable

namespace G
{
    public partial class ObjectsClient
    {
        partial void PrepareObjectsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.ObjectsCreateConsistencyLevel? consistencyLevel,
            global::G.Object request);
        partial void PrepareObjectsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ObjectsCreateConsistencyLevel? consistencyLevel,
            global::G.Object request);
        partial void ProcessObjectsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessObjectsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a new object.<br/>
        /// Create a new object. &lt;br/&gt;&lt;br/&gt;Meta-data and schema values are validated. &lt;br/&gt;&lt;br/&gt;**Note: Use `/batch` for importing many objects**: &lt;br/&gt;If you plan on importing a large number of objects, it's much more efficient to use the `/batch` endpoint. Otherwise, sending multiple single requests sequentially would incur a large performance penalty. &lt;br/&gt;&lt;br/&gt;**Note: idempotence of `/objects`**: &lt;br/&gt;POST /objects will fail if an id is provided which already exists in the class. To update an existing object with the objects endpoint, use the PUT or PATCH method.
        /// </summary>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Object> ObjectsCreateAsync(
            global::G.Object request,
            global::G.ObjectsCreateConsistencyLevel? consistencyLevel = global::G.ObjectsCreateConsistencyLevel.QUORUM,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareObjectsCreateArguments(
                httpClient: _httpClient,
                consistencyLevel: ref consistencyLevel,
                request: request);

            var consistencyLevelValue = consistencyLevel switch
            {
                global::G.ObjectsCreateConsistencyLevel.ONE => "ONE",
                global::G.ObjectsCreateConsistencyLevel.QUORUM => "QUORUM",
                global::G.ObjectsCreateConsistencyLevel.ALL => "ALL",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/objects",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("consistency_level", consistencyLevelValue?.ToString()) 
                ; 
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
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareObjectsCreateRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                consistencyLevel: consistencyLevel,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessObjectsCreateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessObjectsCreateResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Object?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a new object.<br/>
        /// Create a new object. &lt;br/&gt;&lt;br/&gt;Meta-data and schema values are validated. &lt;br/&gt;&lt;br/&gt;**Note: Use `/batch` for importing many objects**: &lt;br/&gt;If you plan on importing a large number of objects, it's much more efficient to use the `/batch` endpoint. Otherwise, sending multiple single requests sequentially would incur a large performance penalty. &lt;br/&gt;&lt;br/&gt;**Note: idempotence of `/objects`**: &lt;br/&gt;POST /objects will fail if an id is provided which already exists in the class. To update an existing object with the objects endpoint, use the PUT or PATCH method.
        /// </summary>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="class">
        /// The object collection name.
        /// </param>
        /// <param name="vectorWeights">
        /// Allow custom overrides of vector weights as math expressions in word-based vectorization models. E.g. "pancake": "7" will set the weight for the word pancake to 7 in the vectorization, whereas "w * 3" would triple the originally calculated word.
        /// </param>
        /// <param name="properties">
        /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
        /// </param>
        /// <param name="id">
        /// ID of the object.
        /// </param>
        /// <param name="creationTimeUnix">
        /// (Response only) Timestamp of creation of this object in milliseconds since epoch UTC.
        /// </param>
        /// <param name="lastUpdateTimeUnix">
        /// (Response only) Timestamp of the last object update in milliseconds since epoch UTC.
        /// </param>
        /// <param name="vector">
        /// A vector representation of the object. If provided at object creation, this wil take precedence over any vectorizer setting.
        /// </param>
        /// <param name="vectors">
        /// A map of named vectors for multi-vector representations.
        /// </param>
        /// <param name="tenant">
        /// Name of the tenant.
        /// </param>
        /// <param name="additional">
        /// (Response only) Additional meta information about a single object.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Object> ObjectsCreateAsync(
            global::G.ObjectsCreateConsistencyLevel? consistencyLevel = global::G.ObjectsCreateConsistencyLevel.QUORUM,
            string? @class = default,
            object? vectorWeights = default,
            object? properties = default,
            global::System.Guid? id = default,
            long? creationTimeUnix = default,
            long? lastUpdateTimeUnix = default,
            global::System.Collections.Generic.IList<float>? vector = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<float>>? vectors = default,
            string? tenant = default,
            global::System.Collections.Generic.Dictionary<string, global::G.AdditionalProperties2>? additional = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.Object
            {
                Class = @class,
                VectorWeights = vectorWeights,
                Properties = properties,
                Id = id,
                CreationTimeUnix = creationTimeUnix,
                LastUpdateTimeUnix = lastUpdateTimeUnix,
                Vector = vector,
                Vectors = vectors,
                Tenant = tenant,
                Additional = additional,
            };

            return await ObjectsCreateAsync(
                consistencyLevel: consistencyLevel,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}