//HintName: G.IEmbedJobsClient.GetEmbedJob.g.cs
#nullable enable

namespace G
{
    public partial interface IEmbedJobsClient
    {
        /// <summary>
        /// Fetch an Embed Job<br/>
        /// This API retrieves the details about an embed job started by the same user.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbedJob> GetEmbedJobAsync(
            string id,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}