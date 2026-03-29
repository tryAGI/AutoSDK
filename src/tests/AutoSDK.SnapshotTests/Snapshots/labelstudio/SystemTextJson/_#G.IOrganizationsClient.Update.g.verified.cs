//HintName: G.IOrganizationsClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// ✨ Update organization<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update organization details including title, embed domains, and Plugins settings.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseOrganization> UpdateAsync(
            int id,

            global::G.PatchedLseOrganizationSerializerUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Update organization<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update organization details including title, embed domains, and Plugins settings.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contactInfo"></param>
        /// <param name="createdBy"></param>
        /// <param name="customScriptsEnabled">
        /// Plugins<br/>
        /// Included only in requests
        /// </param>
        /// <param name="emailNotificationSettings">
        /// Email Notification Settings<br/>
        /// Included only in requests
        /// </param>
        /// <param name="embedDomains">
        /// Supported domains<br/>
        /// Included only in requests
        /// </param>
        /// <param name="embedSettings">
        /// Public Verification Key and Public Verification Algorithms configuration<br/>
        /// Included only in requests
        /// </param>
        /// <param name="title">
        /// Organization name<br/>
        /// Included only in requests
        /// </param>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseOrganization> UpdateAsync(
            int id,
            bool? customScriptsEnabled,
            object? emailNotificationSettings,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? embedDomains,
            object? embedSettings,
            string? title,
            string? contactInfo = default,
            int? createdBy = default,
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}