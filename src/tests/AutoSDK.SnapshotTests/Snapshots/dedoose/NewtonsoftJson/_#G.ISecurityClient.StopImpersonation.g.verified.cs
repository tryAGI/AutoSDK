//HintName: G.ISecurityClient.StopImpersonation.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// StopImpersonation<br/>
        /// StopImpersonation
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StopImpersonationAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}