//HintName: G.IVectorOperationsV2Client.CreateVectordbEntitiesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorOperationsV2Client
    {
        /// <summary>
        /// Get<br/>
        /// This operation gets specific entities by their IDs.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVectordbEntitiesGetResponse> CreateVectordbEntitiesGetAsync(

            global::G.CreateVectordbEntitiesGetRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get<br/>
        /// This operation gets specific entities by their IDs.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database.
        /// </param>
        /// <param name="collectionName">
        /// The name of the collection to which this operation applies.
        /// </param>
        /// <param name="id">
        /// A specific entity ID or a list of entity IDs.
        /// </param>
        /// <param name="outputFields">
        /// An array of fields to return along with the search results.
        /// </param>
        /// <param name="partitionNames">
        /// The name of the partitions to which this operation applies.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVectordbEntitiesGetResponse> CreateVectordbEntitiesGetAsync(
            string collectionName,
            global::G.AnyOf<int?, string, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<string>> id,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            global::System.Collections.Generic.IList<string>? outputFields = default,
            global::System.Collections.Generic.IList<string>? partitionNames = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}