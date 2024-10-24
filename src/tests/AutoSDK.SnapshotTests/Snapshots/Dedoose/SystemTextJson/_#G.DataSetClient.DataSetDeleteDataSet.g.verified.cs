﻿//HintName: G.DataSetClient.DataSetDeleteDataSet.g.cs

#nullable enable

namespace G
{
    public partial class DataSetClient
    {
        partial void PrepareDataSetDeleteDataSetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? id,
            ref global::System.Guid? projectId,
            ref string? projectIdKey,
            ref global::System.Guid? createdById,
            ref global::System.DateTime? createStamp,
            ref string? title,
            ref string? desciption,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedTagIds,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedDescriptorIds,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedResourceIds,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedExcerptIds,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedUserIds,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsExcludedExcerptIds,
            ref bool? areExcerptsFiltered,
            ref bool? areResourcesFiltered,
            ref bool? areTagsFiltered,
            ref bool? areUsersFiltered,
            ref bool? areDescriptorsFiltered);
        partial void PrepareDataSetDeleteDataSetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? id,
            global::System.Guid? projectId,
            string? projectIdKey,
            global::System.Guid? createdById,
            global::System.DateTime? createStamp,
            string? title,
            string? desciption,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedTagIds,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedDescriptorIds,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedResourceIds,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedExcerptIds,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedUserIds,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsExcludedExcerptIds,
            bool? areExcerptsFiltered,
            bool? areResourcesFiltered,
            bool? areTagsFiltered,
            bool? areUsersFiltered,
            bool? areDescriptorsFiltered);
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
            global::System.Guid? id = default,
            global::System.Guid? projectId = default,
            string? projectIdKey = default,
            global::System.Guid? createdById = default,
            global::System.DateTime? createStamp = default,
            string? title = default,
            string? desciption = default,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedTagIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedDescriptorIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedResourceIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedExcerptIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsIncludedUserIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? objectIdListsExcludedExcerptIds = default,
            bool? areExcerptsFiltered = default,
            bool? areResourcesFiltered = default,
            bool? areTagsFiltered = default,
            bool? areUsersFiltered = default,
            bool? areDescriptorsFiltered = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDataSetDeleteDataSetArguments(
                httpClient: HttpClient,
                token: ref token,
                id: ref id,
                projectId: ref projectId,
                projectIdKey: ref projectIdKey,
                createdById: ref createdById,
                createStamp: ref createStamp,
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

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/dataset/deletedataset",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("Id", id?.ToString()) 
                .AddOptionalParameter("ProjectId", projectId?.ToString()) 
                .AddOptionalParameter("ProjectIdKey", projectIdKey) 
                .AddOptionalParameter("CreatedById", createdById?.ToString()) 
                .AddOptionalParameter("CreateStamp", createStamp?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("Title", title) 
                .AddOptionalParameter("Desciption", desciption) 
                .AddOptionalParameter("ObjectIdLists.IncludedTagIds", objectIdListsIncludedTagIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("ObjectIdLists.IncludedDescriptorIds", objectIdListsIncludedDescriptorIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("ObjectIdLists.IncludedResourceIds", objectIdListsIncludedResourceIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("ObjectIdLists.IncludedExcerptIds", objectIdListsIncludedExcerptIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("ObjectIdLists.IncludedUserIds", objectIdListsIncludedUserIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("ObjectIdLists.ExcludedExcerptIds", objectIdListsExcludedExcerptIds, selector: static x => x.ToString(), delimiter: ",", explode: true) 
                .AddOptionalParameter("AreExcerptsFiltered", areExcerptsFiltered?.ToString()) 
                .AddOptionalParameter("AreResourcesFiltered", areResourcesFiltered?.ToString()) 
                .AddOptionalParameter("AreTagsFiltered", areTagsFiltered?.ToString()) 
                .AddOptionalParameter("AreUsersFiltered", areUsersFiltered?.ToString()) 
                .AddOptionalParameter("AreDescriptorsFiltered", areDescriptorsFiltered?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDataSetDeleteDataSetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDataSetDeleteDataSetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessDataSetDeleteDataSetResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.DataSetVO.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}