//HintName: G.IGitignoreClient.GitignoreGetTemplate.g.cs
#nullable enable

namespace G
{
    public partial interface IGitignoreClient
    {
        /// <summary>
        /// Get a gitignore template<br/>
        /// Get the content of a gitignore template.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw .gitignore contents.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GitignoreTemplate> GitignoreGetTemplateAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}