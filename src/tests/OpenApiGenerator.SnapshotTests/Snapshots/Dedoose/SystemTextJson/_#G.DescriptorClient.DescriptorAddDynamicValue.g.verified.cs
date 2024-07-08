//HintName: G.DescriptorClient.DescriptorAddDynamicValue.g.cs

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorAddDynamicValueArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            ref string setId,
            ref string descriptorId,
            ref string fieldId,
            ref string resourceId,
            ref string data,
            ref string optionId);
        partial void PrepareDescriptorAddDynamicValueRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            string setId,
            string descriptorId,
            string fieldId,
            string resourceId,
            string data,
            string optionId);
        partial void ProcessDescriptorAddDynamicValueResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDescriptorAddDynamicValueResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddDynamicValue.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="fieldId"></param>
        /// <param name="resourceId"></param>
        /// <param name="data"></param>
        /// <param name="optionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> DescriptorAddDynamicValueAsync(
            string token,
            string projectId,
            string setId,
            string descriptorId,
            string fieldId,
            string resourceId,
            string data,
            string optionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDescriptorAddDynamicValueArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                setId: ref setId,
                descriptorId: ref descriptorId,
                fieldId: ref fieldId,
                resourceId: ref resourceId,
                data: ref data,
                optionId: ref optionId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/descriptor/adddynamicvalue?projectId={projectId}&setId={setId}&descriptorId={descriptorId}&fieldId={fieldId}&resourceId={resourceId}&data={data}&optionId={optionId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDescriptorAddDynamicValueRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                setId: setId,
                descriptorId: descriptorId,
                fieldId: fieldId,
                resourceId: resourceId,
                data: data,
                optionId: optionId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDescriptorAddDynamicValueResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDescriptorAddDynamicValueResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}