//HintName: G.UsersClient.UsersCheckBlocked.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        partial void PrepareUsersCheckBlockedArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string username);
        partial void PrepareUsersCheckBlockedRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string username);
        partial void ProcessUsersCheckBlockedResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Check if a user is blocked by the authenticated user<br/>
        /// Returns a 204 if the given user is blocked by the authenticated user. Returns a 404 if the given user is not blocked by the authenticated user, or if the given user account has been identified as spam by GitHub.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task UsersCheckBlockedAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUsersCheckBlockedArguments(
                httpClient: HttpClient,
                username: ref username);

            var __pathBuilder = new PathBuilder(
                path: $"/user/blocks/{username}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUsersCheckBlockedRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                username: username);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUsersCheckBlockedResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }
    }
}