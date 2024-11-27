//HintName: G.IDataSetClient.AddDataSet.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSetClient
    {
        /// <summary>
        /// AddDataSet<br/>
        /// AddDataSet
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DataSetVO> AddDataSetAsync(
            global::G.AddDataSetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddDataSet<br/>
        /// AddDataSet
        /// </summary>
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
        global::System.Threading.Tasks.Task<global::G.DataSetVO> AddDataSetAsync(
            global::System.Guid projectId,
            global::System.Guid userId,
            string title,
            string description,
            bool areExcerptsFiltered,
            bool areResourcesFiltered,
            bool areDescriptorsFiltered,
            bool areTagsFiltered,
            bool areUsersFiltered,
            global::System.Collections.Generic.IList<global::System.Guid> excerptIds,
            global::System.Collections.Generic.IList<global::System.Guid> descriptorIds,
            global::System.Collections.Generic.IList<global::System.Guid> userIds,
            global::System.Collections.Generic.IList<global::System.Guid> resourceIds,
            global::System.Collections.Generic.IList<global::System.Guid> tagIds,
            global::System.Collections.Generic.IList<global::System.Guid> excludedExcerptIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}