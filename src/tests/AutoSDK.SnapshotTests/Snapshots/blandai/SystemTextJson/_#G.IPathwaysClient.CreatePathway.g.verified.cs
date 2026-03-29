//HintName: G.IPathwaysClient.CreatePathway.g.cs
#nullable enable

namespace G
{
    public partial interface IPathwaysClient
    {
        /// <summary>
        /// Create Pathway<br/>
        /// Create a new conversational pathway.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePathwayResponse> CreatePathwayAsync(

            global::G.CreatePathwayRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Pathway<br/>
        /// Create a new conversational pathway.
        /// </summary>
        /// <param name="name">
        /// Name of the conversational pathway
        /// </param>
        /// <param name="description">
        /// Description of the pathway
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePathwayResponse> CreatePathwayAsync(
            string name,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}