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

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionSecretSecret" /> class.
        /// </summary>
        /// <param name="content">
        /// The raw secret that you use with JWT encoding.
        /// </param>
        /// <param name="activeAt">
        /// The UTC date and time (in RFC3339 format) that you may begin using this secret to sign a JWT.
        /// </param>
        /// <param name="expiresAt">
        /// The UTC date and time (in RFC3339 format) that you must stop using this secret to decode a JWT.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ExtensionSecretSecret(
            string content,
            global::System.DateTime activeAt,
            global::System.DateTime expiresAt)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ActiveAt = activeAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionSecretSecret" /> class.
        /// </summary>
        public ExtensionSecretSecret()
        {
        }
    }
}