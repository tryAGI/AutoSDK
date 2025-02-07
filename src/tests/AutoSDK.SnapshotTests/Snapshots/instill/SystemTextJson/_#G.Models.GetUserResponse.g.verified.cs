//HintName: G.Models.GetUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetUserResponse contains the requested user.
    /// </summary>
    public sealed partial class GetUserResponse
    {
        /// <summary>
        /// The user resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.User? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserResponse" /> class.
        /// </summary>
        /// <param name="user">
        /// The user resource.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUserResponse(
            global::G.User? user)
        {
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserResponse" /> class.
        /// </summary>
        public GetUserResponse()
        {
        }
    }
}