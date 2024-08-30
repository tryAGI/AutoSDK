//HintName: G.OrgsClient.OrgsListPatGrantRequestRepositories.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsListPatGrantRequestRepositoriesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int patRequestId,
            ref int perPage,
            ref int page);
        partial void PrepareOrgsListPatGrantRequestRepositoriesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int patRequestId,
            int perPage,
            int page);
        partial void ProcessOrgsListPatGrantRequestRepositoriesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsListPatGrantRequestRepositoriesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repositories requested to be accessed by a fine-grained personal access token<br/>
        /// Lists the repositories a fine-grained personal access token request is requesting access to.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patRequestId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> OrgsListPatGrantRequestRepositoriesAsync(
            string org,
            int patRequestId,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareOrgsListPatGrantRequestRepositoriesArguments(
                httpClient: _httpClient,
                org: ref org,
                patRequestId: ref patRequestId,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/personal-access-token-requests/{patRequestId}/repositories?per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsListPatGrantRequestRepositoriesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                patRequestId: patRequestId,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsListPatGrantRequestRepositoriesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsListPatGrantRequestRepositoriesResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BasicError?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}