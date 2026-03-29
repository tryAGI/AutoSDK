//HintName: G.IPlaygroundClient.RequestsThroughHelicone.g.cs
#nullable enable

namespace G
{
    public partial interface IPlaygroundClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringString> RequestsThroughHeliconeAsync(

            global::G.RequestsThroughHeliconeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestsThroughHelicone"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringString> RequestsThroughHeliconeAsync(
            bool requestsThroughHelicone,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}