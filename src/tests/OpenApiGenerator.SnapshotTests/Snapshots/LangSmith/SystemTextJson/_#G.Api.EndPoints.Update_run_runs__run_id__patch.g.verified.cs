//HintName: G.Api.EndPoints.Update_run_runs__run_id__patch.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Update Run
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task Update_run_runs__run_id__patchAsync(
            string runId,
            RunUpdateSchemaExtended request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: $"/runs/{runId}");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Update Run
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="events"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task Update_run_runs__run_id__patchAsync(
            string runId,
            global::System.DateTime endTime = default,
            string? error = default,
            object? inputs = default,
            object? outputs = default,
            global::System.Collections.Generic.IList<RunUpdateSchemaExtendedEvents?>? events = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new RunUpdateSchemaExtended
            {
                EndTime = endTime,
                Error = error,
                Inputs = inputs,
                Outputs = outputs,
                Events = events,
            };

            await Update_run_runs__run_id__patchAsync(
                runId: runId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}