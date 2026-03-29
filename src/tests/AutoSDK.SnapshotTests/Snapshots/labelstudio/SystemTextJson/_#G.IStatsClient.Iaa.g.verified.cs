//HintName: G.IStatsClient.Iaa.g.cs
#nullable enable

namespace G
{
    public partial interface IStatsClient
    {
        /// <summary>
        /// ✨ Get Inter-Annotator Agreement matrix<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Get Inter-Annotator Agreement (IAA) matrix for a project, showing agreement between all annotators.
        /// </summary>
        /// <param name="expand"></param>
        /// <param name="id"></param>
        /// <param name="perLabel">
        /// Default Value: false
        /// </param>
        /// <param name="std">
        /// Default Value: false
        /// </param>
        /// <param name="task"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiProjectsStatsIaaRetrieveResponse> IaaAsync(
            int id,
            string? expand = default,
            bool? perLabel = default,
            bool? std = default,
            string? task = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}