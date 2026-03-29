//HintName: G.IBlocksClient.CreateBlock.g.cs
#nullable enable

namespace G
{
    public partial interface IBlocksClient
    {
        /// <summary>
        /// Create Block
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BlockResponse> CreateBlockAsync(

            global::G.CreateBlock request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Block
        /// </summary>
        /// <param name="value">
        /// Value of the block.
        /// </param>
        /// <param name="limit">
        /// Character limit of the block.<br/>
        /// Default Value: 100000
        /// </param>
        /// <param name="projectId">
        /// The associated project id.
        /// </param>
        /// <param name="templateName">
        /// Name of the block if it is a template.
        /// </param>
        /// <param name="isTemplate">
        /// Default Value: false
        /// </param>
        /// <param name="templateId">
        /// The id of the template.
        /// </param>
        /// <param name="baseTemplateId">
        /// The base template id of the block.
        /// </param>
        /// <param name="deploymentId">
        /// The id of the deployment.
        /// </param>
        /// <param name="entityId">
        /// The id of the entity within the template.
        /// </param>
        /// <param name="preserveOnMigration">
        /// Preserve the block on template migration.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="label">
        /// Label of the block.
        /// </param>
        /// <param name="readOnly">
        /// Whether the agent has read-only access to the block.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="description">
        /// Description of the block.
        /// </param>
        /// <param name="metadata">
        /// Metadata of the block.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="hidden">
        /// If set to True, the block will be hidden.
        /// </param>
        /// <param name="tags">
        /// The tags to associate with the block.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BlockResponse> CreateBlockAsync(
            string value,
            string label,
            int? limit = default,
            string? projectId = default,
            string? templateName = default,
            bool? isTemplate = default,
            string? templateId = default,
            string? baseTemplateId = default,
            string? deploymentId = default,
            string? entityId = default,
            bool? preserveOnMigration = default,
            bool? readOnly = default,
            string? description = default,
            object? metadata = default,
            bool? hidden = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}