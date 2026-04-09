//HintName: G.ITemplatesClient.TemplatesUpdateCurrentTemplateFromAgentFileNoProject.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Update current template from agent file (Cloud-only)<br/>
        /// Updates the current working version of a template from an agent file
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesUpdateCurrentTemplateFromAgentFileNoProjectResponse> TemplatesUpdateCurrentTemplateFromAgentFileNoProjectAsync(
            string templateName,

            global::G.TemplatesUpdateCurrentTemplateFromAgentFileNoProjectRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update current template from agent file (Cloud-only)<br/>
        /// Updates the current working version of a template from an agent file
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="agentFileJson">
        /// The agent file to update the current template version from
        /// </param>
        /// <param name="updateExistingTools">
        /// If true, update existing custom tools source_code and json_schema (source_type cannot be changed)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="saveExistingChanges">
        /// If true, Letta will automatically save any changes as a version before updating the template<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesUpdateCurrentTemplateFromAgentFileNoProjectResponse> TemplatesUpdateCurrentTemplateFromAgentFileNoProjectAsync(
            string templateName,
            global::System.Collections.Generic.Dictionary<string, object?> agentFileJson,
            bool? updateExistingTools = default,
            bool? saveExistingChanges = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}