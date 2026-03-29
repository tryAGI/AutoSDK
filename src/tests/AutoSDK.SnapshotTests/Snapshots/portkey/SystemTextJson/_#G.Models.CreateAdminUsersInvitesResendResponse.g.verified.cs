//HintName: G.Models.CreateAdminUsersInvitesResendResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAdminUsersInvitesResendResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inviteLink")]
        public string? InviteLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminUsersInvitesResendResponse" /> class.
        /// </summary>
        /// <param name="inviteLink"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAdminUsersInvitesResendResponse(
            string? inviteLink)
        {
            this.InviteLink = inviteLink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminUsersInvitesResendResponse" /> class.
        /// </summary>
        public CreateAdminUsersInvitesResendResponse()
        {
        }
    }
}