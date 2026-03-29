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
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpServerUserAccessUserAcces" /> class.
        /// </summary>
        /// <param name="userId">
        /// User ID (global user_id or user_org_map_id depending on API key)
        /// </param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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