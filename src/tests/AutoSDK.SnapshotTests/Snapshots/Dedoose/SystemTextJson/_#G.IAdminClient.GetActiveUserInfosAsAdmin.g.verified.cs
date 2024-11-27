//HintName: G.IAdminClient.GetActiveUserInfosAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetActiveUserInfos<br/>
        /// GetActiveUserInfos
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetActiveUserInfosAsAdminAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}