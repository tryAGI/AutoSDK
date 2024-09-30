//HintName: G.DescriptorClient.DescriptorForceDeleteDescriptorSetPolled.g.cs

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorForceDeleteDescriptorSetPolledArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectIDL,
            ref global::System.Guid? descriptorSetId);
        partial void PrepareDescriptorForceDeleteDescriptorSetPolledRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectIDL,
            global::System.Guid? descriptorSetId);
        partial void ProcessDescriptorForceDeleteDescriptorSetPolledResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDescriptorForceDeleteDescriptorSetPolledResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ForceDeleteDescriptorSetPolled.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIDL"></param>
        /// <param name="descriptorSetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> DescriptorForceDeleteDescriptorSetPolledAsync(
            string? token = default,
            global::System.Guid? projectIDL = default,
            global::System.Guid? descriptorSetId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDescriptorForceDeleteDescriptorSetPolledArguments(
                httpClient: _httpClient,
                token: ref token,
                projectIDL: ref projectIDL,
                descriptorSetId: ref descriptorSetId);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/descriptor/forcedeletedescriptorsetpolled",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectIDL", projectIDL?.ToString()) 
                .AddOptionalParameter("descriptorSetId", descriptorSetId?.ToString()) 
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
            PrepareDescriptorForceDeleteDescriptorSetPolledRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectIDL: projectIDL,
                descriptorSetId: descriptorSetId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDescriptorForceDeleteDescriptorSetPolledResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDescriptorForceDeleteDescriptorSetPolledResponseContent(
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

            return __content;
        }
    }
}