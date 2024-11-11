//HintName: G.Models.Sharing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sharing contains the information to share a resource with other users.<br/>
    /// For more information, see [Share Pipelines](https://www.instill.tech/docs/vdp/share).
    /// </summary>
    public sealed partial class Sharing
    {
        /// <summary>
        /// Defines sharing rules for a set of user resource names.<br/>
        /// Each key in this object should contain a pattern that can be matched<br/>
        /// against user names.<br/>
        /// Each value is a user sharing configuration.<br/>
        /// **NOTE**: For now, the only accepted key is `*/*`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.Dictionary<string, global::G.SharingUser>? Users { get; set; }

        /// <summary>
        /// Defines the configuration to share a resource via link.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shareCode")]
        public global::G.ShareCode? ShareCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sharing" /> class.
        /// </summary>
        /// <param name="users">
        /// Defines sharing rules for a set of user resource names.<br/>
        /// Each key in this object should contain a pattern that can be matched<br/>
        /// against user names.<br/>
        /// Each value is a user sharing configuration.<br/>
        /// **NOTE**: For now, the only accepted key is `*/*`.
        /// </param>
        /// <param name="shareCode">
        /// Defines the configuration to share a resource via link.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Sharing(
            global::System.Collections.Generic.Dictionary<string, global::G.SharingUser>? users,
            global::G.ShareCode? shareCode)
        {
            this.Users = users;
            this.ShareCode = shareCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sharing" /> class.
        /// </summary>
        public Sharing()
        {
        }
    }
}