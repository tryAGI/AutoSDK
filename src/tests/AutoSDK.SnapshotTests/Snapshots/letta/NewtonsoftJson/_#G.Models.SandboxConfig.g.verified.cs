//HintName: G.Models.SandboxConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxConfig
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
        /// The human-friendly ID of the Sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of sandbox.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SandboxType? Type { get; set; }

        /// <summary>
        /// The JSON sandbox settings data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxConfig" /> class.
        /// </summary>
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
        /// The human-friendly ID of the Sandbox
        /// </param>
        /// <param name="type">
        /// The type of sandbox.
        /// </param>
        /// <param name="config">
        /// The JSON sandbox settings data.
        /// </param>
        public SandboxConfig(
            string? createdById,
            string? lastUpdatedById,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? id,
            global::G.SandboxType? type,
            object? config)
        {
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Id = id;
            this.Type = type;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxConfig" /> class.
        /// </summary>
        public SandboxConfig()
        {
        }
    }
}