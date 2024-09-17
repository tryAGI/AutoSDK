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
            bool? upsert = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateTracerSessionArguments(
                httpClient: _httpClient,
                upsert: ref upsert,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/sessions?upsert={upsert}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateTracerSessionRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                upsert: upsert,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateTracerSessionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateTracerSessionResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.TracerSessionWithoutVirtualFields?>(__content, JsonSerializerOptions) ??
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
            bool? upsert = false,
            global::System.DateTime? startTime = default,
            global::G.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::G.AnyOf<global::G.TracerSessionCreateExtra, object>? extra = default,
            string? name = default,
            global::G.AnyOf<string, object>? description = default,
            global::G.AnyOf<global::System.Guid?, object>? defaultDatasetId = default,
            global::G.AnyOf<global::System.Guid?, object>? referenceDatasetId = default,
            global::G.AnyOf<global::G.TraceTier3?, object>? traceTier = default,
            global::G.AnyOf<global::System.Guid?, object>? id = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.TracerSessionCreate
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
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}