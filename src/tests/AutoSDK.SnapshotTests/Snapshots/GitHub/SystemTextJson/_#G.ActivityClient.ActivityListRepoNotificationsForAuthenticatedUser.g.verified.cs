//HintName: G.ActivityClient.ActivityListRepoNotificationsForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class ActivityClient
    {
        partial void PrepareActivityListRepoNotificationsForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref bool all,
            ref bool participating,
            ref global::System.DateTime since,
            ref global::System.DateTime before,
            ref int perPage,
            ref int page);
        partial void PrepareActivityListRepoNotificationsForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            bool all,
            bool participating,
            global::System.DateTime since,
            global::System.DateTime before,
            int perPage,
            int page);
        partial void ProcessActivityListRepoNotificationsForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActivityListRepoNotificationsForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repository notifications for the authenticated user<br/>
        /// Lists all notifications for the current user in the specified repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="all">
        /// Default Value: false
        /// </param>
        /// <param name="participating">
        /// Default Value: false
        /// </param>
        /// <param name="since"></param>
        /// <param name="before"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Thread>> ActivityListRepoNotificationsForAuthenticatedUserAsync(
            string owner,
            string repo,
            bool all = false,
            bool participating = false,
            global::System.DateTime since = default,
            global::System.DateTime before = default,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareActivityListRepoNotificationsForAuthenticatedUserArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                all: ref all,
                participating: ref participating,
                since: ref since,
                before: ref before,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/notifications?all={all}&participating={participating}&since={since:yyyy-MM-ddTHH:mm:ssZ}&before={before:yyyy-MM-ddTHH:mm:ssZ}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActivityListRepoNotificationsForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                all: all,
                participating: participating,
                since: since,
                before: before,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActivityListRepoNotificationsForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActivityListRepoNotificationsForAuthenticatedUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Thread>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}