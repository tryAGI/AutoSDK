//HintName: G.IStreamingAPIClient.StreamingInterrupt.g.cs
#nullable enable

namespace G
{
    public partial interface IStreamingAPIClient
    {
        /// <summary>
        /// streaming.interrupt<br/>
        /// This is endpoint is to interrupt a speaking avatar. If the avatar is not speaking, it doesn't do anything.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task StreamingInterruptAsync(
            global::G.StreamingInterruptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// streaming.interrupt<br/>
        /// This is endpoint is to interrupt a speaking avatar. If the avatar is not speaking, it doesn't do anything.
        /// </summary>
        /// <param name="sessionId">
        /// Example: &lt;session_id&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StreamingInterruptAsync(
            string? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}