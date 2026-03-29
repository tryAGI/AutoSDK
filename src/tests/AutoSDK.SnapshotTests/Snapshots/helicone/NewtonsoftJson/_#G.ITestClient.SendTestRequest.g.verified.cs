//HintName: G.ITestClient.SendTestRequest.g.cs
#nullable enable

namespace G
{
    public partial interface ITestClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SendTestRequestResponse> SendTestRequestAsync(

            global::G.SendTestRequestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SendTestRequestResponse> SendTestRequestAsync(
            string apiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}