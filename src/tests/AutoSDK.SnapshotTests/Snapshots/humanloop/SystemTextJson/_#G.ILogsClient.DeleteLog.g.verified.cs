//HintName: G.ILogsClient.DeleteLog.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Delete Log
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteLogAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}