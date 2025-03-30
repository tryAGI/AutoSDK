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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ConvAIWorkspaceStoredSecretConfigType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SecretId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("used_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConvAIStoredSecretDependencies UsedBy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIWorkspaceStoredSecretConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="secretId"></param>
        /// <param name="name"></param>
        /// <param name="usedBy"></param>
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