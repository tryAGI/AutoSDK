//HintName: G.ITemplatesClient.EditTemplatesByTemplateID2.g.cs
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
        global::System.Threading.Tasks.Task<global::G.TemplateUpdateResponse> EditTemplatesByTemplateID2Async(
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
        global::System.Threading.Tasks.Task<global::G.TemplateUpdateResponse> EditTemplatesByTemplateID2Async(
            string templateID,
            bool? @public = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}