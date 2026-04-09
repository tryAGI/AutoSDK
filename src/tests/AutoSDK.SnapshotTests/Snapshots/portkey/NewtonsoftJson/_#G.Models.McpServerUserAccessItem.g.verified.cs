//HintName: G.Models.McpServerUserAccessItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerUserAccessItem
    {
        /// <summary>
        /// Global user ID or user_org_map_id depending on auth
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_override")]
        public bool? HasOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connection_status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.McpServerUserAccessItemConnectionStatusJsonConverter))]
        public global::G.McpServerUserAccessItemConnectionStatus? ConnectionStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerUserAccessItem" /> class.
        /// </summary>
        /// <param name="userId">
        /// Global user ID or user_org_map_id depending on auth
        /// </param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="enabled"></param>
        /// <param name="hasOverride"></param>
        /// <param name="connectionStatus"></param>
        public McpServerUserAccessItem(
            string? userId,
            string? firstName,
            string? lastName,
            bool? enabled,
            bool? hasOverride,
            global::G.McpServerUserAccessItemConnectionStatus? connectionStatus)
        {
            this.UserId = userId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Enabled = enabled;
            this.HasOverride = hasOverride;
            this.ConnectionStatus = connectionStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerUserAccessItem" /> class.
        /// </summary>
        public McpServerUserAccessItem()
        {
        }
    }
}