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
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthSessionLogoutResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable result message of the logout operation<br/>
        /// Example: Logout successful
        /// </param>
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