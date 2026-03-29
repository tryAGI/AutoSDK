//HintName: G.Models.VirtualKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VirtualKeys
    {
        /// <summary>
        /// Example: Open AI Workspace
        /// </summary>
        /// <example>Open AI Workspace</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: randomness
        /// </summary>
        /// <example>randomness</example>
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.VirtualKeysStatus? Status { get; set; }

        /// <summary>
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </summary>
        /// <example>{"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}</example>
        [global::Newtonsoft.Json.JsonProperty("usage_limits")]
        public global::G.UsageLimits? UsageLimits { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("reset_usage")]
        public double? ResetUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_config")]
        public object? ModelConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate_limits")]
        public global::System.Collections.Generic.IList<global::G.RateLimits>? RateLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Secret reference mappings for this virtual key. Valid target_field values are "key" or "model_config.&lt;field&gt;".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_mappings")]
        public global::System.Collections.Generic.IList<global::G.SecretMapping>? SecretMappings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.VirtualKeysObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualKeys" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: Open AI Workspace
        /// </param>
        /// <param name="note">
        /// Example: randomness
        /// </param>
        /// <param name="status"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="resetUsage">
        /// Example: 0
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="slug"></param>
        /// <param name="modelConfig"></param>
        /// <param name="rateLimits"></param>
        /// <param name="expiresAt"></param>
        /// <param name="secretMappings">
        /// Secret reference mappings for this virtual key. Valid target_field values are "key" or "model_config.&lt;field&gt;".
        /// </param>
        /// <param name="object"></param>
        public VirtualKeys(
            string? name,
            string? note,
            global::G.VirtualKeysStatus? status,
            global::G.UsageLimits? usageLimits,
            double? resetUsage,
            global::System.DateTime? createdAt,
            string? slug,
            object? modelConfig,
            global::System.Collections.Generic.IList<global::G.RateLimits>? rateLimits,
            global::System.DateTime? expiresAt,
            global::System.Collections.Generic.IList<global::G.SecretMapping>? secretMappings,
            global::G.VirtualKeysObject? @object)
        {
            this.Name = name;
            this.Note = note;
            this.Status = status;
            this.UsageLimits = usageLimits;
            this.ResetUsage = resetUsage;
            this.CreatedAt = createdAt;
            this.Slug = slug;
            this.ModelConfig = modelConfig;
            this.RateLimits = rateLimits;
            this.ExpiresAt = expiresAt;
            this.SecretMappings = secretMappings;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualKeys" /> class.
        /// </summary>
        public VirtualKeys()
        {
        }
    }
}