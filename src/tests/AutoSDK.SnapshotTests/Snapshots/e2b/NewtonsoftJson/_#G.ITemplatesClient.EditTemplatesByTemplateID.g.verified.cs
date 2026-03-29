//HintName: G.ITemplatesClient.EditTemplatesByTemplateID.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Update template
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task EditTemplatesByTemplateIDAsync(
            string templateID,

            global::G.TemplateUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update template
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="public">
        /// Whether the template is public or only accessible by the team
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task EditTemplatesByTemplateIDAsync(
            string templateID,
            bool? @public = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}