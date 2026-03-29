//HintName: G.ISubpackageSearchClient.Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageSearchClient
    {
        /// <summary>
        /// Retrieve a specific page of search results<br/>
        /// Use this endpoint to retrieve a specific page of search results.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// When you use pagination, you will not be charged for retrieving subsequent pages of results.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="pageToken"></param>
        /// <param name="includeUserMetadata"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchRetrieveResponse200> RetrieveAsync(
            string pageToken,
            string xApiKey,
            bool? includeUserMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}