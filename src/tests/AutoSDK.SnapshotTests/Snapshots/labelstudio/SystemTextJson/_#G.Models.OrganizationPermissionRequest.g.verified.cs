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
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permission { get; set; }

        /// <summary>
        /// Organization roles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<global::G.Role9e7Enum>? Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPermissionRequest" /> class.
        /// </summary>
        /// <param name="permission"></param>
        /// <param name="roles">
        /// Organization roles
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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