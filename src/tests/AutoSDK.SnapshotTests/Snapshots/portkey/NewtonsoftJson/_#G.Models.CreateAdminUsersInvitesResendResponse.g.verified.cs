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
        [global::Newtonsoft.Json.JsonProperty("inviteLink")]
        public string? InviteLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminUsersInvitesResendResponse" /> class.
        /// </summary>
        /// <param name="inviteLink"></param>
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