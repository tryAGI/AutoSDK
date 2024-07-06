//HintName: G.TrainingClient.TrainingUpdateTestResult.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class TrainingClient
    {
        /// <summary>
        /// UpdateTestResult.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="traineeUserId"></param>
        /// <param name="testId"></param>
        /// <param name="resultId"></param>
        /// <param name="overallRating"></param>
        /// <param name="traineeTagApps"></param>
        /// <param name="completed"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TrainingTestResult> TrainingUpdateTestResultAsync(
            string token,
            string projectId,
            string traineeUserId,
            string testId,
            string resultId,
            double overallRating,
            global::System.Collections.Generic.IList<global::G.TrainingTestTagApp> traineeTagApps,
            bool completed,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/training/updatetestresult?projectId={projectId}&traineeUserId={traineeUserId}&testId={testId}&resultId={resultId}&overallRating={overallRating}&{string.Join("&", traineeTagApps.Select(static x => $"traineeTagApps={x}"))}&completed={completed}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.TrainingTestResult?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}