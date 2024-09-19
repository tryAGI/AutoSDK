//HintName: G.InteractionsClient.InteractionsRemoveRestrictionsForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class InteractionsClient
    {
        partial void PrepareInteractionsRemoveRestrictionsForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient);
        partial void PrepareInteractionsRemoveRestrictionsForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage);
        partial void ProcessInteractionsRemoveRestrictionsForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Remove interaction restrictions from your public repositories<br/>
        /// Removes any interaction restrictions from your public repositories.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task InteractionsRemoveRestrictionsForAuthenticatedUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareInteractionsRemoveRestrictionsForAuthenticatedUserArguments(
                httpClient: _httpClient);

            var __pathBuilder = new PathBuilder(
                path: "/user/interaction-limits",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareInteractionsRemoveRestrictionsForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessInteractionsRemoveRestrictionsForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}