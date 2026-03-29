//HintName: G.IOpsClient.OpListV2EntityProjectOpsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IOpsClient
    {
        /// <summary>
        /// Op List<br/>
        /// List op objects.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="limit">
        /// Maximum number of ops to return
        /// </param>
        /// <param name="offset">
        /// Number of ops to skip
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpListV2EntityProjectOpsGetAsync(
            string entity,
            string project,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}