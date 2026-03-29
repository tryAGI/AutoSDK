//HintName: G.IObjectivesClient.ListObjectives.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectivesClient
    {
        /// <summary>
        /// List Objectives<br/>
        /// Returns a list of all objectives.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListObjectivesResponse> ListObjectivesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}