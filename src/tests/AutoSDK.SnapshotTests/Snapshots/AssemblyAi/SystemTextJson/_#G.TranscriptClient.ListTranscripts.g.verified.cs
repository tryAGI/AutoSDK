//HintName: G.TranscriptClient.ListTranscripts.g.cs

#nullable enable

namespace G
{
    public partial class TranscriptClient
    {
        partial void PrepareListTranscriptsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref long? limit,
            ref global::G.TranscriptStatus? status,
            ref global::System.DateTime? createdOn,
            ref global::System.Guid? beforeId,
            ref global::System.Guid? afterId,
            ref bool? throttledOnly);
        partial void PrepareListTranscriptsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            long? limit,
            global::G.TranscriptStatus? status,
            global::System.DateTime? createdOn,
            global::System.Guid? beforeId,
            global::System.Guid? afterId,
            bool? throttledOnly);
        partial void ProcessListTranscriptsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListTranscriptsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List transcripts<br/>
        /// Retrieve a list of transcripts you created.<br/>
        /// Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="status">
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </param>
        /// <param name="createdOn"></param>
        /// <param name="beforeId"></param>
        /// <param name="afterId"></param>
        /// <param name="throttledOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TranscriptList> ListTranscriptsAsync(
            long? limit = default,
            global::G.TranscriptStatus? status = default,
            global::System.DateTime? createdOn = default,
            global::System.Guid? beforeId = default,
            global::System.Guid? afterId = default,
            bool? throttledOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListTranscriptsArguments(
                httpClient: _httpClient,
                limit: ref limit,
                status: ref status,
                createdOn: ref createdOn,
                beforeId: ref beforeId,
                afterId: ref afterId,
                throttledOnly: ref throttledOnly);

            var __pathBuilder = new PathBuilder(
                path: "/v2/transcript",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("status", status?.ToValueString()) 
                .AddOptionalParameter("created_on", createdOn?.ToString("yyyy-MM-dd")) 
                .AddOptionalParameter("before_id", beforeId?.ToString()) 
                .AddOptionalParameter("after_id", afterId?.ToString()) 
                .AddOptionalParameter("throttled_only", throttledOnly?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListTranscriptsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                limit: limit,
                status: status,
                createdOn: createdOn,
                beforeId: beforeId,
                afterId: afterId,
                throttledOnly: throttledOnly);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListTranscriptsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListTranscriptsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.TranscriptList?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}