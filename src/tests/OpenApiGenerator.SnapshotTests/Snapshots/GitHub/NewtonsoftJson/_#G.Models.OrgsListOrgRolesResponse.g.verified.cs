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
        public int TotalCount { get; set; }

        /// <summary>
        /// The list of organization roles available to the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("roles")]
        public global::System.Collections.Generic.IList<OrganizationRole>? Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}