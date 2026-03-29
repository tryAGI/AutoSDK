//HintName: G.IRiggingClient.DeleteRiggingTask.g.cs
#nullable enable

namespace G
{
    public partial interface IRiggingClient
    {
        /// <summary>
        /// Delete a Rigging task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteRiggingTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}