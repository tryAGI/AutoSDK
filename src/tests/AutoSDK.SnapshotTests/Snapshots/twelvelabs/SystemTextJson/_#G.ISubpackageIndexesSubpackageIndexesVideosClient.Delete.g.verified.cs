//HintName: G.ISubpackageIndexesSubpackageIndexesVideosClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageIndexesSubpackageIndexesVideosClient
    {
        /// <summary>
        /// Delete video information<br/>
        /// &lt;Info&gt;This method will be deprecated in a future version. New implementations should use the [Delete an indexed asset](/v1.3/api-reference/index-content/delete) method.&lt;/Info&gt;<br/>
        /// This method deletes all the information about the specified indexed video. This action cannot be undone.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="videoId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexesVideosDeleteResponse204> DeleteAsync(
            string indexId,
            string videoId,
            string xApiKey,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}