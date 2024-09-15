//HintName: G.IPricingCalculatorClient.PricingCalculator.g.cs
#nullable enable

namespace G
{
    public partial interface IPricingCalculatorClient
    {
        /// <summary>
        /// Calculating API Cost<br/>
        /// This endpoint returns the cost used for generating images using a particular service type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PricingCalculatorResponse> PricingCalculatorAsync(
            global::G.PricingCalculatorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Calculating API Cost<br/>
        /// This endpoint returns the cost used for generating images using a particular service type.
        /// </summary>
        /// <param name="service">
        /// The services to be chosen for calculating the API credit cost.
        /// </param>
        /// <param name="serviceParams">
        /// Parameters for the service
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PricingCalculatorResponse> PricingCalculatorAsync(
            global::G.PricingCalculatorServices? service = default,
            global::G.PricingCalculatorRequestServiceParams? serviceParams = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}