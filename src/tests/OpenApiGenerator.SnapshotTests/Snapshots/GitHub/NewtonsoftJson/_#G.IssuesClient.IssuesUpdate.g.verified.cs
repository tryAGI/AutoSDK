//HintName: G.IssuesClient.IssuesUpdate.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        /// <summary>
        /// Update an issue
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Issue> IssuesUpdateAsync(
            string owner,
            string repo,
            int issueNumber,
            IssuesUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/issues/{issueNumber}", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<Issue?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update an issue
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="title"></param>
        /// <param name="body"></param>
        /// <param name="assignee"></param>
        /// <param name="state"></param>
        /// <param name="stateReason"></param>
        /// <param name="milestone"></param>
        /// <param name="labels"></param>
        /// <param name="assignees"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Issue> IssuesUpdateAsync(
            string owner,
            string repo,
            int issueNumber,
            global::System.OneOf<string?, int>? title = default,
            string? body = default,
            string? assignee = default,
            IssuesUpdateRequestState? state = default,
            IssuesUpdateRequestStateReason? stateReason = default,
            global::System.OneOf<string?, int>? milestone = default,
            global::System.Collections.Generic.IList<global::System.OneOf<string?, IssuesUpdateRequestLabels?>>? labels = default,
            global::System.Collections.Generic.IList<string?>? assignees = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new IssuesUpdateRequest
            {
                Title = title,
                Body = body,
                Assignee = assignee,
                State = state,
                StateReason = stateReason,
                Milestone = milestone,
                Labels = labels,
                Assignees = assignees,
            };

            return await IssuesUpdateAsync(
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}