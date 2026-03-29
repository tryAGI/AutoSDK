//HintName: G.IDatasetsClient.ApiDatasetsMembersDestroy.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Remove member from dataset<br/>
        /// Remove a member from a specific dataset.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectMember"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetsMembersDestroyAsync(
            int id,
            int? projectMember = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}