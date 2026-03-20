//HintName: G.IOrgsClient.OrgsListPatGrantRequestRepositories.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List repositories requested to be accessed by a fine-grained personal access token<br/>
        /// Lists the repositories a fine-grained personal access token request is requesting access to.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patRequestId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MinimalRepository>> OrgsListPatGrantRequestRepositoriesAsync(
            string org,
            int patRequestId,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}