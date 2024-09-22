//HintName: G.Models.ListUserMembershipsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListUserMembershipsResponse contains a list of memberships.
    /// </summary>
    public sealed partial class ListUserMembershipsResponse
    {
        /// <summary>
        /// The user memberships, i.e., the organizations the user belongs to.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memberships")]
        public global::System.Collections.Generic.IList<global::G.UserMembership>? Memberships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}