//HintName: G.DescriptorClient.DescriptorUpdateFieldAndOptions.g.cs

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorUpdateFieldAndOptionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref global::System.Guid? fieldId,
            ref string? title,
            ref string? description,
            global::System.Collections.Generic.IList<global::System.Guid>? deletedOptionIds,
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> request);
        partial void PrepareDescriptorUpdateFieldAndOptionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            global::System.Guid? fieldId,
            string? title,
            string? description,
            global::System.Collections.Generic.IList<global::System.Guid>? deletedOptionIds,
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> request);
        partial void ProcessDescriptorUpdateFieldAndOptionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDescriptorUpdateFieldAndOptionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateFieldAndOptions.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fieldId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="deletedOptionIds"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DescriptorFieldWithOptions> DescriptorUpdateFieldAndOptionsAsync(
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> request,
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? fieldId = default,
            string? title = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::System.Guid>? deletedOptionIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareDescriptorUpdateFieldAndOptionsArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                fieldId: ref fieldId,
                title: ref title,
                description: ref description,
                deletedOptionIds: deletedOptionIds,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/descriptor/updatefieldandoptions",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("fieldId", fieldId?.ToString()) 
                .AddOptionalParameter("title", title) 
                .AddOptionalParameter("description", description) 
                .AddOptionalParameter("deletedOptionIds", deletedOptionIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }

            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDescriptorUpdateFieldAndOptionsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                fieldId: fieldId,
                title: title,
                description: description,
                deletedOptionIds: deletedOptionIds,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDescriptorUpdateFieldAndOptionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDescriptorUpdateFieldAndOptionsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DescriptorFieldWithOptions?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}