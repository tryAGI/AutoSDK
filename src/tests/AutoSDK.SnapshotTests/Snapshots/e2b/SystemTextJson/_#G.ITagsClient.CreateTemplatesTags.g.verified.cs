//HintName: G.ITagsClient.CreateTemplatesTags.g.cs
#nullable enable

namespace G
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Assign tag(s) to a template build
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssignedTemplateTags> CreateTemplatesTagsAsync(

            global::G.AssignTemplateTagsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign tag(s) to a template build
        /// </summary>
        /// <param name="target">
        /// Target template in "name:tag" format
        /// </param>
        /// <param name="tags">
        /// Tags to assign to the template
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssignedTemplateTags> CreateTemplatesTagsAsync(
            string target,
            global::System.Collections.Generic.IList<string> tags,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}