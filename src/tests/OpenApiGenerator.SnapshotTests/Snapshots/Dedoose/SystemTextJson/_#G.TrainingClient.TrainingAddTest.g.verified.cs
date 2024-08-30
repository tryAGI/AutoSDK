//HintName: G.TrainingClient.TrainingAddTest.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class TrainingClient
    {
        partial void PrepareTrainingAddTestArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectId,
            ref int trainingTestType,
            ref string? title,
            ref string? description,
            ref string? createdUserId,
            global::System.Collections.Generic.IList<string>? exIds,
            global::System.Collections.Generic.IList<string>? tagIds);
        partial void PrepareTrainingAddTestRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectId,
            int trainingTestType,
            string? title,
            string? description,
            string? createdUserId,
            global::System.Collections.Generic.IList<string>? exIds,
            global::System.Collections.Generic.IList<string>? tagIds);
        partial void ProcessTrainingAddTestResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTrainingAddTestResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddTest.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="trainingTestType"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createdUserId"></param>
        /// <param name="exIds"></param>
        /// <param name="tagIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> TrainingAddTestAsync(
            string? token = default,
            string? projectId = default,
            int trainingTestType = default,
            string? title = default,
            string? description = default,
            string? createdUserId = default,
            global::System.Collections.Generic.IList<string>? exIds = default,
            global::System.Collections.Generic.IList<string>? tagIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTrainingAddTestArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                trainingTestType: ref trainingTestType,
                title: ref title,
                description: ref description,
                createdUserId: ref createdUserId,
                exIds: exIds,
                tagIds: tagIds);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/training/addtest?projectId={projectId}&trainingTestType={trainingTestType}&title={title}&description={description}&createdUserId={createdUserId}&{string.Join("&", exIds?.Select(static x => $"exIds={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", tagIds?.Select(static x => $"tagIds={x}") ?? global::System.Array.Empty<string>())}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTrainingAddTestRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                trainingTestType: trainingTestType,
                title: title,
                description: description,
                createdUserId: createdUserId,
                exIds: exIds,
                tagIds: tagIds);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTrainingAddTestResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTrainingAddTestResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}