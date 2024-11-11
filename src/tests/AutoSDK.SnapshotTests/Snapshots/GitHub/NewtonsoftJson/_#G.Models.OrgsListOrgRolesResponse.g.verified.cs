//HintName: G.Models.OrgsListOrgRolesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsListOrgRolesResponse
    {
        /// <summary>
        /// The total number of organization roles available to the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The list of organization roles available to the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("roles")]
        public global::System.Collections.Generic.IList<global::G.OrganizationRole>? Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsListOrgRolesResponse" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// The total number of organization roles available to the organization.
        /// </param>
        /// <param name="roles">
        /// The list of organization roles available to the organization.
        /// </param>
        public OrgsListOrgRolesResponse(
            int? totalCount,
            global::System.Collections.Generic.IList<global::G.OrganizationRole>? roles)
        {
            this.TotalCount = totalCount;
            this.Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsListOrgRolesResponse" /> class.
        /// </summary>
        public OrgsListOrgRolesResponse()
        {
        }
    }
}