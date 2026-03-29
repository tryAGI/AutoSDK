//HintName: G.ISubpackageEntityCollectionsClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEntityCollectionsClient
    {
        /// <summary>
        /// Create an entity collection<br/>
        /// This method creates an entity collection.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EntityCollection> CreateAsync(
            string xApiKey,

            global::G.CreateRequest5 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an entity collection<br/>
        /// This method creates an entity collection.
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="name">
        /// The name of the entity collection. Make sure you use a succinct and descriptive name.
        /// </param>
        /// <param name="description">
        /// Optional description of the entity collection.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EntityCollection> CreateAsync(
            string xApiKey,
            string name,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}