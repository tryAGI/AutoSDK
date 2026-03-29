//HintName: G.ILogsClient.GetInternalTriggerLogById.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get detailed trigger log by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetInternalTriggerLogByIdResponse> GetInternalTriggerLogByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}