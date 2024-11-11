//HintName: G.Models.CreateNamespaceSecretResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CreateNamespaceSecretResponse contains the created secret.
    /// </summary>
    public sealed partial class CreateNamespaceSecretResponse
    {
        /// <summary>
        /// The created secret resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public global::G.Secret? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespaceSecretResponse" /> class.
        /// </summary>
        /// <param name="secret">
        /// The created secret resource.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateNamespaceSecretResponse(
            global::G.Secret? secret)
        {
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespaceSecretResponse" /> class.
        /// </summary>
        public CreateNamespaceSecretResponse()
        {
        }
    }
}