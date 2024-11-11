//HintName: G.Models.UpdateOrganizationMembershipResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateOrganizationMembershipResponse contains the updated membership.
    /// </summary>
    public sealed partial class UpdateOrganizationMembershipResponse
    {
        /// <summary>
        /// The updated membership resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membership")]
        public global::G.OrganizationMembership? Membership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationMembershipResponse" /> class.
        /// </summary>
        /// <param name="membership">
        /// The updated membership resource.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateOrganizationMembershipResponse(
            global::G.OrganizationMembership? membership)
        {
            this.Membership = membership;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationMembershipResponse" /> class.
        /// </summary>
        public UpdateOrganizationMembershipResponse()
        {
        }
    }
}