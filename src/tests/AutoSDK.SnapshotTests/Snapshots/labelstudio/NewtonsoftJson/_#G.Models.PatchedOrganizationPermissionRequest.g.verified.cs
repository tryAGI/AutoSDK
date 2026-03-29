//HintName: G.Models.PatchedOrganizationPermissionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedOrganizationPermissionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public string? Permission { get; set; }

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
        /// Initializes a new instance of the <see cref="PatchedOrganizationPermissionRequest" /> class.
        /// </summary>
        /// <param name="permission"></param>
        /// <param name="roles">
        /// Organization roles
        /// </param>
        public PatchedOrganizationPermissionRequest(
            string? permission,
            global::System.Collections.Generic.IList<global::G.Role9e7Enum>? roles)
        {
            this.Permission = permission;
            this.Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedOrganizationPermissionRequest" /> class.
        /// </summary>
        public PatchedOrganizationPermissionRequest()
        {
        }
    }
}