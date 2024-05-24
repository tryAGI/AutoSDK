//HintName: G.DescriptorClient.DescriptorAddOrUpdateDynamicValues.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        /// <summary>
        /// AddOrUpdateDynamicValues.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="values"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DescriptorAddOrUpdateDynamicValuesAsync(
            string token,
            string projectId,
            string resourceId,
            string setId,
            string descriptorId,
            global::System.Collections.Generic.IList<DynamicDescriptorValueDTO> values,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/descriptor/addorupdatedynamicvalues?projectId={projectId}&resourceId={resourceId}&setId={setId}&descriptorId={descriptorId}&{string.Join("&", values.Select(static x => $"values={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}