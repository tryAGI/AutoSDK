//HintName: G.IClipsStreamsClient.DeleteStream1.g.cs
#nullable enable

namespace G
{
    public partial interface IClipsStreamsClient
    {
        /// <summary>
        /// Delete a clip stream
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.DeleteStream1Response> DeleteStream1Async(
            string id,

            global::G.DeleteStream1Request request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a clip stream
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.DeleteStream1Response> DeleteStream1Async(
            string id,
            string? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}