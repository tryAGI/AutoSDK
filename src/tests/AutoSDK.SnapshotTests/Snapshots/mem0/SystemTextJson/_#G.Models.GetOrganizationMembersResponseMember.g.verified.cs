//HintName: G.Models.GetOrganizationMembersResponseMember.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationMembersResponseMember
    {
        /// <summary>
        /// Unique identifier of the member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Role of the member in the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationMembersResponseMember" /> class.
        /// </summary>
        /// <param name="userId">
        /// Unique identifier of the member.
        /// </param>
        /// <param name="role">
        /// Role of the member in the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationMembersResponseMember(
            string? userId,
            string? role)
        {
            this.UserId = userId;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationMembersResponseMember" /> class.
        /// </summary>
        public GetOrganizationMembersResponseMember()
        {
        }
    }
}