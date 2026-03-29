//HintName: G.Models.IntegrationDetailResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationDetailResponseVariant2
    {
        /// <summary>
        /// Masked API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("masked_key")]
        public string? MaskedKey { get; set; }

        /// <summary>
        /// Provider-specific configuration object<br/>
        /// **⚠️ Security Note - Response Masking:**<br/>
        /// When retrieving integration details, sensitive fields are automatically masked:<br/>
        /// - Sensitive fields get a `masked_` prefix (e.g., `client_secret` → `masked_client_secret`)<br/>
        /// - Non-sensitive fields (IDs, URLs, regions, etc.) remain unchanged
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configurations")]
        public global::G.OneOf<global::G.OpenAIConfiguration, global::G.AzureOpenAIConfiguration, global::G.BedrockConfiguration, global::G.VertexAIConfiguration, global::G.AzureAIConfiguration, global::G.WorkersAIConfiguration, global::G.SageMakerConfiguration?, global::G.HuggingFaceConfiguration, global::G.CortexConfiguration, global::G.CustomHostConfiguration>? Configurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("global_workspace_access_settings")]
        public global::G.GlobalWorkspaceAccess? GlobalWorkspaceAccessSettings { get; set; }

        /// <summary>
        /// Whether new models will be enabled by default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_all_models")]
        public bool? AllowAllModels { get; set; }

        /// <summary>
        /// Number of workspaces with access to this integration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_count")]
        public int? WorkspaceCount { get; set; }

        /// <summary>
        /// Secret reference mappings for this integration. Valid target_field values are "key" or "configurations.&lt;field&gt;".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_mappings")]
        public global::System.Collections.Generic.IList<global::G.SecretMapping>? SecretMappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationDetailResponseVariant2" /> class.
        /// </summary>
        /// <param name="maskedKey">
        /// Masked API key
        /// </param>
        /// <param name="configurations">
        /// Provider-specific configuration object<br/>
        /// **⚠️ Security Note - Response Masking:**<br/>
        /// When retrieving integration details, sensitive fields are automatically masked:<br/>
        /// - Sensitive fields get a `masked_` prefix (e.g., `client_secret` → `masked_client_secret`)<br/>
        /// - Non-sensitive fields (IDs, URLs, regions, etc.) remain unchanged
        /// </param>
        /// <param name="globalWorkspaceAccessSettings"></param>
        /// <param name="allowAllModels">
        /// Whether new models will be enabled by default
        /// </param>
        /// <param name="workspaceCount">
        /// Number of workspaces with access to this integration
        /// </param>
        /// <param name="secretMappings">
        /// Secret reference mappings for this integration. Valid target_field values are "key" or "configurations.&lt;field&gt;".
        /// </param>
        public IntegrationDetailResponseVariant2(
            string? maskedKey,
            global::G.OneOf<global::G.OpenAIConfiguration, global::G.AzureOpenAIConfiguration, global::G.BedrockConfiguration, global::G.VertexAIConfiguration, global::G.AzureAIConfiguration, global::G.WorkersAIConfiguration, global::G.SageMakerConfiguration?, global::G.HuggingFaceConfiguration, global::G.CortexConfiguration, global::G.CustomHostConfiguration>? configurations,
            global::G.GlobalWorkspaceAccess? globalWorkspaceAccessSettings,
            bool? allowAllModels,
            int? workspaceCount,
            global::System.Collections.Generic.IList<global::G.SecretMapping>? secretMappings)
        {
            this.MaskedKey = maskedKey;
            this.Configurations = configurations;
            this.GlobalWorkspaceAccessSettings = globalWorkspaceAccessSettings;
            this.AllowAllModels = allowAllModels;
            this.WorkspaceCount = workspaceCount;
            this.SecretMappings = secretMappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationDetailResponseVariant2" /> class.
        /// </summary>
        public IntegrationDetailResponseVariant2()
        {
        }
    }
}