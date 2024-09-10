//HintName: G.ActionsClient.ActionsCreateWorkflowDispatch.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsCreateWorkflowDispatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref global::G.OneOf<int?, string> workflowId,
            global::G.ActionsCreateWorkflowDispatchRequest request);
        partial void PrepareActionsCreateWorkflowDispatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.OneOf<int?, string> workflowId,
            global::G.ActionsCreateWorkflowDispatchRequest request);
        partial void ProcessActionsCreateWorkflowDispatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create a workflow dispatch event<br/>
        /// You can use this endpoint to manually trigger a GitHub Actions workflow run. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`.<br/>
        /// You must configure your GitHub Actions workflow to run when the [`workflow_dispatch` webhook](/developers/webhooks-and-events/webhook-events-and-payloads#workflow_dispatch) event occurs. The `inputs` are configured in the workflow file. For more information about how to configure the `workflow_dispatch` event in the workflow file, see "[Events that trigger workflows](/actions/reference/events-that-trigger-workflows#workflow_dispatch)."<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
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
            global::G.OneOf<int?, string> workflowId,
            global::G.ActionsCreateWorkflowDispatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActionsCreateWorkflowDispatchArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                workflowId: ref workflowId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/actions/workflows/{workflowId}/dispatches", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsCreateWorkflowDispatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                workflowId: workflowId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsCreateWorkflowDispatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Create a workflow dispatch event<br/>
        /// You can use this endpoint to manually trigger a GitHub Actions workflow run. You can replace `workflow_id` with the workflow file name. For example, you could use `main.yaml`.<br/>
        /// You must configure your GitHub Actions workflow to run when the [`workflow_dispatch` webhook](/developers/webhooks-and-events/webhook-events-and-payloads#workflow_dispatch) event occurs. The `inputs` are configured in the workflow file. For more information about how to configure the `workflow_dispatch` event in the workflow file, see "[Events that trigger workflows](/actions/reference/events-that-trigger-workflows#workflow_dispatch)."<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="workflowId"></param>
        /// <param name="ref">
        /// The git reference for the workflow. The reference can be a branch or tag name.
        /// </param>
        /// <param name="inputs">
        /// Input keys and values configured in the workflow file. The maximum number of properties is 10. Any default properties configured in the workflow file will be used when `inputs` are omitted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsCreateWorkflowDispatchAsync(
            string owner,
            string repo,
            global::G.OneOf<int?, string> workflowId,
            string @ref,
            global::G.ActionsCreateWorkflowDispatchRequestInputs? inputs = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ActionsCreateWorkflowDispatchRequest
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