//HintName: G.Models.GetUserMembershipResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetUserMembershipResponse contains the user membership.
    /// </summary>
    public sealed partial class GetUserMembershipResponse
    {
        /// <summary>
        /// A user membership defines the relationship between a user and an<br/>
        /// organization they belong to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("membership")]
        public global::G.UserMembership? Membership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}