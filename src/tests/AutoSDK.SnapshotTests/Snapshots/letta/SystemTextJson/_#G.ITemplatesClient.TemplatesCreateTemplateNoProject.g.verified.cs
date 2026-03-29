//HintName: G.ITemplatesClient.TemplatesCreateTemplateNoProject.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Create template (Cloud-only)<br/>
        /// Creates a new template from an existing agent or agent file
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesCreateTemplateNoProjectResponse> TemplatesCreateTemplateNoProjectAsync(

            global::G.TemplatesCreateTemplateNoProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create template (Cloud-only)<br/>
        /// Creates a new template from an existing agent or agent file
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesCreateTemplateNoProjectResponse> TemplatesCreateTemplateNoProjectAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}