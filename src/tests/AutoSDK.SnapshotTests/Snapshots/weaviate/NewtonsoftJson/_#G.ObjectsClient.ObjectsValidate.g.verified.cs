//HintName: G.ObjectsClient.ObjectsValidate.g.cs

#nullable enable

namespace G
{
    public partial class ObjectsClient
    {
        partial void PrepareObjectsValidateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.Object request);
        partial void PrepareObjectsValidateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.Object request);
        partial void ProcessObjectsValidateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Validate an object.<br/>
        /// Validate an object's schema and meta-data without creating it. &lt;br/&gt;&lt;br/&gt;If the schema of the object is valid, the request should return nothing with a plain RESTful request. Otherwise, an error object will be returned.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ObjectsValidateAsync(
            global::G.Object request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareObjectsValidateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/objects/validate",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareObjectsValidateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessObjectsValidateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }

        /// <summary>
        /// Validate an object.<br/>
        /// Validate an object's schema and meta-data without creating it. &lt;br/&gt;&lt;br/&gt;If the schema of the object is valid, the request should return nothing with a plain RESTful request. Otherwise, an error object will be returned.
        /// </summary>
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
        public async global::System.Threading.Tasks.Task ObjectsValidateAsync(
            string? @class = default,
            object? vectorWeights = default,
            object? properties = default,
            global::System.Guid? id = default,
            long? creationTimeUnix = default,
            long? lastUpdateTimeUnix = default,
            global::System.Collections.Generic.IList<float>? vector = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<float>>? vectors = default,
            string? tenant = default,
            global::System.Collections.Generic.Dictionary<string, object>? additional = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.Object
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

            await ObjectsValidateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}