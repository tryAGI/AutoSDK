//HintName: G.IPathwaysClient.ListPathways.g.cs
#nullable enable

namespace G
{
    public partial interface IPathwaysClient
    {
        /// <summary>
        /// List All Pathways<br/>
        /// Retrieve information about all conversational pathways in your account, including name, description, nodes, and edges.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Pathway>> ListPathwaysAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}