//HintName: G.ActionsClient.ActionsCreateWorkflowDispatch.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// Create a workflow dispatch event
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsCreateWorkflowDispatchAsync(
            string owner,
            string repo,
            global::System.OneOf<int, string> workflowId,
            ActionsCreateWorkflowDispatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/actions/workflows/{workflowId}/dispatches", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Create a workflow dispatch event
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="workflowId"></param>
        /// <param name="@ref"></param>
        /// <param name="inputs"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsCreateWorkflowDispatchAsync(
            string owner,
            string repo,
            global::System.OneOf<int, string> workflowId,
            string @ref,
            object? inputs = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ActionsCreateWorkflowDispatchRequest
            {
                Ref = @ref,
                Inputs = inputs,
            };

            await ActionsCreateWorkflowDispatchAsync(
                owner: owner,
                repo: repo,
                workflowId: workflowId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}