//HintName: G.DescriptorClient.DescriptorUpdateFieldAndOptions.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        partial void PrepareDescriptorUpdateFieldAndOptionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectId,
            ref string? fieldId,
            ref string? title,
            ref string? description,
            global::System.Collections.Generic.IList<string>? deletedOptionIds,
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> request);
        partial void PrepareDescriptorUpdateFieldAndOptionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectId,
            string? fieldId,
            string? title,
            string? description,
            global::System.Collections.Generic.IList<string>? deletedOptionIds,
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
            string? token,
            string? projectId,
            string? fieldId,
            string? title,
            string? description,
            global::System.Collections.Generic.IList<string>? deletedOptionIds,
            global::System.Collections.Generic.IList<global::G.FieldOptionVO> request,
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

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/descriptor/updatefieldandoptions?projectId={projectId}&fieldId={fieldId}&title={title}&description={description}&{string.Join("&", deletedOptionIds?.Select(static x => $"deletedOptionIds={x}") ?? global::System.Array.Empty<string>())}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
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

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.DescriptorFieldWithOptions?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}