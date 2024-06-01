//HintName: G.Models.OrgsPatchCustomOrganizationRoleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsPatchCustomOrganizationRoleRequest
    {
        /// <summary>
        /// The name of the custom role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A short description about the intended usage of this role or what permissions it grants.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A list of additional permissions included in this role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::System.Collections.Generic.IList<string?>? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}