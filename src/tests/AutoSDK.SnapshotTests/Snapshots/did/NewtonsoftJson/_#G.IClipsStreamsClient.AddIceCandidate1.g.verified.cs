//HintName: G.IClipsStreamsClient.AddIceCandidate1.g.cs
#nullable enable

namespace G
{
    public partial interface IClipsStreamsClient
    {
        /// <summary>
        /// Submit network information<br/>
        /// Updates the server with a WebRTC ICE candidate. If the candidate parameter is missing or a value of null is given the added ICE candidate is an "end-of-candidates" indicator.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.AddIceCandidate1Response> AddIceCandidate1Async(
            string id,

            global::G.AllOf<global::G.AnyOf<global::G.AddIceCandidate1RequestVariant12, object>?, global::G.AddIceCandidate1Request2> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit network information<br/>
        /// Updates the server with a WebRTC ICE candidate. If the candidate parameter is missing or a value of null is given the added ICE candidate is an "end-of-candidates" indicator.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.AddIceCandidate1Response> AddIceCandidate1Async(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}