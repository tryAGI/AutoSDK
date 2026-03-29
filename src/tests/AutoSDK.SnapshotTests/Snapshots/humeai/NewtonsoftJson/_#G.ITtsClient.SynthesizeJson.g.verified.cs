//HintName: G.ITtsClient.SynthesizeJson.g.cs
#nullable enable

namespace G
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Synthesize speech (JSON)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnTts> SynthesizeJsonAsync(

            global::G.PostedTts request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize speech (JSON)
        /// </summary>
        /// <param name="format"></param>
        /// <param name="numGenerations"></param>
        /// <param name="utterances"></param>
        /// <param name="context"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnTts> SynthesizeJsonAsync(
            global::System.Collections.Generic.IList<global::G.PostedUtterance> utterances,
            global::G.AudioFormat? format = default,
            int? numGenerations = default,
            global::G.PostedContext? context = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}