//HintName: G.Models.CreateIntegrationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateIntegrationRequest
    {
        /// <summary>
        /// Human-readable name for the integration<br/>
        /// Example: Production OpenAI
        /// </summary>
        /// <example>Production OpenAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL-friendly identifier (auto-generated if not provided)<br/>
        /// Example: production-openai
        /// </summary>
        /// <example>production-openai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// ID of the base AI provider<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AiProviderId { get; set; }

        /// <summary>
        /// API key for the provider (if required)<br/>
        /// Example: sk-...
        /// </summary>
        /// <example>sk-...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Optional description of the integration<br/>
        /// Example: Production OpenAI integration for customer-facing applications
        /// </summary>
        /// <example>Production OpenAI integration for customer-facing applications</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Workspace ID (for workspace-scoped integrations)<br/>
        /// Example: ws-my-team-1234
        /// </summary>
        /// <example>ws-my-team-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Provider-specific configuration object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.OpenAIConfiguration, global::G.AzureOpenAIConfiguration, global::G.BedrockConfiguration, global::G.VertexAIConfiguration, global::G.AzureAIConfiguration, global::G.WorkersAIConfiguration, global::G.SageMakerConfiguration?, global::G.HuggingFaceConfiguration, global::G.CortexConfiguration, global::G.CustomHostConfiguration>))]
        public global::G.OneOf<global::G.OpenAIConfiguration, global::G.AzureOpenAIConfiguration, global::G.BedrockConfiguration, global::G.VertexAIConfiguration, global::G.AzureAIConfiguration, global::G.WorkersAIConfiguration, global::G.SageMakerConfiguration?, global::G.HuggingFaceConfiguration, global::G.CortexConfiguration, global::G.CustomHostConfiguration>? Configurations { get; set; }

        /// <summary>
        /// Whether to automatically create a default provider when creating a workspace-scoped integration. Defaults to true.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_default_provider")]
        public bool? CreateDefaultProvider { get; set; }

        /// <summary>
        /// Custom slug for the auto-created default provider. Only applicable for workspace-scoped integrations. If the slug already exists in the workspace, the request will fail with a validation error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_provider_slug")]
        public string? DefaultProviderSlug { get; set; }

        /// <summary>
        /// Dynamically resolve secrets from secret references at runtime. Valid target_field values are "key" or "configurations.&lt;field&gt;" (e.g. "configurations.aws_secret_access_key", "configurations.azure_entra_client_secret"). Each target_field must be unique. When "key" is mapped, the key body field can be omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_mappings")]
        public global::System.Collections.Generic.IList<global::G.SecretMapping>? SecretMappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the integration<br/>
        /// Example: Production OpenAI
        /// </param>
        /// <param name="aiProviderId">
        /// ID of the base AI provider<br/>
        /// Example: openai
        /// </param>
        /// <param name="slug">
        /// URL-friendly identifier (auto-generated if not provided)<br/>
        /// Example: production-openai
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIntegrationRequest(
            string name,
            string aiProviderId,
            string? slug,
            string? key,
            string? description,
            string? workspaceId,
            global::G.OneOf<global::G.OpenAIConfiguration, global::G.AzureOpenAIConfiguration, global::G.BedrockConfiguration, global::G.VertexAIConfiguration, global::G.AzureAIConfiguration, global::G.WorkersAIConfiguration, global::G.SageMakerConfiguration?, global::G.HuggingFaceConfiguration, global::G.CortexConfiguration, global::G.CustomHostConfiguration>? configurations,
            bool? createDefaultProvider,
            string? defaultProviderSlug,
            global::System.Collections.Generic.IList<global::G.SecretMapping>? secretMappings)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug;
            this.AiProviderId = aiProviderId ?? throw new global::System.ArgumentNullException(nameof(aiProviderId));
            this.Key = key;
            this.Description = description;
            this.WorkspaceId = workspaceId;
            this.Configurations = configurations;
            this.CreateDefaultProvider = createDefaultProvider;
            this.DefaultProviderSlug = defaultProviderSlug;
            this.SecretMappings = secretMappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIntegrationRequest" /> class.
        /// </summary>
        public CreateIntegrationRequest()
        {
        }
    }
}