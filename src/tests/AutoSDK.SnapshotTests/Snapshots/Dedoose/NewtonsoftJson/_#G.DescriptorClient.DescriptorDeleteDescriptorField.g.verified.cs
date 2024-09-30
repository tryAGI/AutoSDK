//HintName: G.DescriptorClient.DescriptorDeleteDescriptorField.g.cs

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorDeleteDescriptorFieldArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectIdKey,
            ref global::System.Guid? projectId,
            ref global::System.Guid? id,
            ref global::System.Guid? projectIDL,
            ref global::System.Guid? descriptorSetIDL,
            ref int? type,
            ref string? title,
            ref string? description,
            ref bool? isDynamicField,
            ref int? sortOrder);
        partial void PrepareDescriptorDeleteDescriptorFieldRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectIdKey,
            global::System.Guid? projectId,
            global::System.Guid? id,
            global::System.Guid? projectIDL,
            global::System.Guid? descriptorSetIDL,
            int? type,
            string? title,
            string? description,
            bool? isDynamicField,
            int? sortOrder);
        partial void ProcessDescriptorDeleteDescriptorFieldResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDescriptorDeleteDescriptorFieldResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// DeleteDescriptorField.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="descriptorSetIDL"></param>
        /// <param name="type"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="isDynamicField"></param>
        /// <param name="sortOrder"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DescriptorField> DescriptorDeleteDescriptorFieldAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid? projectId = default,
            global::System.Guid? id = default,
            global::System.Guid? projectIDL = default,
            global::System.Guid? descriptorSetIDL = default,
            int? type = default,
            string? title = default,
            string? description = default,
            bool? isDynamicField = default,
            int? sortOrder = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDescriptorDeleteDescriptorFieldArguments(
                httpClient: _httpClient,
                token: ref token,
                projectIdKey: ref projectIdKey,
                projectId: ref projectId,
                id: ref id,
                projectIDL: ref projectIDL,
                descriptorSetIDL: ref descriptorSetIDL,
                type: ref type,
                title: ref title,
                description: ref description,
                isDynamicField: ref isDynamicField,
                sortOrder: ref sortOrder);

            if (token != default)
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("token", token.ToString());
            }

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/descriptor/deletedescriptorfield",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("ProjectIdKey", projectIdKey) 
                .AddOptionalParameter("ProjectId", projectId?.ToString()) 
                .AddOptionalParameter("Id", id?.ToString()) 
                .AddOptionalParameter("ProjectIDL", projectIDL?.ToString()) 
                .AddOptionalParameter("DescriptorSetIDL", descriptorSetIDL?.ToString()) 
                .AddOptionalParameter("Type", type?.ToString()) 
                .AddOptionalParameter("Title", title) 
                .AddOptionalParameter("Description", description) 
                .AddOptionalParameter("IsDynamicField", isDynamicField?.ToString()) 
                .AddOptionalParameter("SortOrder", sortOrder?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDescriptorDeleteDescriptorFieldRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectIdKey: projectIdKey,
                projectId: projectId,
                id: id,
                projectIDL: projectIDL,
                descriptorSetIDL: descriptorSetIDL,
                type: type,
                title: title,
                description: description,
                isDynamicField: isDynamicField,
                sortOrder: sortOrder);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDescriptorDeleteDescriptorFieldResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDescriptorDeleteDescriptorFieldResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DescriptorField?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}