//HintName: G.IDatasetItemsClient.DatasetItemsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetItemsClient
    {
        /// <summary>
        /// Get a dataset item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetItem> DatasetItemsGetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}