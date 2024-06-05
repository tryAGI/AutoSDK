//HintName: G.FineTuningClient.CancelFineTuningJob.g.cs

#nullable enable

namespace G
{
    public partial class FineTuningClient
    {
        /// <summary>
        /// Immediately cancel a fine-tune job.
        /// </summary>
        /// <param name="fineTuningJobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<FineTuningJob> CancelFineTuningJobAsync(
            string fineTuningJobId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/fine_tuning/jobs/{fineTuningJobId}/cancel", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<FineTuningJob?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}