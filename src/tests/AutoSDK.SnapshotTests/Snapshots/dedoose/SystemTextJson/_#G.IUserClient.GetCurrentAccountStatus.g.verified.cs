//HintName: G.IUserClient.GetCurrentAccountStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// GetCurrentAccountStatus<br/>
        /// GetCurrentAccountStatus
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserAccountVO> GetCurrentAccountStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}