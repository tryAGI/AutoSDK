//HintName: G.IOllieStateClient.DeleteOllieState.g.cs
#nullable enable

namespace G
{
    public partial interface IOllieStateClient
    {
        /// <summary>
        /// Delete ollie state<br/>
        /// Clear stored ollie state
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteOllieStateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}