//HintName: G.DataSetClient.DataSetDeleteDataSet.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class DataSetClient
    {
        partial void PrepareDataSetDeleteDataSetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref string? id,
            ref string? projectId,
            ref string? projectIdKey,
            ref string? createdById,
            global::System.DateTime createStamp,
            ref string? title,
            ref string? desciption,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedTagIds,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedDescriptorIds,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedResourceIds,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedExcerptIds,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedUserIds,
            global::System.Collections.Generic.IList<string>? objectIdListsExcludedExcerptIds,
            ref bool areExcerptsFiltered,
            ref bool areResourcesFiltered,
            ref bool areTagsFiltered,
            ref bool areUsersFiltered,
            ref bool areDescriptorsFiltered);
        partial void PrepareDataSetDeleteDataSetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            string? id,
            string? projectId,
            string? projectIdKey,
            string? createdById,
            global::System.DateTime createStamp,
            string? title,
            string? desciption,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedTagIds,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedDescriptorIds,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedResourceIds,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedExcerptIds,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedUserIds,
            global::System.Collections.Generic.IList<string>? objectIdListsExcludedExcerptIds,
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
        public async global::System.Threading.Tasks.Task<global::G.DataSetVO> DataSetDeleteDataSetAsync(
            string? token = default,
            string? id = default,
            string? projectId = default,
            string? projectIdKey = default,
            string? createdById = default,
            global::System.DateTime createStamp = default,
            string? title = default,
            string? desciption = default,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedTagIds = default,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedDescriptorIds = default,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedResourceIds = default,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedExcerptIds = default,
            global::System.Collections.Generic.IList<string>? objectIdListsIncludedUserIds = default,
            global::System.Collections.Generic.IList<string>? objectIdListsExcludedExcerptIds = default,
            bool areExcerptsFiltered = default,
            bool areResourcesFiltered = default,
            bool areTagsFiltered = default,
            bool areUsersFiltered = default,
            bool areDescriptorsFiltered = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDataSetDeleteDataSetArguments(
                httpClient: _httpClient,
                token: ref token,
                id: ref id,
                projectId: ref projectId,
                projectIdKey: ref projectIdKey,
                createdById: ref createdById,
                createStamp: createStamp,
                title: ref title,
                desciption: ref desciption,
                objectIdListsIncludedTagIds: objectIdListsIncludedTagIds,
                objectIdListsIncludedDescriptorIds: objectIdListsIncludedDescriptorIds,
                objectIdListsIncludedResourceIds: objectIdListsIncludedResourceIds,
                objectIdListsIncludedExcerptIds: objectIdListsIncludedExcerptIds,
                objectIdListsIncludedUserIds: objectIdListsIncludedUserIds,
                objectIdListsExcludedExcerptIds: objectIdListsExcludedExcerptIds,
                areExcerptsFiltered: ref areExcerptsFiltered,
                areResourcesFiltered: ref areResourcesFiltered,
                areTagsFiltered: ref areTagsFiltered,
                areUsersFiltered: ref areUsersFiltered,
                areDescriptorsFiltered: ref areDescriptorsFiltered);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/dataset/deletedataset?Id={id}&ProjectId={projectId}&ProjectIdKey={projectIdKey}&CreatedById={createdById}&CreateStamp={createStamp:yyyy-MM-ddTHH:mm:ssZ}&Title={title}&Desciption={desciption}&{string.Join("&", objectIdListsIncludedTagIds?.Select(static x => $"objectIdListsIncludedTagIds={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", objectIdListsIncludedDescriptorIds?.Select(static x => $"objectIdListsIncludedDescriptorIds={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", objectIdListsIncludedResourceIds?.Select(static x => $"objectIdListsIncludedResourceIds={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", objectIdListsIncludedExcerptIds?.Select(static x => $"objectIdListsIncludedExcerptIds={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", objectIdListsIncludedUserIds?.Select(static x => $"objectIdListsIncludedUserIds={x}") ?? global::System.Array.Empty<string>())}&{string.Join("&", objectIdListsExcludedExcerptIds?.Select(static x => $"objectIdListsExcludedExcerptIds={x}") ?? global::System.Array.Empty<string>())}&AreExcerptsFiltered={areExcerptsFiltered}&AreResourcesFiltered={areResourcesFiltered}&AreTagsFiltered={areTagsFiltered}&AreUsersFiltered={areUsersFiltered}&AreDescriptorsFiltered={areDescriptorsFiltered}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDataSetDeleteDataSetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                id: id,
                projectId: projectId,
                projectIdKey: projectIdKey,
                createdById: createdById,
                createStamp: createStamp,
                title: title,
                desciption: desciption,
                objectIdListsIncludedTagIds: objectIdListsIncludedTagIds,
                objectIdListsIncludedDescriptorIds: objectIdListsIncludedDescriptorIds,
                objectIdListsIncludedResourceIds: objectIdListsIncludedResourceIds,
                objectIdListsIncludedExcerptIds: objectIdListsIncludedExcerptIds,
                objectIdListsIncludedUserIds: objectIdListsIncludedUserIds,
                objectIdListsExcludedExcerptIds: objectIdListsExcludedExcerptIds,
                areExcerptsFiltered: areExcerptsFiltered,
                areResourcesFiltered: areResourcesFiltered,
                areTagsFiltered: areTagsFiltered,
                areUsersFiltered: areUsersFiltered,
                areDescriptorsFiltered: areDescriptorsFiltered);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDataSetDeleteDataSetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDataSetDeleteDataSetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.DataSetVO?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}