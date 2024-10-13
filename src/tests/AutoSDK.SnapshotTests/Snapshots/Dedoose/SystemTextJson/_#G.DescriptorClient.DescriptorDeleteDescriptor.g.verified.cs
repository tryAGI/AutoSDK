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
            ref global::System.Guid? projectId,
            ref global::System.Guid? id,
            ref global::System.Guid? projectIDL,
            ref global::System.DateTime? createStamp,
            ref global::System.Guid? createByIDL,
            ref global::System.Guid? descriptorSetIDL,
            byte[]? valuesData,
            byte[]? dynamicValuesData);
        partial void PrepareDescriptorDeleteDescriptorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectIdKey,
            global::System.Guid? projectId,
            global::System.Guid? id,
            global::System.Guid? projectIDL,
            global::System.DateTime? createStamp,
            global::System.Guid? createByIDL,
            global::System.Guid? descriptorSetIDL,
            byte[]? valuesData,
            byte[]? dynamicValuesData);
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
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid? projectId = default,
            global::System.Guid? id = default,
            global::System.Guid? projectIDL = default,
            global::System.DateTime? createStamp = default,
            global::System.Guid? createByIDL = default,
            global::System.Guid? descriptorSetIDL = default,
            byte[]? valuesData = default,
            byte[]? dynamicValuesData = default,
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
                createStamp: ref createStamp,
                createByIDL: ref createByIDL,
                descriptorSetIDL: ref descriptorSetIDL,
                valuesData: valuesData,
                dynamicValuesData: dynamicValuesData);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/descriptor/deletedescriptor",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("ProjectIdKey", projectIdKey) 
                .AddOptionalParameter("ProjectId", projectId?.ToString()) 
                .AddOptionalParameter("Id", id?.ToString()) 
                .AddOptionalParameter("ProjectIDL", projectIDL?.ToString()) 
                .AddOptionalParameter("CreateStamp", createStamp?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("CreateByIDL", createByIDL?.ToString()) 
                .AddOptionalParameter("DescriptorSetIDL", descriptorSetIDL?.ToString()) 
                .AddOptionalParameter("ValuesData", valuesData?.ToString()) 
                .AddOptionalParameter("DynamicValuesData", dynamicValuesData?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


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
                global::G.Descriptor.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}