//HintName: G.Models.PostAuthSessionLogoutResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostAuthSessionLogoutResponse2
    {
        /// <summary>
        /// Human-readable description of the error that occurred<br/>
        /// Example: Authentication required
        /// </summary>
        /// <example>Authentication required</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Optional machine-readable error code for programmatic handling<br/>
        /// Example: AUTH_REQUIRED
        /// </summary>
        /// <example>AUTH_REQUIRED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthSessionLogoutResponse2" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable description of the error that occurred<br/>
        /// Example: Authentication required
        /// </param>
        /// <param name="code">
        /// Optional machine-readable error code for programmatic handling<br/>
        /// Example: AUTH_REQUIRED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostAuthSessionLogoutResponse2(
            string message,
            string? code)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthSessionLogoutResponse2" /> class.
        /// </summary>
        public PostAuthSessionLogoutResponse2()
        {
        }
    }
}