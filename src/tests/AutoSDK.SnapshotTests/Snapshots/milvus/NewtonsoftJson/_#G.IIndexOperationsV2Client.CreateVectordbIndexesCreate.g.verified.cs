//HintName: G.IIndexOperationsV2Client.CreateVectordbIndexesCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IIndexOperationsV2Client
    {
        /// <summary>
        /// Create Index<br/>
        /// This creates a named index for a target field, which can either be a vector field or a scalar field.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbIndexesCreateAsync(

            global::G.CreateVectordbIndexesCreateRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Index<br/>
        /// This creates a named index for a target field, which can either be a vector field or a scalar field.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
        /// <param name="collectionName">
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </param>
        /// <param name="indexParams">
        ///   The parameters that apply to the index-building process.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbIndexesCreateAsync(
            string collectionName,
            global::System.Collections.Generic.IList<global::G.IndexParam> indexParams,
            int? requestTimeout = default,
            string? authorization = default,
            string? dbName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}