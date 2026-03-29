//HintName: G.IOrganizationsClient.UpdateDefaultRole.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// ✨ Update default role<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update the default role for members of a specific organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DefaultRole> UpdateDefaultRoleAsync(
            int id,

            global::G.PatchedDefaultRoleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Update default role<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update the default role for members of a specific organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="annotatorReviewerFirewallEnabledAt">
        /// Set to current time to restrict data sharing between annotators and reviewers in the label stream, review stream, and notifications (which will be disabled). In these settings, information about annotator and reviewer identity is suppressed in the UI.
        /// </param>
        /// <param name="customScriptsEnabledAt">
        /// Set to current time to enable custom scripts (Plugins) for this organization. Can only be enabled if no organization members are active members of any other organizations; otherwise an error will be raised. If this occurs, contact the LEAP team for assistance with enabling custom scripts (Plugins).
        /// </param>
        /// <param name="defaultRole">
        /// Default membership role for invited users<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="emailNotificationSettings">
        /// Email notification settings for this organization. Controls which email notifications users can receive. Structure: {"notifications_allowed": {"notification_type": bool}}
        /// </param>
        /// <param name="embedDomains">
        /// List of objects: {"domain": "example.com"}. Used for CSP header on /embed routes.
        /// </param>
        /// <param name="embedSettings">
        /// Embed settings for this organization
        /// </param>
        /// <param name="externalId">
        /// External ID to uniquely identify this organization
        /// </param>
        /// <param name="extraDataOnActivityLogs"></param>
        /// <param name="labelStreamNavigationDisabledAt">
        /// Set to current time to disable the label stream navigation for this organization. This will prevent users from going back in the label stream to view previous labels.
        /// </param>
        /// <param name="organization">
        /// A unique integer value identifying this organization.
        /// </param>
        /// <param name="readOnlyQuickViewEnabledAt">
        /// Set to current time to prevent creating or editing annotations in quick view.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DefaultRole> UpdateDefaultRoleAsync(
            int id,
            global::System.DateTime? annotatorReviewerFirewallEnabledAt = default,
            global::System.DateTime? customScriptsEnabledAt = default,
            global::G.Role9e7Enum? defaultRole = default,
            object? emailNotificationSettings = default,
            object? embedDomains = default,
            object? embedSettings = default,
            string? externalId = default,
            bool? extraDataOnActivityLogs = default,
            global::System.DateTime? labelStreamNavigationDisabledAt = default,
            int? organization = default,
            global::System.DateTime? readOnlyQuickViewEnabledAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}