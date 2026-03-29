//HintName: G.IVectorOperationsV2Client.CreateVectordbEntitiesUpsert.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorOperationsV2Client
    {
        /// <summary>
        /// Upsert<br/>
        /// This operation inserts new records into the database or updates existing ones.  Currently, this endpoint does not apply to the collections that have autoId enabled.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.HttpapiGenericRespCustomerUpsertResp> CreateVectordbEntitiesUpsertAsync(

            global::G.CreateVectordbEntitiesUpsertRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert<br/>
        /// This operation inserts new records into the database or updates existing ones.  Currently, this endpoint does not apply to the collections that have autoId enabled.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database.
        /// </param>
        /// <param name="collectionName">
        /// The name of the collection in which to upsert data.
        /// </param>
        /// <param name="data">
        /// The data to insert into the current collection. <br/>
        /// The data to insert should be a dictionary that matches the schema of the current collection or a list of such dictionaries.
        /// </param>
        /// <param name="partitionName">
        /// The name of a partition in the current collection. <br/>
        /// If specified, the data is to be inserted into the specified partition.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.HttpapiGenericRespCustomerUpsertResp> CreateVectordbEntitiesUpsertAsync(
            string collectionName,
            global::G.AnyOf<global::G.CreateVectordbEntitiesUpsertRequestData, global::System.Collections.Generic.IList<object>> data,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            string? partitionName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}