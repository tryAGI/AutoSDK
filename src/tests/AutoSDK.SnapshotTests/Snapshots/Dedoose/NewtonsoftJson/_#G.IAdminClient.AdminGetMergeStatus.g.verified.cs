//HintName: G.IAdminClient.AdminGetMergeStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetMergeStatus.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="mergedProjectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AdminGetMergeStatusAsync(
            string? token = default,
            global::System.Guid? mergedProjectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}