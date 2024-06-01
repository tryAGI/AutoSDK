//HintName: G.IssuesClient.IssuesCreate.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        /// <summary>
        /// Create an issue
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Issue> IssuesCreateAsync(
            string owner,
            string repo,
            IssuesCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/issues", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<Issue?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create an issue
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="title"></param>
        /// <param name="body"></param>
        /// <param name="assignee"></param>
        /// <param name="milestone"></param>
        /// <param name="labels"></param>
        /// <param name="assignees"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Issue> IssuesCreateAsync(
            string owner,
            string repo,
            global::System.OneOf<string, int> title,
            string? body = default,
            string? assignee = default,
            global::System.OneOf<string?, int>? milestone = default,
            global::System.Collections.Generic.IList<global::System.OneOf<string?, IssuesCreateRequestLabels?>>? labels = default,
            global::System.Collections.Generic.IList<string?>? assignees = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new IssuesCreateRequest
            {
                Title = title,
                Body = body,
                Assignee = assignee,
                Milestone = milestone,
                Labels = labels,
                Assignees = assignees,
            };

            return await IssuesCreateAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}