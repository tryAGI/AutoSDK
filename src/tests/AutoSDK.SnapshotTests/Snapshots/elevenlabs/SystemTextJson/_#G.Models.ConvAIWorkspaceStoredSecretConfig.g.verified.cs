//HintName: G.Models.ConvAIWorkspaceStoredSecretConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvAIWorkspaceStoredSecretConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"stored"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "stored";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConvAIStoredSecretDependencies UsedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIWorkspaceStoredSecretConfig" /> class.
        /// </summary>
        /// <param name="secretId"></param>
        /// <param name="name"></param>
        /// <param name="usedBy"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvAIWorkspaceStoredSecretConfig(
            string secretId,
            string name,
            global::G.ConvAIStoredSecretDependencies usedBy,
            string type = "stored")
        {
            this.Type = type;
            this.SecretId = secretId ?? throw new global::System.ArgumentNullException(nameof(secretId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UsedBy = usedBy ?? throw new global::System.ArgumentNullException(nameof(usedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIWorkspaceStoredSecretConfig" /> class.
        /// </summary>
        public ConvAIWorkspaceStoredSecretConfig()
        {
        }
    }
}