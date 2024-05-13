//HintName: G.Api.EndPoints.SubmitToolOuputsToRun.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// When a run has the `status: "requires_action"` and `required_action.type` is `submit_tool_outputs`, this endpoint can be used to submit the outputs from the tool calls once they're all completed. All outputs must be submitted in a single request.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RunObject> SubmitToolOuputsToRunAsync(
            SubmitToolOutputsRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/threads/{thread_id}/runs/{run_id}/submit_tool_outputs");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<RunObject>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// When a run has the `status: "requires_action"` and `required_action.type` is `submit_tool_outputs`, this endpoint can be used to submit the outputs from the tool calls once they're all completed. All outputs must be submitted in a single request.
        /// </summary>
        /// <param name="toolOutputs"></param>
        /// <param name="stream"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RunObject> SubmitToolOuputsToRunAsync(
            global::System.Collections.Generic.IList<SubmitToolOutputsRunRequestToolOutputs> toolOutputs,
            bool? stream,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new SubmitToolOutputsRunRequest
            {
                ToolOutputs = toolOutputs,
                Stream = stream,
            };

            return await SubmitToolOuputsToRunAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}