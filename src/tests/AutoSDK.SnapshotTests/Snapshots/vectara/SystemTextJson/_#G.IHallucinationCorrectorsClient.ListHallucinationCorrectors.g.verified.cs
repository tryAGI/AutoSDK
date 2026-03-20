//HintName: G.IHallucinationCorrectorsClient.ListHallucinationCorrectors.g.cs
#nullable enable

namespace G
{
    public partial interface IHallucinationCorrectorsClient
    {

        /// <summary>
        /// List hallucination correctors<br/>
        /// The List Hallucination Correctors API enables users to list available hallucination correctors used for detecting and correcting hallucinations in AI-generated content. Vectara provides these models as part of its broader hallucination evaluation framework, and the Hallucination Correctors endpoint uses these models to propose factual corrections to summaries and other generative outputs.<br/>
        /// Use this API to inspect available correctors, filter results, and determine which hallucination corrector to reference in downstream workflows or evaluation pipelines.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="filter"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListHallucinationCorrectorsResponse> ListHallucinationCorrectorsAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            int? limit = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}