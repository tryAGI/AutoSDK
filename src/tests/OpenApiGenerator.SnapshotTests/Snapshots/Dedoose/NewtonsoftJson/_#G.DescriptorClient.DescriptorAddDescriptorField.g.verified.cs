//HintName: G.DescriptorClient.DescriptorAddDescriptorField.g.cs

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorAddDescriptorFieldArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectId,
            ref string? title,
            ref string? description,
            ref double type,
            ref bool isDynamic,
            ref string? setId,
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> request);
        partial void PrepareDescriptorAddDescriptorFieldRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectId,
            string? title,
            string? description,
            double type,
            bool isDynamic,
            string? setId,
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> request);
        partial void ProcessDescriptorAddDescriptorFieldResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDescriptorAddDescriptorFieldResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// AddDescriptorField.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="isDynamic"></param>
        /// <param name="setId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DescriptorFieldWithOptions> DescriptorAddDescriptorFieldAsync(
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> request,
            string? token = default,
            string? projectId = default,
            string? title = default,
            string? description = default,
            double type = default,
            bool isDynamic = default,
            string? setId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareDescriptorAddDescriptorFieldArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                title: ref title,
                description: ref description,
                type: ref type,
                isDynamic: ref isDynamic,
                setId: ref setId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/descriptor/adddescriptorfield?projectId={projectId}&title={title}&description={description}&type={type}&isDynamic={isDynamic}&setId={setId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDescriptorAddDescriptorFieldRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                title: title,
                description: description,
                type: type,
                isDynamic: isDynamic,
                setId: setId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDescriptorAddDescriptorFieldResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDescriptorAddDescriptorFieldResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DescriptorFieldWithOptions?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}