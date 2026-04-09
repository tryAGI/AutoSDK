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
        [global::Newtonsoft.Json.JsonProperty("organization_role_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleTypeJsonConverter))]
        public global::G.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleType OrganizationRoleType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIUpdateOrganizationPeopleRequest" /> class.
        /// </summary>
        /// <param name="organizationRoleType"></param>
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