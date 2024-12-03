//HintName: G.IDatasetClient.GetDatasetById.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// Get a Single Dataset by ID<br/>
        /// This endpoint gets the specific dataset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetDatasetByIdResponse> GetDatasetByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}