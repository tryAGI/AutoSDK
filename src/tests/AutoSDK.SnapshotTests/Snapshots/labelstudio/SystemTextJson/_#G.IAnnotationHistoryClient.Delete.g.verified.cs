//HintName: G.IAnnotationHistoryClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationHistoryClient
    {
        /// <summary>
        /// ✨ Delete annotation history items<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Delete all annotation history items for a specific annotation, task or project. This method is available only for users with administrator roles.
        /// </summary>
        /// <param name="annotation"></param>
        /// <param name="project"></param>
        /// <param name="task"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiAnnotationHistoryDestroyResponse> DeleteAsync(
            int? annotation = default,
            int? project = default,
            int? task = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}