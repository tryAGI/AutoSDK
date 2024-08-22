//HintName: G.TracerSessionsClient.ReadTracerSessionsRunsMetadata.g.cs

#nullable enable

namespace G
{
    public partial class TracerSessionsClient
    {
        partial void PrepareReadTracerSessionsRunsMetadataArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string sessionId,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? metadataKeys,
            ref global::System.AnyOf<global::System.DateTime?, object>? startTime,
            ref int k,
            ref bool rootRunsOnly);
        partial void PrepareReadTracerSessionsRunsMetadataRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string sessionId,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? metadataKeys,
            global::System.AnyOf<global::System.DateTime?, object>? startTime,
            int k,
            bool rootRunsOnly);
        partial void ProcessReadTracerSessionsRunsMetadataResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadTracerSessionsRunsMetadataResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Tracer Sessions Runs Metadata<br/>
        /// Given a session, a number K, and (optionally) a list of metadata keys, return the top K values for each key.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="metadataKeys"></param>
        /// <param name="startTime"></param>
        /// <param name="k">
        /// Default Value: 10
        /// </param>
        /// <param name="rootRunsOnly">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RootModelDictStrListStr> ReadTracerSessionsRunsMetadataAsync(
            string sessionId,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? metadataKeys,
            global::System.AnyOf<global::System.DateTime?, object>? startTime,
            int k,
            bool rootRunsOnly,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadTracerSessionsRunsMetadataArguments(
                httpClient: _httpClient,
                sessionId: ref sessionId,
                metadataKeys: ref metadataKeys,
                startTime: ref startTime,
                k: ref k,
                rootRunsOnly: ref rootRunsOnly);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/sessions/{sessionId}/metadata?metadata_keys={metadataKeys}&start_time={startTime}&k={k}&root_runs_only={rootRunsOnly}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadTracerSessionsRunsMetadataRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                sessionId: sessionId,
                metadataKeys: metadataKeys,
                startTime: startTime,
                k: k,
                rootRunsOnly: rootRunsOnly);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadTracerSessionsRunsMetadataResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadTracerSessionsRunsMetadataResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RootModelDictStrListStr?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}