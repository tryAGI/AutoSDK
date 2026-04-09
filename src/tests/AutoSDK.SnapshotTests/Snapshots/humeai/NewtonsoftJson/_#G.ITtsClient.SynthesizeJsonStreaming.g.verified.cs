//HintName: G.ITtsClient.SynthesizeJsonStreaming.g.cs
#nullable enable

namespace G
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Synthesize speech streaming (JSON)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnTts> SynthesizeJsonStreamingAsync(

            global::G.PostedTts request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech streaming (JSON)
        /// </summary>
        /// <param name="format"></param>
        /// <param name="numGenerations"></param>
        /// <param name="utterances"></param>
        /// <param name="context"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnTts> SynthesizeJsonStreamingAsync(
            global::System.Collections.Generic.IList<global::G.PostedUtterance> utterances,
            global::G.AudioFormat? format = default,
            int? numGenerations = default,
            global::G.PostedContext? context = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}