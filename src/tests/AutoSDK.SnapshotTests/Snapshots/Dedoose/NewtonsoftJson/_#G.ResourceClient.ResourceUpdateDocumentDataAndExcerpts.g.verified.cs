//HintName: G.ResourceClient.ResourceUpdateDocumentDataAndExcerpts.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        partial void PrepareResourceUpdateDocumentDataAndExcerptsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? projectId,
            ref string? userId,
            ref string? resourceId,
            ref string? updatedTextDataURI,
            ref int updatedLength,
            global::System.Collections.Generic.IList<global::G.Excerpt>? excerpts);
        partial void PrepareResourceUpdateDocumentDataAndExcerptsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? projectId,
            string? userId,
            string? resourceId,
            string? updatedTextDataURI,
            int updatedLength,
            global::System.Collections.Generic.IList<global::G.Excerpt>? excerpts);
        partial void ProcessResourceUpdateDocumentDataAndExcerptsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResourceUpdateDocumentDataAndExcerptsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateDocumentDataAndExcerpts.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="updatedTextDataURI"></param>
        /// <param name="updatedLength"></param>
        /// <param name="excerpts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ResourceUpdateDocumentDataAndExcerptsResponse> ResourceUpdateDocumentDataAndExcerptsAsync(
            string? token = default,
            string? projectId = default,
            string? userId = default,
            string? resourceId = default,
            string? updatedTextDataURI = default,
            int updatedLength = default,
            global::System.Collections.Generic.IList<global::G.Excerpt>? excerpts = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareResourceUpdateDocumentDataAndExcerptsArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                userId: ref userId,
                resourceId: ref resourceId,
                updatedTextDataURI: ref updatedTextDataURI,
                updatedLength: ref updatedLength,
                excerpts: excerpts);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/resource/updatedocumentdataandexcerpts?projectId={projectId}&userId={userId}&resourceId={resourceId}&updatedTextDataURI={updatedTextDataURI}&updatedLength={updatedLength}&{string.Join("&", excerpts?.Select(static x => $"excerpts={x}") ?? global::System.Array.Empty<string>())}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareResourceUpdateDocumentDataAndExcerptsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                userId: userId,
                resourceId: resourceId,
                updatedTextDataURI: updatedTextDataURI,
                updatedLength: updatedLength,
                excerpts: excerpts);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessResourceUpdateDocumentDataAndExcerptsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessResourceUpdateDocumentDataAndExcerptsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ResourceUpdateDocumentDataAndExcerptsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}