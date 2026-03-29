//HintName: G.IDatasetsClient.RemoveDatasetDeployment.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Remove Dataset Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environmentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveDatasetDeploymentAsync(
            string id,
            string environmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}