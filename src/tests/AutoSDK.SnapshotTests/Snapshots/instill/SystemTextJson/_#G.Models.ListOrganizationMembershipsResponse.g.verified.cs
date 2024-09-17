//HintName: G.Models.ListOrganizationMembershipsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListOrganizationMembershipsResponse contains a list of memberships.
    /// </summary>
    public sealed partial class ListOrganizationMembershipsResponse
    {
        /// <summary>
        /// The organization memberships, i.e., the users that belong to the<br/>
        /// organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memberships")]
        public global::System.Collections.Generic.IList<global::G.OrganizationMembership>? Memberships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}