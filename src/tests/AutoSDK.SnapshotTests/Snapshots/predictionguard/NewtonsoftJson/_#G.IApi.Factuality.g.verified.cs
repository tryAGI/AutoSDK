//HintName: G.IApi.Factuality.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Factuality<br/>
        /// Check the factuality of a given text compared to a reference.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FactualityResponse200> FactualityAsync(

            global::G.FactualityRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Factuality<br/>
        /// Check the factuality of a given text compared to a reference.
        /// </summary>
        /// <param name="reference">
        /// The reference text for comparison.
        /// </param>
        /// <param name="text">
        /// The text to be checked for factuality.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FactualityResponse200> FactualityAsync(
            string reference,
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}