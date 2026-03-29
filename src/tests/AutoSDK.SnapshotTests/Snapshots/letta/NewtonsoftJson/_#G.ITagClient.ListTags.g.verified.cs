//HintName: G.ITagClient.ListTags.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// List Tags<br/>
        /// Get the list of all tags (from agents and blocks) that have been created.
        /// </summary>
        /// <param name="before">
        /// Tag cursor for pagination. Returns tags that come before this tag in the specified sort order
        /// </param>
        /// <param name="after">
        /// Tag cursor for pagination. Returns tags that come after this tag in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of tags to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for tags. 'asc' for alphabetical order, 'desc' for reverse alphabetical order<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: name
        /// </param>
        /// <param name="queryText">
        /// Filter tags by text search. Deprecated, please use name field instead
        /// </param>
        /// <param name="name">
        /// Filter tags by name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> ListTagsAsync(
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListTagsOrder? order = default,
            string? orderBy = default,
            string? queryText = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}