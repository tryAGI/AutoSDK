//HintName: G.IDataSetClient.DataSetUpdateDataSet.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSetClient
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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSetVO> DataSetUpdateDataSetAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}