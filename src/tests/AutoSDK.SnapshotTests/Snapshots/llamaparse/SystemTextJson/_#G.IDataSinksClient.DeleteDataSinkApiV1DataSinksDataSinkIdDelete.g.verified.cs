//HintName: G.IDataSinksClient.DeleteDataSinkApiV1DataSinksDataSinkIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IDataSinksClient
    {
        /// <summary>
        /// Delete Data Sink<br/>
        /// Delete a data sink by ID.
        /// </summary>
        /// <param name="dataSinkId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDataSinkApiV1DataSinksDataSinkIdDeleteAsync(
            global::System.Guid dataSinkId,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}