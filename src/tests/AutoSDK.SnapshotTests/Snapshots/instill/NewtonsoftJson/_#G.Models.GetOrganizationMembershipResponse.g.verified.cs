//HintName: G.Models.GetOrganizationMembershipResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// GetOrganizationMembershipResponse contains the organization membership.
    /// </summary>
    public sealed partial class GetOrganizationMembershipResponse
    {
        /// <summary>
        /// The requested organization membership.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("membership")]
        public global::G.AllOf<global::G.OrganizationMembership>? Membership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}