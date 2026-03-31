//HintName: G.IProjectTagsClient.PatchProjectTagId.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectTagsClient
    {
        /// <summary>
        /// Partially update project_tag<br/>
        /// Partially update a project_tag object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectTagId">
        /// ProjectTag id
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectTag> PatchProjectTagIdAsync(
            global::System.Guid projectTagId,

            global::G.PatchProjectTag request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially update project_tag<br/>
        /// Partially update a project_tag object. Specify the fields to update in the payload. Any object-type fields will be deep-merged with existing content. Currently we do not support removing fields or setting them to null.
        /// </summary>
        /// <param name="projectTagId">
        /// ProjectTag id
        /// </param>
        /// <param name="name">
        /// Name of the project tag
        /// </param>
        /// <param name="description">
        /// Textual description of the project tag
        /// </param>
        /// <param name="color">
        /// Color of the tag for the UI
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectTag> PatchProjectTagIdAsync(
            global::System.Guid projectTagId,
            string? name = default,
            string? description = default,
            string? color = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}