//HintName: G.IOrgsClient.OrgsList.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List organizations<br/>
        /// Lists all organizations, in the order that they were created.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api#using-link-headers) to get the URL for the next page of organizations.
        /// </summary>
        /// <param name="since"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.OrganizationSimple>> OrgsListAsync(
            int? since = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}