//HintName: G.DescriptorClient.DescriptorAddDynamicValue.g.cs

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorAddDynamicValueArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref global::System.Guid? setId,
            ref global::System.Guid? descriptorId,
            ref global::System.Guid? fieldId,
            ref global::System.Guid? resourceId,
            ref string? data,
            ref global::System.Guid? optionId);
        partial void PrepareDescriptorAddDynamicValueRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            global::System.Guid? setId,
            global::System.Guid? descriptorId,
            global::System.Guid? fieldId,
            global::System.Guid? resourceId,
            string? data,
            global::System.Guid? optionId);
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
        public async global::System.Threading.Tasks.Task<string> DescriptorAddDynamicValueAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? setId = default,
            global::System.Guid? descriptorId = default,
            global::System.Guid? fieldId = default,
            global::System.Guid? resourceId = default,
            string? data = default,
            global::System.Guid? optionId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDescriptorAddDynamicValueArguments(
                httpClient: HttpClient,
                token: ref token,
                projectId: ref projectId,
                setId: ref setId,
                descriptorId: ref descriptorId,
                fieldId: ref fieldId,
                resourceId: ref resourceId,
                data: ref data,
                optionId: ref optionId);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/descriptor/adddynamicvalue",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("setId", setId?.ToString()) 
                .AddOptionalParameter("descriptorId", descriptorId?.ToString()) 
                .AddOptionalParameter("fieldId", fieldId?.ToString()) 
                .AddOptionalParameter("resourceId", resourceId?.ToString()) 
                .AddOptionalParameter("data", data) 
                .AddOptionalParameter("optionId", optionId?.ToString()) 
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
            PrepareDescriptorAddDynamicValueRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                projectId: projectId,
                setId: setId,
                descriptorId: descriptorId,
                fieldId: fieldId,
                resourceId: resourceId,
                data: data,
                optionId: optionId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDescriptorAddDynamicValueResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessDescriptorAddDynamicValueResponseContent(
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