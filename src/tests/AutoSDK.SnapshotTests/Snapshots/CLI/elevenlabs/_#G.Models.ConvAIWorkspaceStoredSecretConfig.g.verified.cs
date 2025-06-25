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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConvAIWorkspaceStoredSecretConfigTypeJsonConverter))]
        public global::G.ConvAIWorkspaceStoredSecretConfigType Type { get; set; }

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
        /// <param name="type"></param>
        /// <param name="secretId"></param>
        /// <param name="name"></param>
        /// <param name="usedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvAIWorkspaceStoredSecretConfig(
            string secretId,
            string name,
            global::G.ConvAIStoredSecretDependencies usedBy,
            global::G.ConvAIWorkspaceStoredSecretConfigType type)
        {
            this.SecretId = secretId ?? throw new global::System.ArgumentNullException(nameof(secretId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UsedBy = usedBy ?? throw new global::System.ArgumentNullException(nameof(usedBy));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIWorkspaceStoredSecretConfig" /> class.
        /// </summary>
        public ConvAIWorkspaceStoredSecretConfig()
        {
        }
    }
}