//HintName: G.IOrganizationsClient.GetImport.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// ✨ Get member tag import status<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Retrieve the status and results of a member tag import job.<br/>
        /// The response includes the current status (created, in_progress, completed, failed), timestamps, and counts of tags created, assignments made, and users skipped.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="importPk"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationMemberTagImportStatus> GetImportAsync(
            int id,
            int importPk,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}