﻿//HintName: G.Models.RejectInvitationByCurrentUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RejectInvitationByCurrentUserRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invitationId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid InvitationId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectInvitationByCurrentUserRequest" /> class.
        /// </summary>
        /// <param name="invitationId"></param>
        public RejectInvitationByCurrentUserRequest(
            global::System.Guid invitationId)
        {
            this.InvitationId = invitationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectInvitationByCurrentUserRequest" /> class.
        /// </summary>
        public RejectInvitationByCurrentUserRequest()
        {
        }
    }
}