//HintName: G.Api.EndPoints.ListFineTuningJobCheckpoints.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// List checkpoints for a fine-tuning job.
        /// </summary>
        /// <param name="fineTuningJobId"></param>
        /// <param name="after"></param>
        /// <param name="limit"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ListFineTuningJobCheckpointsResponse> ListFineTuningJobCheckpointsAsync(
            string fineTuningJobId,
            string after,
            int limit,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: $"/fine_tuning/jobs/{fineTuningJobId}/checkpoints?after={after}&limit={limit}");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ListFineTuningJobCheckpointsResponse>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}