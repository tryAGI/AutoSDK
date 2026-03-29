//HintName: G.ISubpackageEmbedSubpackageEmbedTasksClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEmbedSubpackageEmbedTasksClient
    {
        /// <summary>
        /// List video embedding tasks<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This method will be deprecated in a future version. Migrate to the [Embed API v2](/v1.3/api-reference/create-embeddings-v2) for continued support and access to new features.<br/>
        /// &lt;/Note&gt;<br/>
        /// This method returns a list of the video embedding tasks in your account. The platform returns your video embedding tasks sorted by creation date, with the newest at the top of the list.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - Video embeddings are stored for seven days<br/>
        /// - When you invoke this method without specifying the `started_at` and `ended_at` parameters, the platform returns all the video embedding tasks created within the last seven days.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="status"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 10
        /// </param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbedTasksListResponse200> ListAsync(
            string xApiKey,
            string? startedAt = default,
            string? endedAt = default,
            string? status = default,
            int? page = default,
            int? pageLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}