//HintName: G.Models.AuthRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthRequest
    {
        /// <summary>
        /// Admin password provided when starting the Letta server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthRequest" /> class.
        /// </summary>
        /// <param name="password">
        /// Admin password provided when starting the Letta server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthRequest(
            string? password)
        {
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthRequest" /> class.
        /// </summary>
        public AuthRequest()
        {
        }
    }
}