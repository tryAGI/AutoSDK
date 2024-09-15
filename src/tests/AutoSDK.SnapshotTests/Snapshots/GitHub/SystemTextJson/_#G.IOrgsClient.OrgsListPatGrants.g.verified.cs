//HintName: G.IOrgsClient.OrgsListPatGrants.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List fine-grained personal access tokens with access to organization resources<br/>
        /// Lists approved fine-grained personal access tokens owned by organization members that can access organization resources.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="sort">
        /// Default Value: created_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="owner">
        /// Example: owner[]=octocat1,owner[]=octocat2
        /// </param>
        /// <param name="repository">
        /// Example: Hello-World
        /// </param>
        /// <param name="permission">
        /// Example: issues_read
        /// </param>
        /// <param name="lastUsedBefore"></param>
        /// <param name="lastUsedAfter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BasicError> OrgsListPatGrantsAsync(
            string org,
            int perPage = 30,
            int page = 1,
            global::G.OrgsListPatGrantsSort? sort = global::G.OrgsListPatGrantsSort.CreatedAt,
            global::G.OrgsListPatGrantsDirection? direction = global::G.OrgsListPatGrantsDirection.Desc,
            global::System.Collections.Generic.IList<string>? owner = default,
            string? repository = default,
            string? permission = default,
            global::System.DateTime lastUsedBefore = default,
            global::System.DateTime lastUsedAfter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}