//HintName: G.IMemoClient.UnlinkObject.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// UnlinkObject<br/>
        /// UnlinkObject
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UnlinkObjectAsync(
            global::G.UnlinkObjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UnlinkObject<br/>
        /// UnlinkObject
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="tagId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UnlinkObjectAsync(
            global::System.Guid projectId,
            global::System.Guid memoId,
            global::System.Guid resourceId,
            global::System.Guid excerptId,
            global::System.Guid descriptorId,
            global::System.Guid tagId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}