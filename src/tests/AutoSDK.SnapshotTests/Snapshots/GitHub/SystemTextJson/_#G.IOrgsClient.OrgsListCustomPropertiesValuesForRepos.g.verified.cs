//HintName: G.IOrgsClient.OrgsListCustomPropertiesValuesForRepos.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List custom property values for organization repositories<br/>
        /// Lists organization repositories with all of their custom property values.<br/>
        /// Organization members can read these properties.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="repositoryQuery"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.OrgRepoCustomPropertyValues>> OrgsListCustomPropertiesValuesForReposAsync(
            string org,
            int? perPage = default,
            int? page = default,
            string? repositoryQuery = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}