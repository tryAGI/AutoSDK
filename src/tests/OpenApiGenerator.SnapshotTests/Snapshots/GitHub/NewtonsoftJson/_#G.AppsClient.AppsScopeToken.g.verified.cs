//HintName: G.AppsClient.AppsScopeToken.g.cs

#nullable enable

namespace G
{
    public partial class AppsClient
    {
        /// <summary>
        /// Create a scoped access token
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Authorization> AppsScopeTokenAsync(
            string clientId,
            AppsScopeTokenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/applications/{clientId}/token/scoped", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<Authorization?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a scoped access token
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="accessToken"></param>
        /// <param name="target"></param>
        /// <param name="targetId"></param>
        /// <param name="repositories"></param>
        /// <param name="repositoryIds"></param>
        /// <param name="permissions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Authorization> AppsScopeTokenAsync(
            string clientId,
            string accessToken,
            string? target = default,
            int targetId = default,
            global::System.Collections.Generic.IList<string?>? repositories = default,
            global::System.Collections.Generic.IList<int>? repositoryIds = default,
            AppPermissions? permissions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new AppsScopeTokenRequest
            {
                AccessToken = accessToken,
                Target = target,
                TargetId = targetId,
                Repositories = repositories,
                RepositoryIds = repositoryIds,
                Permissions = permissions,
            };

            return await AppsScopeTokenAsync(
                clientId: clientId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}