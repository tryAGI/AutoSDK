//HintName: G.IssuesClient.IssuesSetLabels.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        partial void PrepareIssuesSetLabelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int issueNumber,
            global::G.OneOf<global::G.IssuesSetLabelsRequestVariant1, global::System.Collections.Generic.IList<string>, global::G.IssuesSetLabelsRequestVariant3, global::System.Collections.Generic.IList<global::G.IssuesSetLabelsRequestVariant4Item>, string> request);
        partial void PrepareIssuesSetLabelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int issueNumber,
            global::G.OneOf<global::G.IssuesSetLabelsRequestVariant1, global::System.Collections.Generic.IList<string>, global::G.IssuesSetLabelsRequestVariant3, global::System.Collections.Generic.IList<global::G.IssuesSetLabelsRequestVariant4Item>, string> request);
        partial void ProcessIssuesSetLabelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIssuesSetLabelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Set labels for an issue<br/>
        /// Removes any previous labels and sets the new labels for an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Label>> IssuesSetLabelsAsync(
            string owner,
            string repo,
            int issueNumber,
            global::G.OneOf<global::G.IssuesSetLabelsRequestVariant1, global::System.Collections.Generic.IList<string>, global::G.IssuesSetLabelsRequestVariant3, global::System.Collections.Generic.IList<global::G.IssuesSetLabelsRequestVariant4Item>, string> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareIssuesSetLabelsArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                issueNumber: ref issueNumber,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/issues/{issueNumber}/labels",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareIssuesSetLabelsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessIssuesSetLabelsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessIssuesSetLabelsResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Label>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Set labels for an issue<br/>
        /// Removes any previous labels and sets the new labels for an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Label>> IssuesSetLabelsAsync(
            string owner,
            string repo,
            int issueNumber,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OneOf<global::G.IssuesSetLabelsRequestVariant1, global::System.Collections.Generic.IList<string>, global::G.IssuesSetLabelsRequestVariant3, global::System.Collections.Generic.IList<global::G.IssuesSetLabelsRequestVariant4Item>, string>
            {
            };

            return await IssuesSetLabelsAsync(
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}