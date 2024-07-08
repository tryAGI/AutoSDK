//HintName: G.ResourceClient.ResourceDeleteResource.g.cs

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        partial void PrepareResourceDeleteResourceArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string currentProjectId,
            ref string projectIdKey,
            ref string projectId,
            ref string id,
            ref string projectIDL,
            ref string title,
            ref string description,
            ref int type,
            ref string dataPath,
            ref int length,
            global::System.DateTime createStamp,
            ref string createByUserIDL,
            ref bool isDataLocked,
            ref string metaData);
        partial void PrepareResourceDeleteResourceRequest(
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
            int type,
            string dataPath,
            int length,
            global::System.DateTime createStamp,
            string createByUserIDL,
            bool isDataLocked,
            string metaData);
        partial void ProcessResourceDeleteResourceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResourceDeleteResourceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// DeleteResource.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="currentProjectId"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="dataPath"></param>
        /// <param name="length"></param>
        /// <param name="createStamp"></param>
        /// <param name="createByUserIDL"></param>
        /// <param name="isDataLocked"></param>
        /// <param name="metaData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Resource> ResourceDeleteResourceAsync(
            string token,
            string currentProjectId,
            string projectIdKey,
            string projectId,
            string id,
            string projectIDL,
            string title,
            string description,
            int type,
            string dataPath,
            int length,
            global::System.DateTime createStamp,
            string createByUserIDL,
            bool isDataLocked,
            string metaData,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareResourceDeleteResourceArguments(
                httpClient: _httpClient,
                token: ref token,
                currentProjectId: ref currentProjectId,
                projectIdKey: ref projectIdKey,
                projectId: ref projectId,
                id: ref id,
                projectIDL: ref projectIDL,
                title: ref title,
                description: ref description,
                type: ref type,
                dataPath: ref dataPath,
                length: ref length,
                createStamp: createStamp,
                createByUserIDL: ref createByUserIDL,
                isDataLocked: ref isDataLocked,
                metaData: ref metaData);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/resource/deleteresource?currentProjectId={currentProjectId}&ProjectIdKey={projectIdKey}&ProjectId={projectId}&Id={id}&ProjectIDL={projectIDL}&Title={title}&Description={description}&Type={type}&DataPath={dataPath}&Length={length}&CreateStamp={createStamp:yyyy-MM-ddTHH:mm:ssZ}&CreateByUserIDL={createByUserIDL}&IsDataLocked={isDataLocked}&MetaData={metaData}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareResourceDeleteResourceRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                currentProjectId: currentProjectId,
                projectIdKey: projectIdKey,
                projectId: projectId,
                id: id,
                projectIDL: projectIDL,
                title: title,
                description: description,
                type: type,
                dataPath: dataPath,
                length: length,
                createStamp: createStamp,
                createByUserIDL: createByUserIDL,
                isDataLocked: isDataLocked,
                metaData: metaData);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessResourceDeleteResourceResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessResourceDeleteResourceResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Resource?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}