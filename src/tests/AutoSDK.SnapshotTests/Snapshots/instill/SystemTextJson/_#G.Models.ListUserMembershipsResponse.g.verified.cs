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
        /// The user memberships, i.e., the organizations the user belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memberships")]
        public global::System.Collections.Generic.IList<global::G.UserMembership>? Memberships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}