//HintName: G.ActionsClient.ActionsDeleteEnvironmentSecret.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsDeleteEnvironmentSecretArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string environmentName,
            ref string secretName);
        partial void PrepareActionsDeleteEnvironmentSecretRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string environmentName,
            string secretName);
        partial void ProcessActionsDeleteEnvironmentSecretResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete an environment secret<br/>
        /// Deletes a secret in an environment using the secret name.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read secrets.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="environmentName"></param>
        /// <param name="secretName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ActionsDeleteEnvironmentSecretAsync(
            string owner,
            string repo,
            string environmentName,
            string secretName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareActionsDeleteEnvironmentSecretArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                environmentName: ref environmentName,
                secretName: ref secretName);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/environments/{environmentName}/secrets/{secretName}",
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
            PrepareActionsDeleteEnvironmentSecretRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                secretName: secretName);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsDeleteEnvironmentSecretResponse(
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