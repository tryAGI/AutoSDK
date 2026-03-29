//HintName: G.ITagsClient.GetTags.g.cs
#nullable enable

namespace G
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Tags<br/>
        /// This endpoint allows the client to retrieve a list of tags that can be used to tag articles.<br/>
        /// It will return tags ordered by popularity.<br/>
        /// It supports pagination, each page will contain 10 tags by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Tag>> GetTagsAsync(
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}