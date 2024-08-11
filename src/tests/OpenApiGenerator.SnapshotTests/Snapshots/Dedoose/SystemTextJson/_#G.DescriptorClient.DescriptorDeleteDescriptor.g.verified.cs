//HintName: G.DescriptorClient.DescriptorDeleteDescriptor.g.cs

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorDeleteDescriptorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectIdKey,
            ref string? projectId,
            ref string? id,
            ref string? projectIDL,
            global::System.DateTime createStamp,
            ref string? createByIDL,
            ref string? descriptorSetIDL,
            byte[] valuesData,
            byte[] dynamicValuesData);
        partial void PrepareDescriptorDeleteDescriptorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectIdKey,
            string? projectId,
            string? id,
            string? projectIDL,
            global::System.DateTime createStamp,
            string? createByIDL,
            string? descriptorSetIDL,
            byte[] valuesData,
            byte[] dynamicValuesData);
        partial void ProcessDescriptorDeleteDescriptorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDescriptorDeleteDescriptorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// DeleteDescriptor.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="createStamp"></param>
        /// <param name="createByIDL"></param>
        /// <param name="descriptorSetIDL"></param>
        /// <param name="valuesData"></param>
        /// <param name="dynamicValuesData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Descriptor> DescriptorDeleteDescriptorAsync(
            string? token,
            string? projectIdKey,
            string? projectId,
            string? id,
            string? projectIDL,
            global::System.DateTime createStamp,
            string? createByIDL,
            string? descriptorSetIDL,
            byte[] valuesData,
            byte[] dynamicValuesData,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDescriptorDeleteDescriptorArguments(
                httpClient: _httpClient,
                token: ref token,
                projectIdKey: ref projectIdKey,
                projectId: ref projectId,
                id: ref id,
                projectIDL: ref projectIDL,
                createStamp: createStamp,
                createByIDL: ref createByIDL,
                descriptorSetIDL: ref descriptorSetIDL,
                valuesData: valuesData,
                dynamicValuesData: dynamicValuesData);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/descriptor/deletedescriptor?ProjectIdKey={projectIdKey}&ProjectId={projectId}&Id={id}&ProjectIDL={projectIDL}&CreateStamp={createStamp:yyyy-MM-ddTHH:mm:ssZ}&CreateByIDL={createByIDL}&DescriptorSetIDL={descriptorSetIDL}&ValuesData={valuesData}&DynamicValuesData={dynamicValuesData}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDescriptorDeleteDescriptorRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectIdKey: projectIdKey,
                projectId: projectId,
                id: id,
                projectIDL: projectIDL,
                createStamp: createStamp,
                createByIDL: createByIDL,
                descriptorSetIDL: descriptorSetIDL,
                valuesData: valuesData,
                dynamicValuesData: dynamicValuesData);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDescriptorDeleteDescriptorResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDescriptorDeleteDescriptorResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Descriptor?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}