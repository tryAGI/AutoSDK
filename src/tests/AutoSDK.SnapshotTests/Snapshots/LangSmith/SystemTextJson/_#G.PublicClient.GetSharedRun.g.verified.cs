//HintName: G.PublicClient.GetSharedRun.g.cs

#nullable enable

namespace G
{
    public partial class PublicClient
    {
        partial void PrepareGetSharedRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid shareToken,
            ref bool? excludeS3StoredAttributes);
        partial void PrepareGetSharedRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid shareToken,
            bool? excludeS3StoredAttributes);
        partial void ProcessGetSharedRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSharedRunResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Shared Run<br/>
        /// Get the shared run.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="excludeS3StoredAttributes">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunPublicSchema> GetSharedRunAsync(
            global::System.Guid shareToken,
            bool? excludeS3StoredAttributes = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetSharedRunArguments(
                httpClient: HttpClient,
                shareToken: ref shareToken,
                excludeS3StoredAttributes: ref excludeS3StoredAttributes);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/public/{shareToken}/run",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("exclude_s3_stored_attributes", excludeS3StoredAttributes?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetSharedRunRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                shareToken: shareToken,
                excludeS3StoredAttributes: excludeS3StoredAttributes);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetSharedRunResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetSharedRunResponseContent(
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
                global::G.RunPublicSchema.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}