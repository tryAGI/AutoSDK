﻿//HintName: G.Models.GetAuthenticatedUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetAuthenticatedUserResponse contains the requested authenticated user.
    /// </summary>
    public sealed partial class GetAuthenticatedUserResponse
    {
        /// <summary>
        /// The authenticated user resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.AuthenticatedUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthenticatedUserResponse" /> class.
        /// </summary>
        /// <param name="user">
        /// The authenticated user resource.<br/>
        /// Included only in responses
        /// </param>
        public GetAuthenticatedUserResponse(
            global::G.AuthenticatedUser? user)
        {
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthenticatedUserResponse" /> class.
        /// </summary>
        public GetAuthenticatedUserResponse()
        {
        }
    }
}