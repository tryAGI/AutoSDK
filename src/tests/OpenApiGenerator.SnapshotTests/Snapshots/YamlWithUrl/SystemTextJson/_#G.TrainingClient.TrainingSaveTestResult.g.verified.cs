//HintName: G.TrainingClient.TrainingSaveTestResult.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class TrainingClient
    {
        /// <summary>
        /// SaveTestResult.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="traineeUserId"></param>
        /// <param name="testId"></param>
        /// <param name="overallRating"></param>
        /// <param name="traineeTagApps"></param>
        /// <param name="completed"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<TrainingTestResult> TrainingSaveTestResultAsync(
            string token,
            string projectId,
            string traineeUserId,
            string testId,
            double overallRating,
            global::System.Collections.Generic.IList<TrainingTestTagApp> traineeTagApps,
            bool completed,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/training/savetestresult?projectId={projectId}&traineeUserId={traineeUserId}&testId={testId}&overallRating={overallRating}&{string.Join("&", traineeTagApps.Select(static x => $"traineeTagApps={x}"))}&completed={completed}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<TrainingTestResult>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}