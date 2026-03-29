//HintName: G.IVectorOperationsV2Client.CreateVectordbEntitiesDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorOperationsV2Client
    {
        /// <summary>
        /// Delete<br/>
        /// This operation deletes entities by their IDs or with a boolean expression.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.HttpapiGenericRespCustomerDeleteResp> CreateVectordbEntitiesDeleteAsync(

            global::G.CreateVectordbEntitiesDeleteRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete<br/>
        /// This operation deletes entities by their IDs or with a boolean expression.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the target database.
        /// </param>
        /// <param name="collectionName">
        /// The name of an existing collection.
        /// </param>
        /// <param name="filter">
        /// A scalar filtering condition to filter matching entities.    The value defaults to an empty string, indicating that no condition applies. Setting both **id** and **filter** results in an error.<br/>
        /// You can set this parameter to an empty string to skip scalar filtering. To build a scalar filtering condition, refer to [Boolean Expression Rules](https://milvus.io/docs/boolean.md). 
        /// </param>
        /// <param name="partitionName">
        /// The name of a partition in the current collection. <br/>
        /// If specified, the data is to be deleted from the specified partition.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.HttpapiGenericRespCustomerDeleteResp> CreateVectordbEntitiesDeleteAsync(
            string collectionName,
            string filter,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            string? partitionName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}