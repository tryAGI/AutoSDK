//HintName: G.ITemplatesClient.TemplatesCreateAgentsFromTemplateNoProject.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Create Agents From Template<br/>
        /// Creates an Agent or multiple Agents from a template
        /// </summary>
        /// <param name="templateVersion"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesCreateAgentsFromTemplateNoProjectResponse> TemplatesCreateAgentsFromTemplateNoProjectAsync(
            string templateVersion,

            global::G.TemplatesCreateAgentsFromTemplateNoProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agents From Template<br/>
        /// Creates an Agent or multiple Agents from a template
        /// </summary>
        /// <param name="templateVersion"></param>
        /// <param name="tags">
        /// The tags to assign to the agent
        /// </param>
        /// <param name="agentName">
        /// The name of the agent, optional otherwise a random one will be assigned
        /// </param>
        /// <param name="initialMessageSequence">
        /// Set an initial sequence of messages, if not provided, the agent will start with the default message sequence, if an empty array is provided, the agent will start with no messages
        /// </param>
        /// <param name="memoryVariables">
        /// The memory variables to assign to the agent
        /// </param>
        /// <param name="toolVariables">
        /// The tool variables to assign to the agent
        /// </param>
        /// <param name="identityIds">
        /// The identity ids to assign to the agent
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TemplatesCreateAgentsFromTemplateNoProjectResponse> TemplatesCreateAgentsFromTemplateNoProjectAsync(
            string templateVersion,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? agentName = default,
            global::System.Collections.Generic.IList<global::G.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItem>? initialMessageSequence = default,
            global::System.Collections.Generic.Dictionary<string, string>? memoryVariables = default,
            global::System.Collections.Generic.Dictionary<string, string>? toolVariables = default,
            global::System.Collections.Generic.IList<string>? identityIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}