//HintName: G.IInstructionsClient.ListInstructions.g.cs
#nullable enable

namespace G
{
    public partial interface IInstructionsClient
    {

        /// <summary>
        /// List instructions<br/>
        /// List all instructions available to the authenticated user, with optional filtering and pagination. This endpoint returns high-level information about each instruction, including name, status, and version details.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="filter">
        /// Example: support.*
        /// </param>
        /// <param name="type">
        /// Example: initial
        /// </param>
        /// <param name="enabled">
        /// Example: true
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListInstructionsResponse> ListInstructionsAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            global::G.ListInstructionsType? type = default,
            bool? enabled = default,
            int? limit = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}