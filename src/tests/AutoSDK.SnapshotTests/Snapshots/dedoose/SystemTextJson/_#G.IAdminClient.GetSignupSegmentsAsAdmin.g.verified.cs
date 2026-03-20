//HintName: G.IAdminClient.GetSignupSegmentsAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetSignupSegments<br/>
        /// GetSignupSegments
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetSignupSegmentsAsAdminAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}