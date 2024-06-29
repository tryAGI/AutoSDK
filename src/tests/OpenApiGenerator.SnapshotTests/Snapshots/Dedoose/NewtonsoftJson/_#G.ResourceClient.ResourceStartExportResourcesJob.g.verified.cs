//HintName: G.ResourceClient.ResourceStartExportResourcesJob.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ResourceClient
    {
        /// <summary>
        /// StartExportResourcesJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceIds"></param>
        /// <param name="includeDescriptorInfo"></param>
        /// <param name="includeCodeCounts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> ResourceStartExportResourcesJobAsync(
            string token,
            string projectId,
            global::System.Collections.Generic.IList<string> resourceIds,
            bool includeDescriptorInfo,
            bool includeCodeCounts,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/api/v1/resource/startexportresourcesjob?projectId={projectId}&{string.Join("&", resourceIds.Select(static x => $"resourceIds={x}"))}&includeDescriptorInfo={includeDescriptorInfo}&includeCodeCounts={includeCodeCounts}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}