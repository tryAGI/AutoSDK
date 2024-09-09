//HintName: G.Models.ExtensionSecretSecret.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtensionSecretSecret
    {
        /// <summary>
        /// The raw secret that you use with JWT encoding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that you may begin using this secret to sign a JWT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ActiveAt { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that you must stop using this secret to decode a JWT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}