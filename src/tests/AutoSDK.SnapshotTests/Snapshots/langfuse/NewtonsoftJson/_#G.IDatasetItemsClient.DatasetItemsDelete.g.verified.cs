//HintName: G.IDatasetItemsClient.DatasetItemsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetItemsClient
    {
        /// <summary>
        /// Delete a dataset item and all its run items. This action is irreversible.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteDatasetItemResponse> DatasetItemsDeleteAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}