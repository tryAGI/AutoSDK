//HintName: G.IPromptsClient.CreatePromptVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Create prompt version<br/>
        /// Create prompt version
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptVersionDetail> CreatePromptVersionAsync(

            global::G.CreatePromptVersionDetail request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create prompt version<br/>
        /// Create prompt version
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <param name="templateStructure">
        /// Template structure for the prompt: 'text' or 'chat'. Note: This field is only used when creating a new prompt. If a prompt with the given name already exists, this field is ignored and the existing prompt's template structure is used. Template structure is immutable after prompt creation.<br/>
        /// Default Value: text
        /// </param>
        /// <param name="excludeBlueprintUpdateForProjects">
        /// Optional set of project IDs to exclude from automatic blueprint creation when this prompt version is committed.
        /// </param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="projectName">
        /// If provided, scopes the prompt to the specified project. Ignored when project_id is provided.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PromptVersionDetail> CreatePromptVersionAsync(
            string name,
            global::G.PromptVersionDetail version,
            global::G.CreatePromptVersionDetailTemplateStructure? templateStructure = default,
            global::System.Collections.Generic.IList<global::System.Guid>? excludeBlueprintUpdateForProjects = default,
            global::System.Guid? projectId = default,
            string? projectName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}