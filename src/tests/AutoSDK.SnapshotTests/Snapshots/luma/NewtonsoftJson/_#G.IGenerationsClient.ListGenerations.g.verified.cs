//HintName: G.IGenerationsClient.ListGenerations.g.cs
#nullable enable

namespace G
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// List generations<br/>
        /// Retrieve a list of generations with optional filtering and sorting
        /// </summary>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListGenerationResponse> ListGenerationsAsync(
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}