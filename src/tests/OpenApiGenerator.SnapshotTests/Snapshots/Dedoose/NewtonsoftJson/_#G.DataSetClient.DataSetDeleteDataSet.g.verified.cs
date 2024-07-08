//HintName: G.DataSetClient.DataSetDeleteDataSet.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class DataSetClient
    {
        partial void PrepareDataSetDeleteDataSetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string id,
            ref string projectId,
            ref string projectIdKey,
            ref string createdById,
            global::System.DateTime createStamp,
            ref string title,
            ref string desciption,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedTagIds,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedDescriptorIds,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedResourceIds,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedExcerptIds,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedUserIds,
            global::System.Collections.Generic.IList<string> objectIdLists_ExcludedExcerptIds,
            ref bool areExcerptsFiltered,
            ref bool areResourcesFiltered,
            ref bool areTagsFiltered,
            ref bool areUsersFiltered,
            ref bool areDescriptorsFiltered);
        partial void PrepareDataSetDeleteDataSetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string id,
            string projectId,
            string projectIdKey,
            string createdById,
            global::System.DateTime createStamp,
            string title,
            string desciption,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedTagIds,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedDescriptorIds,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedResourceIds,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedExcerptIds,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedUserIds,
            global::System.Collections.Generic.IList<string> objectIdLists_ExcludedExcerptIds,
            bool areExcerptsFiltered,
            bool areResourcesFiltered,
            bool areTagsFiltered,
            bool areUsersFiltered,
            bool areDescriptorsFiltered);
        partial void ProcessDataSetDeleteDataSetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);
        partial void ProcessDataSetDeleteDataSetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// DeleteDataSet.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="createdById"></param>
        /// <param name="createStamp"></param>
        /// <param name="title"></param>
        /// <param name="desciption"></param>
        /// <param name="objectIdLists_IncludedTagIds"></param>
        /// <param name="objectIdLists_IncludedDescriptorIds"></param>
        /// <param name="objectIdLists_IncludedResourceIds"></param>
        /// <param name="objectIdLists_IncludedExcerptIds"></param>
        /// <param name="objectIdLists_IncludedUserIds"></param>
        /// <param name="objectIdLists_ExcludedExcerptIds"></param>
        /// <param name="areExcerptsFiltered"></param>
        /// <param name="areResourcesFiltered"></param>
        /// <param name="areTagsFiltered"></param>
        /// <param name="areUsersFiltered"></param>
        /// <param name="areDescriptorsFiltered"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.DataSetVO> DataSetDeleteDataSetAsync(
            string token,
            string id,
            string projectId,
            string projectIdKey,
            string createdById,
            global::System.DateTime createStamp,
            string title,
            string desciption,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedTagIds,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedDescriptorIds,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedResourceIds,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedExcerptIds,
            global::System.Collections.Generic.IList<string> objectIdLists_IncludedUserIds,
            global::System.Collections.Generic.IList<string> objectIdLists_ExcludedExcerptIds,
            bool areExcerptsFiltered,
            bool areResourcesFiltered,
            bool areTagsFiltered,
            bool areUsersFiltered,
            bool areDescriptorsFiltered,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/dataset/deletedataset?Id={id}&ProjectId={projectId}&ProjectIdKey={projectIdKey}&CreatedById={createdById}&CreateStamp={createStamp:yyyy-MM-ddTHH:mm:ssZ}&Title={title}&Desciption={desciption}&{string.Join("&", objectIdLists_IncludedTagIds.Select(static x => $"objectIdLists_IncludedTagIds={x}"))}&{string.Join("&", objectIdLists_IncludedDescriptorIds.Select(static x => $"objectIdLists_IncludedDescriptorIds={x}"))}&{string.Join("&", objectIdLists_IncludedResourceIds.Select(static x => $"objectIdLists_IncludedResourceIds={x}"))}&{string.Join("&", objectIdLists_IncludedExcerptIds.Select(static x => $"objectIdLists_IncludedExcerptIds={x}"))}&{string.Join("&", objectIdLists_IncludedUserIds.Select(static x => $"objectIdLists_IncludedUserIds={x}"))}&{string.Join("&", objectIdLists_ExcludedExcerptIds.Select(static x => $"objectIdLists_ExcludedExcerptIds={x}"))}&AreExcerptsFiltered={areExcerptsFiltered}&AreResourcesFiltered={areResourcesFiltered}&AreTagsFiltered={areTagsFiltered}&AreUsersFiltered={areUsersFiltered}&AreDescriptorsFiltered={areDescriptorsFiltered}", global::System.UriKind.RelativeOrAbsolute));

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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DataSetVO?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}