//HintName: G.IIntegrationsClient.CreateIntegrations.g.cs
#nullable enable

namespace G
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Create a Integration
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateIntegrationsResponse> CreateIntegrationsAsync(

            global::G.CreateIntegrationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Integration
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the integration<br/>
        /// Example: Production OpenAI
        /// </param>
        /// <param name="slug">
        /// URL-friendly identifier (auto-generated if not provided)<br/>
        /// Example: production-openai
        /// </param>
        /// <param name="aiProviderId">
        /// ID of the base AI provider<br/>
        /// Example: openai
        /// </param>
        /// <param name="key">
        /// API key for the provider (if required)<br/>
        /// Example: sk-...
        /// </param>
        /// <param name="description">
        /// Optional description of the integration<br/>
        /// Example: Production OpenAI integration for customer-facing applications
        /// </param>
        /// <param name="workspaceId">
        /// Workspace ID (for workspace-scoped integrations)<br/>
        /// Example: ws-my-team-1234
        /// </param>
        /// <param name="configurations">
        /// Provider-specific configuration object
        /// </param>
        /// <param name="createDefaultProvider">
        /// Whether to automatically create a default provider when creating a workspace-scoped integration. Defaults to true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="defaultProviderSlug">
        /// Custom slug for the auto-created default provider. Only applicable for workspace-scoped integrations. If the slug already exists in the workspace, the request will fail with a validation error.
        /// </param>
        /// <param name="secretMappings">
        /// Dynamically resolve secrets from secret references at runtime. Valid target_field values are "key" or "configurations.&lt;field&gt;" (e.g. "configurations.aws_secret_access_key", "configurations.azure_entra_client_secret"). Each target_field must be unique. When "key" is mapped, the key body field can be omitted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateIntegrationsResponse> CreateIntegrationsAsync(
            string name,
            string aiProviderId,
            string? slug = default,
            string? key = default,
            string? description = default,
            string? workspaceId = default,
            global::G.OneOf<global::G.OpenAIConfiguration, global::G.AzureOpenAIConfiguration, global::G.BedrockConfiguration, global::G.VertexAIConfiguration, global::G.AzureAIConfiguration, global::G.WorkersAIConfiguration, global::G.SageMakerConfiguration?, global::G.HuggingFaceConfiguration, global::G.CortexConfiguration, global::G.CustomHostConfiguration>? configurations = default,
            bool? createDefaultProvider = default,
            string? defaultProviderSlug = default,
            global::System.Collections.Generic.IList<global::G.SecretMapping>? secretMappings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}