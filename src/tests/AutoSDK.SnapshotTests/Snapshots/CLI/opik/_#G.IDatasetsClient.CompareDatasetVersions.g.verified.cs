//HintName: G.IDatasetsClient.CompareDatasetVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Compare latest version with draft<br/>
        /// Compare the latest committed dataset version with the current draft state. This endpoint provides insights into changes made since the last version was committed. The comparison calculates additions, modifications, deletions, and unchanged items between the latest version snapshot and current draft.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetVersionDiff> CompareDatasetVersionsAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}