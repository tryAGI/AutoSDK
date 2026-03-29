//HintName: G.Models.SandboxEnvironmentVariable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxEnvironmentVariable
    {
        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// The timestamp when the object was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the object was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The human-friendly ID of the Sandbox-env
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the environment variable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The value of the environment variable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// An optional description of the environment variable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Encrypted value as Secret object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value_enc")]
        public string? ValueEnc { get; set; }

        /// <summary>
        /// The ID of the sandbox config this environment variable belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sandbox_config_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SandboxConfigId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxEnvironmentVariable" /> class.
        /// </summary>
        /// <param name="key">
        /// The name of the environment variable.
        /// </param>
        /// <param name="value">
        /// The value of the environment variable.
        /// </param>
        /// <param name="sandboxConfigId">
        /// The ID of the sandbox config this environment variable belongs to.
        /// </param>
        /// <param name="createdById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="lastUpdatedById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the object was created.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the object was last updated.
        /// </param>
        /// <param name="id">
        /// The human-friendly ID of the Sandbox-env
        /// </param>
        /// <param name="description">
        /// An optional description of the environment variable.
        /// </param>
        /// <param name="valueEnc">
        /// Encrypted value as Secret object
        /// </param>
        public SandboxEnvironmentVariable(
            string key,
            string value,
            string sandboxConfigId,
            string? createdById,
            string? lastUpdatedById,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? id,
            string? description,
            string? valueEnc)
        {
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Id = id;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Description = description;
            this.ValueEnc = valueEnc;
            this.SandboxConfigId = sandboxConfigId ?? throw new global::System.ArgumentNullException(nameof(sandboxConfigId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxEnvironmentVariable" /> class.
        /// </summary>
        public SandboxEnvironmentVariable()
        {
        }
    }
}