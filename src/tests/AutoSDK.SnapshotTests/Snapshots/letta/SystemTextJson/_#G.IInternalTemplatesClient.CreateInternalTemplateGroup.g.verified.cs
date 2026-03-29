//HintName: G.IInternalTemplatesClient.CreateInternalTemplateGroup.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IInternalTemplatesClient
    {
        /// <summary>
        /// Create Group<br/>
        /// Create a new multi-agent group with the specified configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Group> CreateInternalTemplateGroupAsync(

            global::G.InternalTemplateGroupCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Group<br/>
        /// Create a new multi-agent group with the specified configuration.
        /// </summary>
        /// <param name="agentIds"></param>
        /// <param name="description"></param>
        /// <param name="managerConfig">
        /// Default Value: {"manager_type":"round_robin"}
        /// </param>
        /// <param name="projectId">
        /// The associated project id.
        /// </param>
        /// <param name="hidden">
        /// If set to True, the group will be hidden.
        /// </param>
        /// <param name="baseTemplateId">
        /// The id of the base template.
        /// </param>
        /// <param name="templateId">
        /// The id of the template.
        /// </param>
        /// <param name="deploymentId">
        /// The id of the deployment.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Group> CreateInternalTemplateGroupAsync(
            global::System.Collections.Generic.IList<string> agentIds,
            string description,
            string baseTemplateId,
            string templateId,
            string deploymentId,
            global::G.ManagerConfig3? managerConfig = default,
            string? projectId = default,
            bool? hidden = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}