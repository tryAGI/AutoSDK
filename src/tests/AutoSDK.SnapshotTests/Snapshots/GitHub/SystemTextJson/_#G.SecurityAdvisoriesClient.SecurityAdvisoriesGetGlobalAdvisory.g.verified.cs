//HintName: G.SecurityAdvisoriesClient.SecurityAdvisoriesGetGlobalAdvisory.g.cs

#nullable enable

namespace G
{
    public partial class SecurityAdvisoriesClient
    {
        partial void PrepareSecurityAdvisoriesGetGlobalAdvisoryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string ghsaId);
        partial void PrepareSecurityAdvisoriesGetGlobalAdvisoryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string ghsaId);
        partial void ProcessSecurityAdvisoriesGetGlobalAdvisoryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecurityAdvisoriesGetGlobalAdvisoryResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get a global security advisory<br/>
        /// Gets a global security advisory using its GitHub Security Advisory (GHSA) identifier.
        /// </summary>
        /// <param name="ghsaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GlobalAdvisory> SecurityAdvisoriesGetGlobalAdvisoryAsync(
            string ghsaId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareSecurityAdvisoriesGetGlobalAdvisoryArguments(
                httpClient: HttpClient,
                ghsaId: ref ghsaId);

            var __pathBuilder = new PathBuilder(
                path: $"/advisories/{ghsaId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSecurityAdvisoriesGetGlobalAdvisoryRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                ghsaId: ghsaId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSecurityAdvisoriesGetGlobalAdvisoryResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessSecurityAdvisoriesGetGlobalAdvisoryResponseContent(
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
                global::G.GlobalAdvisory.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}