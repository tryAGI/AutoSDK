//HintName: G.ITagsClient.DeleteTemplatesTags.g.cs
#nullable enable

namespace G
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Delete multiple tags from templates
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTemplatesTagsAsync(

            global::G.DeleteTemplateTagsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete multiple tags from templates
        /// </summary>
        /// <param name="name">
        /// Name of the template
        /// </param>
        /// <param name="tags">
        /// Tags to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteTemplatesTagsAsync(
            string name,
            global::System.Collections.Generic.IList<string> tags,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}