//HintName: G.IPathwaysClient.GetPathway.g.cs
#nullable enable

namespace G
{
    public partial interface IPathwaysClient
    {
        /// <summary>
        /// Get Pathway<br/>
        /// Retrieve detailed information about a specific conversational pathway, including its nodes and edges.
        /// </summary>
        /// <param name="pathwayId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pathway> GetPathwayAsync(
            string pathwayId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}