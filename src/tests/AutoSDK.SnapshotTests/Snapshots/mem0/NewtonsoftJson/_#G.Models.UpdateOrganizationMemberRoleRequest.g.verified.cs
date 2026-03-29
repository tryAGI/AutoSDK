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
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// New role of the member in the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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