//HintName: G.IApi.GetCollections.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get a collection of models<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/collections/super-resolution<br/>
        /// ```<br/>
        /// The response will be a collection object with a nested list of the models in that collection:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "name": "Super resolution",<br/>
        ///   "slug": "super-resolution",<br/>
        ///   "description": "Upscaling models that create high-quality images from low-quality images.",<br/>
        ///   "models": [...]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="collectionSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetCollectionsAsync(
            string collectionSlug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}