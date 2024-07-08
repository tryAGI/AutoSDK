//HintName: G.ResourceClient.ResourceUpdateTranscriptData.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        partial void PrepareResourceUpdateTranscriptDataArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectIdKey,
            ref string id,
            ref string creator,
            ref string projectId,
            ref string resourceId,
            ref string dataPath,
            global::System.DateTime created,
            ref string transcriptData,
            global::System.Collections.Generic.IList<global::G.TranscriptSyncItem> syncItems);
        partial void PrepareResourceUpdateTranscriptDataRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectIdKey,
            string id,
            string creator,
            string projectId,
            string resourceId,
            string dataPath,
            global::System.DateTime created,
            string transcriptData,
            global::System.Collections.Generic.IList<global::G.TranscriptSyncItem> syncItems);
        partial void ProcessResourceUpdateTranscriptDataResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessResourceUpdateTranscriptDataResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateTranscriptData.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="creator"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="dataPath"></param>
        /// <param name="created"></param>
        /// <param name="transcriptData"></param>
        /// <param name="syncItems"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> ResourceUpdateTranscriptDataAsync(
            string token,
            string projectIdKey,
            string id,
            string creator,
            string projectId,
            string resourceId,
            string dataPath,
            global::System.DateTime created,
            string transcriptData,
            global::System.Collections.Generic.IList<global::G.TranscriptSyncItem> syncItems,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareResourceUpdateTranscriptDataArguments(
                httpClient: _httpClient,
                token: ref token,
                projectIdKey: ref projectIdKey,
                id: ref id,
                creator: ref creator,
                projectId: ref projectId,
                resourceId: ref resourceId,
                dataPath: ref dataPath,
                created: created,
                transcriptData: ref transcriptData,
                syncItems: syncItems);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/resource/updatetranscriptdata?ProjectIdKey={projectIdKey}&Id={id}&Creator={creator}&ProjectId={projectId}&ResourceId={resourceId}&DataPath={dataPath}&Created={created:yyyy-MM-ddTHH:mm:ssZ}&transcriptData={transcriptData}&{string.Join("&", syncItems.Select(static x => $"syncItems={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareResourceUpdateTranscriptDataRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectIdKey: projectIdKey,
                id: id,
                creator: creator,
                projectId: projectId,
                resourceId: resourceId,
                dataPath: dataPath,
                created: created,
                transcriptData: transcriptData,
                syncItems: syncItems);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessResourceUpdateTranscriptDataResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessResourceUpdateTranscriptDataResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}