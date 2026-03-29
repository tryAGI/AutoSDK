//HintName: G.IEditClient.PostTemplate.g.cs
#nullable enable

namespace G
{
    public partial interface IEditClient
    {
        /// <summary>
        /// Create Template<br/>
        /// Save an [Edit](#tocs_edit) as a re-usable template. Templates can be retrieved and modified in your application<br/>
        /// before being rendered. [Merge fields](#tocs_mergefield) can be also used to merge data in to a template and<br/>
        /// [render](#render-template) it in a single request.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplateResponse> PostTemplateAsync(

            global::G.Template request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Template<br/>
        /// Save an [Edit](#tocs_edit) as a re-usable template. Templates can be retrieved and modified in your application<br/>
        /// before being rendered. [Merge fields](#tocs_mergefield) can be also used to merge data in to a template and<br/>
        /// [render](#render-template) it in a single request.<br/>
        /// **Base URL:** &lt;a href="#"&gt;https://api.shotstack.io/edit/{version}&lt;/a&gt;
        /// </summary>
        /// <param name="name">
        /// The template name<br/>
        /// Example: My template
        /// </param>
        /// <param name="template1">
        /// An edit defines the arrangement of a video on a timeline, an audio edit or an image design and the output format. Video assets are automatically preprocessed to fix common compatibility issues before rendering. You can control preprocessing behavior using the `transcode` flag on video assets.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplateResponse> PostTemplateAsync(
            string name,
            global::G.Edit? template1 = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}