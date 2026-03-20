//HintName: G.ITeamsClient.TeamsListChildLegacy.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List child teams (Legacy)<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`List child teams`](https://docs.github.com/rest/teams/teams#list-child-teams) endpoint.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Team>> TeamsListChildLegacyAsync(
            int teamId,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}