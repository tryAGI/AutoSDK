//HintName: G.Models.SharingUsers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines sharing rules for a set of user resource names.<br/>
    /// Each key in this object should contain a pattern that can be matched<br/>
    /// against user names.<br/>
    /// Each value is a user sharing configuration.<br/>
    /// **NOTE**: For now, the only accepted key is `*/*`.
    /// </summary>
    public sealed partial class SharingUsers
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}