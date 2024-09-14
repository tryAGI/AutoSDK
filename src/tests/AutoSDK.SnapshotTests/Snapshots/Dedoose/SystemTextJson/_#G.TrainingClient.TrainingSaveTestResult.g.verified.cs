//HintName: G.TrainingClient.TrainingSaveTestResult.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class TrainingClient
    {
        partial void PrepareTrainingSaveTestResultArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid projectId,
            ref global::System.Guid traineeUserId,
            ref global::System.Guid testId,
            ref double overallRating,
            global::System.Collections.Generic.IList<global::G.TrainingTestTagApp>? traineeTagApps,
            ref bool completed);
        partial void PrepareTrainingSaveTestResultRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid projectId,
            global::System.Guid traineeUserId,
            global::System.Guid testId,
            double overallRating,
            global::System.Collections.Generic.IList<global::G.TrainingTestTagApp>? traineeTagApps,
            bool completed);
        partial void ProcessTrainingSaveTestResultResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTrainingSaveTestResultResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::G.TrainingTestResult> TrainingSaveTestResultAsync(
            string? token = default,
            global::System.Guid projectId = default,
            global::System.Guid traineeUserId = default,
            global::System.Guid testId = default,
            double overallRating = default,
            global::System.Collections.Generic.IList<global::G.TrainingTestTagApp>? traineeTagApps = default,
            bool completed = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTrainingSaveTestResultArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                traineeUserId: ref traineeUserId,
                testId: ref testId,
                overallRating: ref overallRating,
                traineeTagApps: traineeTagApps,
                completed: ref completed);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/training/savetestresult?projectId={projectId}&traineeUserId={traineeUserId}&testId={testId}&overallRating={overallRating}&{string.Join("&", traineeTagApps?.Select(static x => $"traineeTagApps={x}") ?? global::System.Array.Empty<string>())}&completed={completed}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTrainingSaveTestResultRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                traineeUserId: traineeUserId,
                testId: testId,
                overallRating: overallRating,
                traineeTagApps: traineeTagApps,
                completed: completed);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTrainingSaveTestResultResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTrainingSaveTestResultResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.TrainingTestResult?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}