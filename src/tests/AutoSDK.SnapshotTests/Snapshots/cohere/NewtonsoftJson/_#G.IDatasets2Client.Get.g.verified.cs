//HintName: G.IDatasets2Client.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasets2Client
    {
        /// <summary>
        /// Get a Dataset<br/>
        /// Retrieve a dataset by ID. See ['Datasets'](https://docs.cohere.com/docs/datasets) for more information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetsGetResponse> GetAsync(
            string id,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}