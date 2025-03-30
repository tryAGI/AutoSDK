//HintName: G.ITagsClient.DeleteTag.g.cs
#nullable enable

namespace G
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Delete Tag
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="tagName"></param>
        /// <param name="owner"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTagAsync(
            string repo,
            string tagName,
            string owner,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}