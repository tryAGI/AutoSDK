//HintName: G.IEmbedJobs2Client.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IEmbedJobs2Client
    {
        /// <summary>
        /// Fetch an Embed Job<br/>
        /// This API retrieves the details about an embed job started by the same user.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbedJob> GetAsync(
            string id,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}