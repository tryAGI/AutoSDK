//HintName: G.Models.VertexAiServiceAccountAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Service account authentication for Vertex AI
    /// </summary>
    public sealed partial class VertexAiServiceAccountAuth
    {
        /// <summary>
        /// Must be "service_account" for service account authentication<br/>
        /// Default Value: service_account
        /// </summary>
        /// <default>"service_account"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "service_account";

        /// <summary>
        /// The service account JSON key file contents as a string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyJson { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexAiServiceAccountAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "service_account" for service account authentication<br/>
        /// Default Value: service_account
        /// </param>
        /// <param name="keyJson">
        /// The service account JSON key file contents as a string
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VertexAiServiceAccountAuth(
            string type,
            string keyJson)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.KeyJson = keyJson ?? throw new global::System.ArgumentNullException(nameof(keyJson));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexAiServiceAccountAuth" /> class.
        /// </summary>
        public VertexAiServiceAccountAuth()
        {
        }
    }
}