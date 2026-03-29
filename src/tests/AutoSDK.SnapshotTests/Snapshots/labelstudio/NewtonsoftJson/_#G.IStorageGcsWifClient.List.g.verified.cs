//HintName: G.IStorageGcsWifClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IStorageGcsWifClient
    {
        /// <summary>
        /// ✨ Get all GCS WIF export storage<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Get a list of all GCS export storage connections that were set up with WIF authentication.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GCSWIFExportStorage>> ListAsync(
            int project,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}