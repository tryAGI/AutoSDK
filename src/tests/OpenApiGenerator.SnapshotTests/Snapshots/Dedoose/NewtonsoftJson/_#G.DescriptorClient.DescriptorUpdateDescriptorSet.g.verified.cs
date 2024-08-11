//HintName: G.DescriptorClient.DescriptorUpdateDescriptorSet.g.cs

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorUpdateDescriptorSetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectIdKey,
            ref string? projectId,
            ref string? id,
            ref string? projectIDL,
            ref string? title,
            ref string? description,
            global::System.DateTime createStamp,
            ref string? createdByUserId);
        partial void PrepareDescriptorUpdateDescriptorSetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectIdKey,
            string? projectId,
            string? id,
            string? projectIDL,
            string? title,
            string? description,
            global::System.DateTime createStamp,
            string? createdByUserId);
        partial void ProcessDescriptorUpdateDescriptorSetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDescriptorUpdateDescriptorSetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateDescriptorSet.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="createStamp"></param>
        /// <param name="createdByUserId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DescriptorSet> DescriptorUpdateDescriptorSetAsync(
            string? token,
            string? projectIdKey,
            string? projectId,
            string? id,
            string? projectIDL,
            string? title,
            string? description,
            global::System.DateTime createStamp,
            string? createdByUserId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDescriptorUpdateDescriptorSetArguments(
                httpClient: _httpClient,
                token: ref token,
                projectIdKey: ref projectIdKey,
                projectId: ref projectId,
                id: ref id,
                projectIDL: ref projectIDL,
                title: ref title,
                description: ref description,
                createStamp: createStamp,
                createdByUserId: ref createdByUserId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/descriptor/updatedescriptorset?ProjectIdKey={projectIdKey}&ProjectId={projectId}&Id={id}&ProjectIDL={projectIDL}&Title={title}&Description={description}&CreateStamp={createStamp:yyyy-MM-ddTHH:mm:ssZ}&CreatedByUserId={createdByUserId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDescriptorUpdateDescriptorSetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectIdKey: projectIdKey,
                projectId: projectId,
                id: id,
                projectIDL: projectIDL,
                title: title,
                description: description,
                createStamp: createStamp,
                createdByUserId: createdByUserId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDescriptorUpdateDescriptorSetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDescriptorUpdateDescriptorSetResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DescriptorSet?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}