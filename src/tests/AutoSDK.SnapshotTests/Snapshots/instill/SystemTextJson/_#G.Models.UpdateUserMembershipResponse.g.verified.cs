//HintName: G.Models.UpdateUserMembershipResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateUserMembershipResponse contains the updated membership.
    /// </summary>
    public sealed partial class UpdateUserMembershipResponse
    {
        /// <summary>
        /// A user membership defines the relationship between a user and an<br/>
        /// organization they belong to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membership")]
        public global::G.UserMembership? Membership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}