//HintName: G.IMarkdownClient.MarkdownRender.g.cs
#nullable enable

namespace G
{
    public partial interface IMarkdownClient
    {
        /// <summary>
        /// Render a Markdown document
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> MarkdownRenderAsync(
            global::G.MarkdownRenderRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Render a Markdown document
        /// </summary>
        /// <param name="text">
        /// The Markdown text to render in HTML.
        /// </param>
        /// <param name="mode">
        /// The rendering mode.<br/>
        /// Default Value: markdown<br/>
        /// Example: markdown
        /// </param>
        /// <param name="context">
        /// The repository context to use when creating references in `gfm` mode.  For example, setting `context` to `octo-org/octo-repo` will change the text `#42` into an HTML link to issue 42 in the `octo-org/octo-repo` repository.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> MarkdownRenderAsync(
            string text,
            global::G.MarkdownRenderRequestMode? mode = default,
            string? context = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}