//HintName: G.IIntegrationsClient.PutIntegrationsBySlug.g.cs
#nullable enable

namespace G
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Update a Integration
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PutIntegrationsBySlugAsync(
            string slug,

            global::G.UpdateIntegrationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Integration
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="name">
        /// Human-readable name for the integration<br/>
        /// Example: Production OpenAI
        /// </param>
        /// <param name="key">
        /// API key for the provider (if required)<br/>
        /// Example: sk-...
        /// </param>
        /// <param name="description">
        /// Optional description of the integration<br/>
        /// Example: Production OpenAI integration for customer-facing applications
        /// </param>
        /// <param name="configurations">
        /// Provider-specific configuration object
        /// </param>
        /// <param name="secretMappings">
        /// Dynamically resolve secrets from secret references at runtime. Valid target_field values are "key" or "configurations.&lt;field&gt;" (e.g. "configurations.aws_secret_access_key", "configurations.azure_entra_client_secret"). Each target_field must be unique.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PutIntegrationsBySlugAsync(
            string slug,
            string? name = default,
            string? key = default,
            string? description = default,
            global::G.OneOf<global::G.OpenAIConfiguration, global::G.AzureOpenAIConfiguration, global::G.BedrockConfiguration, global::G.VertexAIConfiguration, global::G.AzureAIConfiguration, global::G.WorkersAIConfiguration, global::G.SageMakerConfiguration?, global::G.HuggingFaceConfiguration, global::G.CortexConfiguration, global::G.CustomHostConfiguration>? configurations = default,
            global::System.Collections.Generic.IList<global::G.SecretMapping>? secretMappings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}