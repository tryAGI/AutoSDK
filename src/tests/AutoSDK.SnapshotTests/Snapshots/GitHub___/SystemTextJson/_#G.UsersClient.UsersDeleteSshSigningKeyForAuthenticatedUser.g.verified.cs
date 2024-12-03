//HintName: G.UsersClient.UsersDeleteSshSigningKeyForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        partial void PrepareUsersDeleteSshSigningKeyForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int sshSigningKeyId);
        partial void PrepareUsersDeleteSshSigningKeyForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int sshSigningKeyId);
        partial void ProcessUsersDeleteSshSigningKeyForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete an SSH signing key for the authenticated user<br/>
        /// Deletes an SSH signing key from the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:ssh_signing_key` scope to use this endpoint.
        /// </summary>
        /// <param name="sshSigningKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task UsersDeleteSshSigningKeyForAuthenticatedUserAsync(
            int sshSigningKeyId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUsersDeleteSshSigningKeyForAuthenticatedUserArguments(
                httpClient: HttpClient,
                sshSigningKeyId: ref sshSigningKeyId);

            var __pathBuilder = new PathBuilder(
                path: $"/user/ssh_signing_keys/{sshSigningKeyId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUsersDeleteSshSigningKeyForAuthenticatedUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                sshSigningKeyId: sshSigningKeyId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUsersDeleteSshSigningKeyForAuthenticatedUserResponse(
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