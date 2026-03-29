//HintName: G.ISubpackageIndexesSubpackageIndexesIndexedAssetsClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageIndexesSubpackageIndexesIndexedAssetsClient
    {
        /// <summary>
        /// Partial update indexed asset information<br/>
        /// This method updates one or more fields of the metadata of an indexed asset. Also, can delete a field by setting it to `null`.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="indexedAssetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexesIndexedAssetsUpdateResponse204> UpdateAsync(
            string indexId,
            string indexedAssetId,
            string xApiKey,

            global::G.UpdateRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partial update indexed asset information<br/>
        /// This method updates one or more fields of the metadata of an indexed asset. Also, can delete a field by setting it to `null`.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="indexedAssetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your videos. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float` or `boolean`.<br/>
        /// **Example**:<br/>
        /// ```JSON<br/>
        /// "user_metadata": {<br/>
        ///   "category": "recentlyAdded",<br/>
        ///   "batchNumber": 5,<br/>
        ///   "rating": 9.3,<br/>
        ///   "needsReview": true<br/>
        /// }<br/>
        /// ```<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// -  If you want to store other types of data such as objects or arrays,  you must convert your data into string values.<br/>
        /// - You cannot override the following system-generated metadata fields:<br/>
        ///   - `duration`<br/>
        ///   - `filename`<br/>
        ///   - `fps`<br/>
        ///   - `height`<br/>
        ///   - `model_names`<br/>
        ///   - `size`<br/>
        ///   - `video_title`<br/>
        ///   - `width`<br/>
        /// &lt;/Note&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexesIndexedAssetsUpdateResponse204> UpdateAsync(
            string indexId,
            string indexedAssetId,
            string xApiKey,
            global::G.UserMetadata? userMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}