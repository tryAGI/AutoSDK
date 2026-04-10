//HintName: G.ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient
    {
        /// <summary>
        /// Create an entity<br/>
        /// This method creates an entity within a specified entity collection. Each entity must be associated with at least one asset.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Entity> CreateAsync(
            string entityCollectionId,
            string xApiKey,

            global::G.CreateRequest6 request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an entity<br/>
        /// This method creates an entity within a specified entity collection. Each entity must be associated with at least one asset.
        /// </summary>
        /// <param name="entityCollectionId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="name">
        /// The name of the entity. Make sure you use a succinct and descriptive name.
        /// </param>
        /// <param name="description">
        /// An optional description of the entity.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata for the entity, provided as key-value pairs to store additional context or attributes. Use metadata to categorize or describe the entity for easier management and search. Keys must be of type `string`, and values can be of type `string`, `integer`, `float`, or `boolean`.<br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "sport": "soccer",<br/>
        ///   "teamId": 42,<br/>
        ///   "performanceScore": 8.7,<br/>
        ///   "isActive": true<br/>
        /// }<br/>
        /// ```<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   To store complex data types such as objects or arrays, convert them to string values before including them in the metadata.<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="assetIds">
        /// An array of asset IDs to associate with the entity. You must provide at least one value.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Entity> CreateAsync(
            string entityCollectionId,
            string xApiKey,
            string name,
            global::System.Collections.Generic.IList<string> assetIds,
            string? description = default,
            global::G.EntityCollectionsEntityCollectionIdEntitiesPostRequestBodyContentApplicationJsonSchemaMetadata? metadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}