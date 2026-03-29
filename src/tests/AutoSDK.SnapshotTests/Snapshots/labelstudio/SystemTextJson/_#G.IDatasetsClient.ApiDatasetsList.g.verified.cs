//HintName: G.IDatasetsClient.ApiDatasetsList.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List datasets<br/>
        /// List all datasets.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Dataset>> ApiDatasetsListAsync(
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}