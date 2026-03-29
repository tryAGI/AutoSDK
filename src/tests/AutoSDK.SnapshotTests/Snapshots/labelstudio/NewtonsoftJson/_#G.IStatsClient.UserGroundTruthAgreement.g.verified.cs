//HintName: G.IStatsClient.UserGroundTruthAgreement.g.cs
#nullable enable

namespace G
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// ✨ Get individual user ground truth agreement<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Get ground truth agreement statistics for a specific user within a project.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="perLabel"></param>
        /// <param name="userPk"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiProjectsUsersStatsAgreementGroundtruthRetrieveResponse> UserGroundTruthAgreementAsync(
            int id,
            int userPk,
            bool? perLabel = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}