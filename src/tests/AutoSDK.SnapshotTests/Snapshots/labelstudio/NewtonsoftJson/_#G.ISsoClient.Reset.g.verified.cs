//HintName: G.ISsoClient.Reset.g.cs
#nullable enable

namespace G
{
    public partial interface ISsoClient
    {
        /// <summary>
        /// ✨ Reset SAML2 Settings<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Reset SAML2 settings for the currently active organization. This clears all configured fields (domain, metadata, attribute mappings, group mappings) back to their defaults without deleting the underlying settings record.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ResetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}