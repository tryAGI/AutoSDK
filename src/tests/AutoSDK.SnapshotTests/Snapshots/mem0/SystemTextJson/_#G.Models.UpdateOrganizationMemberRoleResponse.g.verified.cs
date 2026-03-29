//HintName: G.Models.UpdateOrganizationMemberRoleResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateOrganizationMemberRoleResponse
    {
        /// <summary>
        /// Example: User role updated successfully
        /// </summary>
        /// <example>User role updated successfully</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationMemberRoleResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: User role updated successfully
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOrganizationMemberRoleResponse(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrganizationMemberRoleResponse" /> class.
        /// </summary>
        public UpdateOrganizationMemberRoleResponse()
        {
        }
    }
}