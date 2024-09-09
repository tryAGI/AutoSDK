//HintName: G.DataSetClient.DataSetUpdateDataSet.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class DataSetClient
    {
        /// <summary>
        /// UpdateDataSet.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="createdById"></param>
        /// <param name="createStamp"></param>
        /// <param name="title"></param>
        /// <param name="desciption"></param>
        /// <param name="objectIdListsIncludedTagIds"></param>
        /// <param name="objectIdListsIncludedDescriptorIds"></param>
        /// <param name="objectIdListsIncludedResourceIds"></param>
        /// <param name="objectIdListsIncludedExcerptIds"></param>
        /// <param name="objectIdListsIncludedUserIds"></param>
        /// <param name="objectIdListsExcludedExcerptIds"></param>
        /// <param name="areExcerptsFiltered"></param>
        /// <param name="areResourcesFiltered"></param>
        /// <param name="areTagsFiltered"></param>
        /// <param name="areUsersFiltered"></param>
        /// <param name="areDescriptorsFiltered"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<DataSetVO> DataSetUpdateDataSetAsync(
            string token,
            string id,
            string projectId,
            string projectIdKey,
            string createdById,
            global::System.DateTime createStamp,
            string title,
            string desciption,
            global::System.Collections.Generic.IList<string> objectIdListsIncludedTagIds,
            global::System.Collections.Generic.IList<string> objectIdListsIncludedDescriptorIds,
            global::System.Collections.Generic.IList<string> objectIdListsIncludedResourceIds,
            global::System.Collections.Generic.IList<string> objectIdListsIncludedExcerptIds,
            global::System.Collections.Generic.IList<string> objectIdListsIncludedUserIds,
            global::System.Collections.Generic.IList<string> objectIdListsExcludedExcerptIds,
            bool areExcerptsFiltered,
            bool areResourcesFiltered,
            bool areTagsFiltered,
            bool areUsersFiltered,
            bool areDescriptorsFiltered,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/dataset/updatedataset?Id={id}&ProjectId={projectId}&ProjectIdKey={projectIdKey}&CreatedById={createdById}&CreateStamp={createStamp}&Title={title}&Desciption={desciption}&{string.Join("&", objectIdListsIncludedTagIds.Select(static x => $"objectIdLists.IncludedTagIds={x}"))}&{string.Join("&", objectIdListsIncludedDescriptorIds.Select(static x => $"objectIdLists.IncludedDescriptorIds={x}"))}&{string.Join("&", objectIdListsIncludedResourceIds.Select(static x => $"objectIdLists.IncludedResourceIds={x}"))}&{string.Join("&", objectIdListsIncludedExcerptIds.Select(static x => $"objectIdLists.IncludedExcerptIds={x}"))}&{string.Join("&", objectIdListsIncludedUserIds.Select(static x => $"objectIdLists.IncludedUserIds={x}"))}&{string.Join("&", objectIdListsExcludedExcerptIds.Select(static x => $"objectIdLists.ExcludedExcerptIds={x}"))}&AreExcerptsFiltered={areExcerptsFiltered}&AreResourcesFiltered={areResourcesFiltered}&AreTagsFiltered={areTagsFiltered}&AreUsersFiltered={areUsersFiltered}&AreDescriptorsFiltered={areDescriptorsFiltered}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<DataSetVO>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}