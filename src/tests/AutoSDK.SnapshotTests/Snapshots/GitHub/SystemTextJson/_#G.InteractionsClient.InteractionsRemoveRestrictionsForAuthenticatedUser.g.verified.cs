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
                client: HttpClient);
            PrepareInteractionsRemoveRestrictionsForAuthenticatedUserArguments(
                httpClient: HttpClient);

            var __pathBuilder = new PathBuilder(
                path: "/user/interaction-limits",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareInteractionsRemoveRestrictionsForAuthenticatedUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessInteractionsRemoveRestrictionsForAuthenticatedUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}