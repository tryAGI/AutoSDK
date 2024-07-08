//HintName: G.TagClient.TagDeleteTagByJob.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        partial void PrepareTagDeleteTagByJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string currentProjectId,
            ref string projectIdKey,
            ref string projectId,
            ref string id,
            ref string projectIDL,
            ref string title,
            ref string description,
            ref bool isWeighted,
            ref double weightMin,
            ref double weightMax,
            ref double weightDefault,
            ref int sortOrder,
            ref int color,
            ref bool allowDecimalWeight);
        partial void PrepareTagDeleteTagByJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string currentProjectId,
            string projectIdKey,
            string projectId,
            string id,
            string projectIDL,
            string title,
            string description,
            bool isWeighted,
            double weightMin,
            double weightMax,
            double weightDefault,
            int sortOrder,
            int color,
            bool allowDecimalWeight);
        partial void ProcessTagDeleteTagByJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);
        partial void ProcessTagDeleteTagByJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// DeleteTagByJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="currentProjectId"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="isWeighted"></param>
        /// <param name="weightMin"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightDefault"></param>
        /// <param name="sortOrder"></param>
        /// <param name="color"></param>
        /// <param name="allowDecimalWeight"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> TagDeleteTagByJobAsync(
            string token,
            string currentProjectId,
            string projectIdKey,
            string projectId,
            string id,
            string projectIDL,
            string title,
            string description,
            bool isWeighted,
            double weightMin,
            double weightMax,
            double weightDefault,
            int sortOrder,
            int color,
            bool allowDecimalWeight,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/tag/deletetagbyjob?currentProjectId={currentProjectId}&ProjectIdKey={projectIdKey}&ProjectId={projectId}&Id={id}&ProjectIDL={projectIDL}&Title={title}&Description={description}&IsWeighted={isWeighted}&WeightMin={weightMin}&WeightMax={weightMax}&WeightDefault={weightDefault}&SortOrder={sortOrder}&Color={color}&AllowDecimalWeight={allowDecimalWeight}", global::System.UriKind.RelativeOrAbsolute));

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
                global::System.Text.Json.JsonSerializer.Deserialize<string?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}