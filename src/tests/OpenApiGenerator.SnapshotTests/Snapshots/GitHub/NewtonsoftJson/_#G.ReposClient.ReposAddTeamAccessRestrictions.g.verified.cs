//HintName: G.ReposClient.ReposAddTeamAccessRestrictions.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Add team access restrictions
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<Team>> ReposAddTeamAccessRestrictionsAsync(
            string owner,
            string repo,
            string branch,
            global::System.OneOf<ReposAddTeamAccessRestrictionsRequest, global::System.Collections.Generic.IList<string>> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/branches/{branch}/protection/restrictions/teams", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<Team>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add team access restrictions
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="teams"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<Team>> ReposAddTeamAccessRestrictionsAsync(
            string owner,
            string repo,
            string branch,
            global::System.Collections.Generic.IList<string> teams,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::System.OneOf<ReposAddTeamAccessRestrictionsRequest, global::System.Collections.Generic.IList<string>>
            {
                Teams = teams,
            };

            return await ReposAddTeamAccessRestrictionsAsync(
                owner: owner,
                repo: repo,
                branch: branch,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}