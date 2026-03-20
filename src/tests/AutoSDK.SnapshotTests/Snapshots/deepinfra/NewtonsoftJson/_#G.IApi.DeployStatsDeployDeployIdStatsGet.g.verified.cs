//HintName: G.IApi.DeployStatsDeployDeployIdStatsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deploy Stats
        /// </summary>
        /// <param name="deployId"></param>
        /// <param name="from">
        /// start of period, unix ts or 'now-5h', supported units s(ec), m(min), h(our), d(ay), w(eek), M(onth)
        /// </param>
        /// <param name="to">
        /// end of period, unix ts or now-relative, check from, defaults to now<br/>
        /// Default Value: now
        /// </param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeploymentStatsOut> DeployStatsDeployDeployIdStatsGetAsync(
            string deployId,
            string from,
            string? to = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}