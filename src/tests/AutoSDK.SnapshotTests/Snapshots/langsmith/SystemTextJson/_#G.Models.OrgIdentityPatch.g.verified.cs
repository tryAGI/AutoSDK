//HintName: G.Models.OrgIdentityPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgIdentityPatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public global::System.Guid? RoleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgIdentityPatch" /> class.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="roleId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrgIdentityPatch(
            string? password,
            string? fullName,
            global::System.Guid? roleId)
        {
            this.Password = password;
            this.FullName = fullName;
            this.RoleId = roleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgIdentityPatch" /> class.
        /// </summary>
        public OrgIdentityPatch()
        {
        }
    }
}