//HintName: G.TracerSessionsClient.CreateTracerSession.g.cs

#nullable enable

namespace G
{
    public partial class TracerSessionsClient
    {
        partial void PrepareCreateTracerSessionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? upsert,
            global::G.TracerSessionCreate request);
        partial void PrepareCreateTracerSessionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? upsert,
            global::G.TracerSessionCreate request);
        partial void ProcessCreateTracerSessionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTracerSessionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="upsert">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TracerSessionWithoutVirtualFields> CreateTracerSessionAsync(
            global::G.TracerSessionCreate request,
            bool? upsert = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTracerSessionArguments(
                httpClient: HttpClient,
                upsert: ref upsert,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/sessions",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("upsert", upsert?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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
            PrepareCreateTracerSessionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                upsert: upsert,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateTracerSessionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCreateTracerSessionResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.TracerSessionWithoutVirtualFields.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="upsert">
        /// Default Value: false
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="traceTier"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TracerSessionWithoutVirtualFields> CreateTracerSessionAsync(
            bool? upsert = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            object? extra = default,
            string? name = default,
            string? description = default,
            global::System.Guid? defaultDatasetId = default,
            global::System.Guid? referenceDatasetId = default,
            global::G.TraceTier? traceTier = default,
            global::System.Guid? id = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.TracerSessionCreate
            {
                StartTime = startTime,
                EndTime = endTime,
                Extra = extra,
                Name = name,
                Description = description,
                DefaultDatasetId = defaultDatasetId,
                ReferenceDatasetId = referenceDatasetId,
                TraceTier = traceTier,
                Id = id,
            };

            return await CreateTracerSessionAsync(
                upsert: upsert,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}