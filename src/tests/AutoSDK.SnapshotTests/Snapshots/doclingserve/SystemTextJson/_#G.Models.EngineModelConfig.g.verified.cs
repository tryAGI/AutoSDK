//HintName: G.Models.EngineModelConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Engine-specific model configuration.<br/>
    /// Allows overriding model settings for specific engines.<br/>
    /// For example, MLX might use a different repo_id than Transformers.
    /// </summary>
    public sealed partial class EngineModelConfig
    {
        /// <summary>
        /// Override model repository ID for this engine
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_id")]
        public string? RepoId { get; set; }

        /// <summary>
        /// Override model revision for this engine
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public string? Revision { get; set; }

        /// <summary>
        /// Override torch dtype for this engine (e.g., 'bfloat16')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("torch_dtype")]
        public string? TorchDtype { get; set; }

        /// <summary>
        /// Additional engine-specific configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_config")]
        public object? ExtraConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EngineModelConfig" /> class.
        /// </summary>
        /// <param name="repoId">
        /// Override model repository ID for this engine
        /// </param>
        /// <param name="revision">
        /// Override model revision for this engine
        /// </param>
        /// <param name="torchDtype">
        /// Override torch dtype for this engine (e.g., 'bfloat16')
        /// </param>
        /// <param name="extraConfig">
        /// Additional engine-specific configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EngineModelConfig(
            string? repoId,
            string? revision,
            string? torchDtype,
            object? extraConfig)
        {
            this.RepoId = repoId;
            this.Revision = revision;
            this.TorchDtype = torchDtype;
            this.ExtraConfig = extraConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EngineModelConfig" /> class.
        /// </summary>
        public EngineModelConfig()
        {
        }
    }
}