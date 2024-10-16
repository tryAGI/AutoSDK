﻿//HintName: G.DescriptorClient.DescriptorImportFields.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class DescriptorClient
    {
        /// <summary>
        /// ImportFields.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="fieldInfos"></param>
        /// <param name="existingSetId"></param>
        /// <param name="newSetTitle"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DescriptorImportFieldsAsync(
            string token,
            string projectId,
            string userId,
            global::System.Collections.Generic.IList<FieldInfo> fieldInfos,
            string existingSetId,
            string newSetTitle,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/descriptor/importfields?projectId={projectId}&userId={userId}&{string.Join("&", fieldInfos.Select(static x => $"fieldInfos={x}"))}&existingSetId={existingSetId}&newSetTitle={newSetTitle}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}