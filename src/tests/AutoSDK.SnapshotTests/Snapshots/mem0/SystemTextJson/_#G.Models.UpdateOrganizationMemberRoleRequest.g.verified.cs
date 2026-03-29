//HintName: G.Models.UpdateOrganizationMemberRoleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateOrganizationMemberRoleRequest
    {
        /// <summary>
        /// Email of the member whose role is to be updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// New role of the member in the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationMemberRoleRequest" /> class.
        /// </summary>
        /// <param name="email">
        /// Email of the member whose role is to be updated.
        /// </param>
        /// <param name="role">
        /// New role of the member in the organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrganizationMemberRoleRequest(
            string email,
            string role)
        {
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationMemberRoleRequest" /> class.
        /// </summary>
        public UpdateOrganizationMemberRoleRequest()
        {
        }
    }
}