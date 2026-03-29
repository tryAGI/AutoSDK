//HintName: G.IStripeClient.CreateSetupSession.g.cs
#nullable enable

namespace G
{
    public partial interface IStripeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSetupSessionResponse> CreateSetupSessionAsync(

            global::G.CreateSetupSessionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSetupSessionResponse> CreateSetupSessionAsync(
            string? returnUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}