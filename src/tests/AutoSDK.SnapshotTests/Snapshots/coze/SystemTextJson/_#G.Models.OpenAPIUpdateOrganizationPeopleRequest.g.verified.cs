//HintName: G.Models.OpenAPIUpdateOrganizationPeopleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIUpdateOrganizationPeopleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_role_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType OrganizationRoleType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIUpdateOrganizationPeopleRequest" /> class.
        /// </summary>
        /// <param name="organizationRoleType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIUpdateOrganizationPeopleRequest(
            global::G.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType organizationRoleType)
        {
            this.OrganizationRoleType = organizationRoleType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIUpdateOrganizationPeopleRequest" /> class.
        /// </summary>
        public OpenAPIUpdateOrganizationPeopleRequest()
        {
        }
    }
}