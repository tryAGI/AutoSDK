//HintName: G.Models.PatchAuthenticatedUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAuthenticatedUserResponse
    {
        /// <summary>
        /// The updated user resource.<br/>
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
        /// Initializes a new instance of the <see cref="PatchAuthenticatedUserResponse" /> class.
        /// </summary>
        /// <param name="user">
        /// The updated user resource.<br/>
        /// Included only in responses
        /// </param>
        public PatchAuthenticatedUserResponse(
            global::G.AuthenticatedUser? user)
        {
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAuthenticatedUserResponse" /> class.
        /// </summary>
        public PatchAuthenticatedUserResponse()
        {
        }
    }
}