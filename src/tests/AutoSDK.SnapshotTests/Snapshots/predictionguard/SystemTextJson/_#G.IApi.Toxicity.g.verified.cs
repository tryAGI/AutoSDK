//HintName: G.IApi.Toxicity.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Toxicity<br/>
        /// Check the toxicity of a given text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToxicityResponse200> ToxicityAsync(

            global::G.ToxicityRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Toxicity<br/>
        /// Check the toxicity of a given text.
        /// </summary>
        /// <param name="text">
        /// The text to check for toxicity.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ToxicityResponse200> ToxicityAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}