//HintName: G.Models.AcceptInvitationByCurrentUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AcceptInvitationByCurrentUserRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid InvitationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptInvitationByCurrentUserRequest" /> class.
        /// </summary>
        /// <param name="invitationId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptInvitationByCurrentUserRequest(
            global::System.Guid invitationId)
        {
            this.InvitationId = invitationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptInvitationByCurrentUserRequest" /> class.
        /// </summary>
        public AcceptInvitationByCurrentUserRequest()
        {
        }
    }
}