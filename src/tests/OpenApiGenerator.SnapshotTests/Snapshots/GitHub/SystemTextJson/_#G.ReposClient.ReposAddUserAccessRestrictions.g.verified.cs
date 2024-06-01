//HintName: G.ReposClient.ReposAddUserAccessRestrictions.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Add user access restrictions
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<SimpleUser>> ReposAddUserAccessRestrictionsAsync(
            string owner,
            string repo,
            string branch,
            global::System.OneOf<ReposAddUserAccessRestrictionsRequest, global::System.Collections.Generic.IList<string>> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/users", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<SimpleUser>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add user access restrictions
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="users"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<SimpleUser>> ReposAddUserAccessRestrictionsAsync(
            string owner,
            string repo,
            string branch,
            global::System.Collections.Generic.IList<string> users,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::System.OneOf<ReposAddUserAccessRestrictionsRequest, global::System.Collections.Generic.IList<string>>
            {
                Users = users,
            };

            return await ReposAddUserAccessRestrictionsAsync(
                owner: owner,
                repo: repo,
                branch: branch,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}