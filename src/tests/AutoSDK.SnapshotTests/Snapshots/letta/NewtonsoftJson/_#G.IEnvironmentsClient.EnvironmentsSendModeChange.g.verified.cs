//HintName: G.IEnvironmentsClient.EnvironmentsSendModeChange.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Change Environment Mode<br/>
        /// Change the permission mode of a specific environment connection
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvironmentsSendModeChangeResponse> EnvironmentsSendModeChangeAsync(
            string connectionId,

            global::G.EnvironmentsSendModeChangeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change Environment Mode<br/>
        /// Change the permission mode of a specific environment connection
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="mode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EnvironmentsSendModeChangeResponse> EnvironmentsSendModeChangeAsync(
            string connectionId,
            global::G.EnvironmentsSendModeChangeRequestMode mode,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}