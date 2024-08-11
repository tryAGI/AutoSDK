//HintName: G.IssuesClient.IssuesAddAssignees.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        partial void PrepareIssuesAddAssigneesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int issueNumber,
            global::G.IssuesAddAssigneesRequest request);
        partial void PrepareIssuesAddAssigneesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int issueNumber,
            global::G.IssuesAddAssigneesRequest request);
        partial void ProcessIssuesAddAssigneesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIssuesAddAssigneesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add assignees to an issue<br/>
        /// Adds up to 10 assignees to an issue. Users already assigned to an issue are not replaced.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Issue> IssuesAddAssigneesAsync(
            string owner,
            string repo,
            int issueNumber,
            global::G.IssuesAddAssigneesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareIssuesAddAssigneesArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                issueNumber: ref issueNumber,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/issues/{issueNumber}/assignees", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareIssuesAddAssigneesRequest(
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
            ProcessIssuesAddAssigneesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessIssuesAddAssigneesResponseContent(
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
        /// Add assignees to an issue<br/>
        /// Adds up to 10 assignees to an issue. Users already assigned to an issue are not replaced.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="assignees">
        /// Usernames of people to assign this issue to. _NOTE: Only users with push access can add assignees to an issue. Assignees are silently ignored otherwise._
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Issue> IssuesAddAssigneesAsync(
            string owner,
            string repo,
            int issueNumber,
            global::System.Collections.Generic.IList<string>? assignees = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.IssuesAddAssigneesRequest
            {
                Assignees = assignees,
            };

            return await IssuesAddAssigneesAsync(
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}