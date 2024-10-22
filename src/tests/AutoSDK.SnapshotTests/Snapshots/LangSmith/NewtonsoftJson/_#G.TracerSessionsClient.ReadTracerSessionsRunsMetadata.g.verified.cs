//HintName: G.TracerSessionsClient.ReadTracerSessionsRunsMetadata.g.cs

#nullable enable

namespace G
{
    public partial class TracerSessionsClient
    {
        partial void PrepareReadTracerSessionsRunsMetadataArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid sessionId,
            global::System.Collections.Generic.IList<string>? metadataKeys,
            ref global::System.DateTime? startTime,
            ref int? k,
            ref bool? rootRunsOnly);
        partial void PrepareReadTracerSessionsRunsMetadataRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid sessionId,
            global::System.Collections.Generic.IList<string>? metadataKeys,
            global::System.DateTime? startTime,
            int? k,
            bool? rootRunsOnly);
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
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>> ReadTracerSessionsRunsMetadataAsync(
            global::System.Guid sessionId,
            global::System.Collections.Generic.IList<string>? metadataKeys = default,
            global::System.DateTime? startTime = default,
            int? k = 10,
            bool? rootRunsOnly = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReadTracerSessionsRunsMetadataArguments(
                httpClient: HttpClient,
                sessionId: ref sessionId,
                metadataKeys: metadataKeys,
                startTime: ref startTime,
                k: ref k,
                rootRunsOnly: ref rootRunsOnly);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/sessions/{sessionId}/metadata",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("metadata_keys", metadataKeys, delimiter: ",", explode: true) 
                .AddOptionalParameter("start_time", startTime?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("k", k?.ToString()) 
                .AddOptionalParameter("root_runs_only", rootRunsOnly?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReadTracerSessionsRunsMetadataRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                sessionId: sessionId,
                metadataKeys: metadataKeys,
                startTime: startTime,
                k: k,
                rootRunsOnly: rootRunsOnly);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReadTracerSessionsRunsMetadataResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReadTracerSessionsRunsMetadataResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}