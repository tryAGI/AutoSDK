//HintName: G.Models.UpdateOrganizationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateOrganizationResponse contains the updated organization.
    /// </summary>
    public sealed partial class UpdateOrganizationResponse
    {
        /// <summary>
        /// The organization resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationResponse" /> class.
        /// </summary>
        /// <param name="organization">
        /// The organization resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrganizationResponse(
            global::G.Organization? organization)
        {
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationResponse" /> class.
        /// </summary>
        public UpdateOrganizationResponse()
        {
        }
    }
}