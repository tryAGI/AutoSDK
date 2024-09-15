//HintName: G.IMarkdownClient.MarkdownRenderRaw.g.cs
#nullable enable

namespace G
{
    public partial interface IMarkdownClient
    {
        /// <summary>
        /// Render a Markdown document in raw mode<br/>
        /// You must send Markdown as plain text (using a `Content-Type` header of `text/plain` or `text/x-markdown`) to this endpoint, rather than using JSON format. In raw mode, [GitHub Flavored Markdown](https://github.github.com/gfm/) is not supported and Markdown will be rendered in plain format like a README.md file. Markdown content must be 400 KB or less.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> MarkdownRenderRawAsync(
            string request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}