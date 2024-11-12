//HintName: G.IAdminClient.AdminGetSignupSegments.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetSignupSegments.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AdminGetSignupSegmentsAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}