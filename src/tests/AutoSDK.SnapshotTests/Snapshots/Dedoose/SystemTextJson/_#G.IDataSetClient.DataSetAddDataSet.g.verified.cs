//HintName: G.IDataSetClient.DataSetAddDataSet.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSetClient
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
        global::System.Threading.Tasks.Task<global::G.DataSetVO> DataSetAddDataSetAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? userId = default,
            string? title = default,
            string? description = default,
            bool? areExcerptsFiltered = default,
            bool? areResourcesFiltered = default,
            bool? areDescriptorsFiltered = default,
            bool? areTagsFiltered = default,
            bool? areUsersFiltered = default,
            global::System.Collections.Generic.IList<global::System.Guid>? excerptIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? descriptorIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? userIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? resourceIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? excludedExcerptIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}