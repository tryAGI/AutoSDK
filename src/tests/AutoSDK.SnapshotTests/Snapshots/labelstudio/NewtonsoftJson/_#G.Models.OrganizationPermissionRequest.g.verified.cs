//HintName: G.Models.OrganizationPermissionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationPermissionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission", Required = global::Newtonsoft.Json.Required.Always)]
        public string Permission { get; set; } = default!;

        /// <summary>
        /// Organization roles
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("roles")]
        public global::System.Collections.Generic.IList<global::G.Role9e7Enum>? Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPermissionRequest" /> class.
        /// </summary>
        /// <param name="permission"></param>
        /// <param name="roles">
        /// Organization roles
        /// </param>
        public OrganizationPermissionRequest(
            string permission,
            global::System.Collections.Generic.IList<global::G.Role9e7Enum>? roles)
        {
            this.Permission = permission ?? throw new global::System.ArgumentNullException(nameof(permission));
            this.Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPermissionRequest" /> class.
        /// </summary>
        public OrganizationPermissionRequest()
        {
        }
    }
}