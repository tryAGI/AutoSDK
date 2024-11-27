//HintName: G.ITagClient.AddExcerptTagApplications.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// AddExcerptTagApplications<br/>
        /// AddExcerptTagApplications
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddExcerptTagApplicationsAsync(
            global::G.AddExcerptTagApplicationsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// AddExcerptTagApplications<br/>
        /// AddExcerptTagApplications
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="tagApps"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddExcerptTagApplicationsAsync(
            global::System.Guid userId,
            global::System.Guid projectId,
            global::System.Guid resourceId,
            global::System.Guid excerptId,
            global::System.Collections.Generic.IList<global::G.TagAppSimple> tagApps,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}