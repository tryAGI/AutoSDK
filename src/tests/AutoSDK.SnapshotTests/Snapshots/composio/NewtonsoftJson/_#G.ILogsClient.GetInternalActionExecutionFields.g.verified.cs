//HintName: G.ILogsClient.GetInternalActionExecutionFields.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get action log fields for filtering
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetInternalActionExecutionFieldsResponse> GetInternalActionExecutionFieldsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}