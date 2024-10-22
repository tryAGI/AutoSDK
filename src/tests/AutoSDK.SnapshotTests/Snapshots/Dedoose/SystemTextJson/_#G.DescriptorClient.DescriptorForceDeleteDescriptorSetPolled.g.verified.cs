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
                client: HttpClient);
            PrepareDescriptorForceDeleteDescriptorSetPolledArguments(
                httpClient: HttpClient,
                token: ref token,
                projectIDL: ref projectIDL,
                descriptorSetId: ref descriptorSetId);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/descriptor/forcedeletedescriptorsetpolled",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectIDL", projectIDL?.ToString()) 
                .AddOptionalParameter("descriptorSetId", descriptorSetId?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDescriptorForceDeleteDescriptorSetPolledRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                projectIDL: projectIDL,
                descriptorSetId: descriptorSetId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDescriptorForceDeleteDescriptorSetPolledResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessDescriptorForceDeleteDescriptorSetPolledResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return __content;
        }
    }
}