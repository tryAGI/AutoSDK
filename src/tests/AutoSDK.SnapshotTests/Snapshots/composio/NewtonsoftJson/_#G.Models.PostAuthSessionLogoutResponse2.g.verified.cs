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
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Optional machine-readable error code for programmatic handling<br/>
        /// Example: AUTH_REQUIRED
        /// </summary>
        /// <example>AUTH_REQUIRED</example>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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