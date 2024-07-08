//HintName: G.ResourceClient.ResourceStartDeleteResourcesJob.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        partial void PrepareResourceStartDeleteResourcesJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            global::System.Collections.Generic.IList<string> resourceIds);
        partial void PrepareResourceStartDeleteResourcesJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            global::System.Collections.Generic.IList<string> resourceIds);
        partial void ProcessResourceStartDeleteResourcesJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResourceStartDeleteResourcesJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartDeleteResourcesJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> ResourceStartDeleteResourcesJobAsync(
            string token,
            string projectId,
            global::System.Collections.Generic.IList<string> resourceIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareResourceStartDeleteResourcesJobArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                resourceIds: resourceIds);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/resource/startdeleteresourcesjob?projectId={projectId}&{string.Join("&", resourceIds.Select(static x => $"resourceIds={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareResourceStartDeleteResourcesJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                resourceIds: resourceIds);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessResourceStartDeleteResourcesJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessResourceStartDeleteResourcesJobResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}