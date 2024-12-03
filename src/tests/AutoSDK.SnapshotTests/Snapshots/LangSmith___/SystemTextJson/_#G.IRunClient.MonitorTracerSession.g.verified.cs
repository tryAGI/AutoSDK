//HintName: G.IRunClient.MonitorTracerSession.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Monitor Tracer Session<br/>
        /// Get monitoring data for a specific session.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MonitorResponse> MonitorTracerSessionAsync(
            global::G.MonitorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Monitor Tracer Session<br/>
        /// Get monitoring data for a specific session.
        /// </summary>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="groups"></param>
        /// <param name="interval">
        /// Timedelta input.
        /// </param>
        /// <param name="stride">
        /// Timedelta input.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MonitorResponse> MonitorTracerSessionAsync(
            global::System.Collections.Generic.IList<global::G.MonitorGroupSpec> groups,
            string? timezone = default,
            global::G.TimedeltaInput? interval = default,
            global::G.TimedeltaInput? stride = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}