//HintName: G.DataSetClient.DataSetAddDataSet.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class DataSetClient
    {
        /// <summary>
        /// AddDataSet.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="areExcerptsFiltered"></param>
        /// <param name="areResourcesFiltered"></param>
        /// <param name="areDescriptorsFiltered"></param>
        /// <param name="areTagsFiltered"></param>
        /// <param name="areUsersFiltered"></param>
        /// <param name="excerptIds"></param>
        /// <param name="descriptorIds"></param>
        /// <param name="userIds"></param>
        /// <param name="resourceIds"></param>
        /// <param name="tagIds"></param>
        /// <param name="excludedExcerptIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DataSetVO> DataSetAddDataSetAsync(
            string token,
            string projectId,
            string userId,
            string title,
            string description,
            bool areExcerptsFiltered,
            bool areResourcesFiltered,
            bool areDescriptorsFiltered,
            bool areTagsFiltered,
            bool areUsersFiltered,
            global::System.Collections.Generic.IList<string> excerptIds,
            global::System.Collections.Generic.IList<string> descriptorIds,
            global::System.Collections.Generic.IList<string> userIds,
            global::System.Collections.Generic.IList<string> resourceIds,
            global::System.Collections.Generic.IList<string> tagIds,
            global::System.Collections.Generic.IList<string> excludedExcerptIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/dataset/adddataset?projectId={projectId}&userId={userId}&title={title}&description={description}&areExcerptsFiltered={areExcerptsFiltered}&areResourcesFiltered={areResourcesFiltered}&areDescriptorsFiltered={areDescriptorsFiltered}&areTagsFiltered={areTagsFiltered}&areUsersFiltered={areUsersFiltered}&{string.Join("&", excerptIds.Select(static x => $"excerptIds={x}"))}&{string.Join("&", descriptorIds.Select(static x => $"descriptorIds={x}"))}&{string.Join("&", userIds.Select(static x => $"userIds={x}"))}&{string.Join("&", resourceIds.Select(static x => $"resourceIds={x}"))}&{string.Join("&", tagIds.Select(static x => $"tagIds={x}"))}&{string.Join("&", excludedExcerptIds.Select(static x => $"excludedExcerptIds={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataSetVO?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}