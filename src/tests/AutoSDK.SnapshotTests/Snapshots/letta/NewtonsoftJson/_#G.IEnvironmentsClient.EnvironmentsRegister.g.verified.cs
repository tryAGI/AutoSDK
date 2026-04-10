//HintName: G.IEnvironmentsClient.EnvironmentsRegister.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Register Environment<br/>
        /// Register a new listener connection and get connectionId for WebSocket
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvironmentsRegisterResponse> EnvironmentsRegisterAsync(

            global::G.EnvironmentsRegisterRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register Environment<br/>
        /// Register a new listener connection and get connectionId for WebSocket
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="connectionName"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvironmentsRegisterResponse> EnvironmentsRegisterAsync(
            string deviceId,
            string connectionName,
            global::G.EnvironmentsRegisterRequestMetadata? metadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}