//HintName: G.Models.BulkUpdateMcpServerUserAccessUserAcces.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateMcpServerUserAccessUserAcces
    {
        /// <summary>
        /// User ID (global user_id or user_org_map_id depending on API key)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpServerUserAccessUserAcces" /> class.
        /// </summary>
        /// <param name="userId">
        /// User ID (global user_id or user_org_map_id depending on API key)
        /// </param>
        /// <param name="enabled"></param>
        public BulkUpdateMcpServerUserAccessUserAcces(
            string userId,
            bool enabled)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpServerUserAccessUserAcces" /> class.
        /// </summary>
        public BulkUpdateMcpServerUserAccessUserAcces()
        {
        }
    }
}