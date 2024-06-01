//HintName: G.IssuesClient.IssuesUpdateMilestone.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        /// <summary>
        /// Update a milestone
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="milestoneNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Milestone> IssuesUpdateMilestoneAsync(
            string owner,
            string repo,
            int milestoneNumber,
            IssuesUpdateMilestoneRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/milestones/{milestoneNumber}", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<Milestone?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a milestone
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="milestoneNumber"></param>
        /// <param name="title"></param>
        /// <param name="state"></param>
        /// <param name="description"></param>
        /// <param name="dueOn"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Milestone> IssuesUpdateMilestoneAsync(
            string owner,
            string repo,
            int milestoneNumber,
            string? title = default,
            IssuesUpdateMilestoneRequestState? state = IssuesUpdateMilestoneRequestState.Open,
            string? description = default,
            global::System.DateTime dueOn = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new IssuesUpdateMilestoneRequest
            {
                Title = title,
                State = state,
                Description = description,
                DueOn = dueOn,
            };

            return await IssuesUpdateMilestoneAsync(
                owner: owner,
                repo: repo,
                milestoneNumber: milestoneNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}