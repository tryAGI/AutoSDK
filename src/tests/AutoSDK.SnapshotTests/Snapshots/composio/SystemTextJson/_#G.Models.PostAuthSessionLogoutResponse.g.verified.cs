//HintName: G.Models.PostAuthSessionLogoutResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostAuthSessionLogoutResponse
    {
        /// <summary>
        /// Human-readable result message of the logout operation<br/>
        /// Example: Logout successful
        /// </summary>
        /// <example>Logout successful</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthSessionLogoutResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable result message of the logout operation<br/>
        /// Example: Logout successful
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostAuthSessionLogoutResponse(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthSessionLogoutResponse" /> class.
        /// </summary>
        public PostAuthSessionLogoutResponse()
        {
        }
    }
}