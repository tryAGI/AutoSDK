//HintName: G.ICollectionOperationsV2Client.CreateVectordbCollectionsLoad.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionOperationsV2Client
    {
        /// <summary>
        /// Load Collection<br/>
        /// This operation loads the data of the current collection into memory. 
        /// </summary>
        /// <param name="requestHeader"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbCollectionsLoadAsync(
            int requestHeader,

            global::G.CollectionName request,
            string? authorization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Load Collection<br/>
        /// This operation loads the data of the current collection into memory. 
        /// </summary>
        /// <param name="requestHeader"></param>
        /// <param name="authorization"></param>
        /// <param name="dbName">
        /// The name of the database to which the collection belongs.<br/>
        /// Setting this to a non-existing database results in a **MilvusException**.
        /// </param>
        /// <param name="collectionName1">
        /// The name of the target collection.<br/>
        /// Setting this to a non-existing collection results in a **MilvusException**.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbCollectionsLoadAsync(
            int requestHeader,
            string collectionName1,
            string? authorization = default,
            string? dbName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}