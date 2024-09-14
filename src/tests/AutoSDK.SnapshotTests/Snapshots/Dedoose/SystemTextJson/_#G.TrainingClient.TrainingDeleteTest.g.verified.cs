//HintName: G.TrainingClient.TrainingDeleteTest.g.cs

#nullable enable

namespace G
{
    public partial class TrainingClient
    {
        partial void PrepareTrainingDeleteTestArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectIdKey,
            ref global::System.Guid id,
            ref int testType,
            ref string? title,
            ref string? description,
            ref global::System.DateTime createdOn,
            ref global::System.Guid projectId,
            ref int excerptCount,
            ref int tagCount,
            ref global::System.Guid creator);
        partial void PrepareTrainingDeleteTestRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectIdKey,
            global::System.Guid id,
            int testType,
            string? title,
            string? description,
            global::System.DateTime createdOn,
            global::System.Guid projectId,
            int excerptCount,
            int tagCount,
            global::System.Guid creator);
        partial void ProcessTrainingDeleteTestResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTrainingDeleteTestResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// DeleteTest.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="testType"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createdOn"></param>
        /// <param name="projectId"></param>
        /// <param name="excerptCount"></param>
        /// <param name="tagCount"></param>
        /// <param name="creator"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TrainingTest> TrainingDeleteTestAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid id = default,
            int testType = default,
            string? title = default,
            string? description = default,
            global::System.DateTime createdOn = default,
            global::System.Guid projectId = default,
            int excerptCount = default,
            int tagCount = default,
            global::System.Guid creator = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTrainingDeleteTestArguments(
                httpClient: _httpClient,
                token: ref token,
                projectIdKey: ref projectIdKey,
                id: ref id,
                testType: ref testType,
                title: ref title,
                description: ref description,
                createdOn: ref createdOn,
                projectId: ref projectId,
                excerptCount: ref excerptCount,
                tagCount: ref tagCount,
                creator: ref creator);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/training/deletetest?ProjectIdKey={projectIdKey}&Id={id}&TestType={testType}&Title={title}&Description={description}&CreatedOn={createdOn:yyyy-MM-ddTHH:mm:ssZ}&ProjectId={projectId}&ExcerptCount={excerptCount}&TagCount={tagCount}&Creator={creator}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTrainingDeleteTestRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectIdKey: projectIdKey,
                id: id,
                testType: testType,
                title: title,
                description: description,
                createdOn: createdOn,
                projectId: projectId,
                excerptCount: excerptCount,
                tagCount: tagCount,
                creator: creator);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTrainingDeleteTestResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTrainingDeleteTestResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.TrainingTest?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}