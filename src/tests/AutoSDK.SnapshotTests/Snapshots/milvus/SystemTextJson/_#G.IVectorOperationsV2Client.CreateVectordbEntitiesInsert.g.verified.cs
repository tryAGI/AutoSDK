//HintName: G.IVectorOperationsV2Client.CreateVectordbEntitiesInsert.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorOperationsV2Client
    {
        /// <summary>
        /// Insert<br/>
        /// This operation inserts data into a specific collection. You can insert a maximum of 100 entities at a time. To insert large volumes of data, please use [the bulk-insert API](https://docs.zilliz.com/docs/data-import).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.HttpapiGenericRespCustomerInsertResp> CreateVectordbEntitiesInsertAsync(

            global::G.CreateVectordbEntitiesInsertRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Insert<br/>
        /// This operation inserts data into a specific collection. You can insert a maximum of 100 entities at a time. To insert large volumes of data, please use [the bulk-insert API](https://docs.zilliz.com/docs/data-import).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the target database.
        /// </param>
        /// <param name="collectionName">
        /// The name of an existing collection.
        /// </param>
        /// <param name="data">
        /// The data to insert into the current collection.<br/>
        /// The data to insert should be a dictionary that matches the schema of the current collection or a list of such dictionaries. 
        /// </param>
        /// <param name="partitionName">
        /// The name of a partition in the current collection. <br/>
        /// If specified, the data is to be inserted into the specified partition.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.HttpapiGenericRespCustomerInsertResp> CreateVectordbEntitiesInsertAsync(
            string collectionName,
            global::G.AnyOf<global::G.CreateVectordbEntitiesInsertRequestData, global::System.Collections.Generic.IList<object>> data,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            string? partitionName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}