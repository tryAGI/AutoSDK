//HintName: G.IssuesClient.IssuesRemoveAssignees.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        partial void PrepareIssuesRemoveAssigneesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int issueNumber,
            global::G.IssuesRemoveAssigneesRequest request);
        partial void PrepareIssuesRemoveAssigneesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int issueNumber,
            global::G.IssuesRemoveAssigneesRequest request);
        partial void ProcessIssuesRemoveAssigneesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIssuesRemoveAssigneesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remove assignees from an issue<br/>
        /// Removes one or more assignees from an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Issue> IssuesRemoveAssigneesAsync(
            string owner,
            string repo,
            int issueNumber,
            global::G.IssuesRemoveAssigneesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareIssuesRemoveAssigneesArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                issueNumber: ref issueNumber,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/issues/{issueNumber}/assignees", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareIssuesRemoveAssigneesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessIssuesRemoveAssigneesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessIssuesRemoveAssigneesResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Issue?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Remove assignees from an issue<br/>
        /// Removes one or more assignees from an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="assignees">
        /// Usernames of assignees to remove from an issue. _NOTE: Only users with push access can remove assignees from an issue. Assignees are silently ignored otherwise._
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Issue> IssuesRemoveAssigneesAsync(
            string owner,
            string repo,
            int issueNumber,
            global::System.Collections.Generic.IList<string>? assignees = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.IssuesRemoveAssigneesRequest
            {
                Assignees = assignees,
            };

            return await IssuesRemoveAssigneesAsync(
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}