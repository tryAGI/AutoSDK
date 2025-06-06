﻿//HintName: G.Models.GetUserMembershipResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetUserMembershipResponse contains the user membership.
    /// </summary>
    public sealed partial class GetUserMembershipResponse
    {
        /// <summary>
        /// The requested user membership.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("membership")]
        public global::G.UserMembership? Membership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserMembershipResponse" /> class.
        /// </summary>
        /// <param name="membership">
        /// The requested user membership.<br/>
        /// Included only in responses
        /// </param>
        public GetUserMembershipResponse(
            global::G.UserMembership? membership)
        {
            this.Membership = membership;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserMembershipResponse" /> class.
        /// </summary>
        public GetUserMembershipResponse()
        {
        }
    }
}