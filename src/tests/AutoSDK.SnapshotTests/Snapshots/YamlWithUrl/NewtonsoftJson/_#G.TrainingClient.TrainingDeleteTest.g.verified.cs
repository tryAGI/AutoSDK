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
        public async global::System.Threading.Tasks.Task<TrainingTest> TrainingDeleteTestAsync(
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
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/training/deletetest?ProjectIdKey={projectIdKey}&Id={id}&TestType={testType}&Title={title}&Description={description}&CreatedOn={createdOn}&ProjectId={projectId}&ExcerptCount={excerptCount}&TagCount={tagCount}&Creator={creator}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<TrainingTest>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}