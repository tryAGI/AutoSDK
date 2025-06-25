//HintName: G.Models.OrgsUpdateMembershipForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsUpdateMembershipForAuthenticatedUserRequest
    {
        /// <summary>
        /// The state that the membership should be in. Only `"active"` will be accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrgsUpdateMembershipForAuthenticatedUserRequestStateJsonConverter))]
        public global::G.OrgsUpdateMembershipForAuthenticatedUserRequestState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsUpdateMembershipForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="state">
        /// The state that the membership should be in. Only `"active"` will be accepted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsUpdateMembershipForAuthenticatedUserRequest(
            global::G.OrgsUpdateMembershipForAuthenticatedUserRequestState state)
        {
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsUpdateMembershipForAuthenticatedUserRequest" /> class.
        /// </summary>
        public OrgsUpdateMembershipForAuthenticatedUserRequest()
        {
        }
    }
}