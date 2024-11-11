//HintName: G.Models.UpdateNamespaceSecretResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateNamespaceSecretResponse contains the updated secret.
    /// </summary>
    public sealed partial class UpdateNamespaceSecretResponse
    {
        /// <summary>
        /// The updated secret resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public global::G.Secret? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNamespaceSecretResponse" /> class.
        /// </summary>
        /// <param name="secret">
        /// The updated secret resource.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateNamespaceSecretResponse(
            global::G.Secret? secret)
        {
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNamespaceSecretResponse" /> class.
        /// </summary>
        public UpdateNamespaceSecretResponse()
        {
        }
    }
}