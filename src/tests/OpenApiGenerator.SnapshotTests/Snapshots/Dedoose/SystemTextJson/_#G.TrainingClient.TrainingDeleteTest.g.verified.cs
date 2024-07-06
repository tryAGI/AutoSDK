//HintName: G.TrainingClient.TrainingDeleteTest.g.cs

#nullable enable

namespace G
{
    public partial class TrainingClient
    {
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
            string token,
            string projectIdKey,
            string id,
            int testType,
            string title,
            string description,
            global::System.DateTime createdOn,
            string projectId,
            int excerptCount,
            int tagCount,
            string creator,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/training/deletetest?ProjectIdKey={projectIdKey}&Id={id}&TestType={testType}&Title={title}&Description={description}&CreatedOn={createdOn:yyyy-MM-ddTHH:mm:ssZ}&ProjectId={projectId}&ExcerptCount={excerptCount}&TagCount={tagCount}&Creator={creator}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.TrainingTest?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}