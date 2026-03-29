//HintName: G.Models.UpdateLangfuseCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateLangfuseCredentialDTO
    {
        /// <summary>
        /// The public key for Langfuse project. Eg: pk-lf-...
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        public string? PublicKey { get; set; }

        /// <summary>
        /// The secret key for Langfuse project. Eg: sk-lf-... .This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// The host URL for Langfuse project. Eg: https://cloud.langfuse.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiUrl")]
        public string? ApiUrl { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLangfuseCredentialDTO" /> class.
        /// </summary>
        /// <param name="publicKey">
        /// The public key for Langfuse project. Eg: pk-lf-...
        /// </param>
        /// <param name="apiKey">
        /// The secret key for Langfuse project. Eg: sk-lf-... .This is not returned in the API.
        /// </param>
        /// <param name="apiUrl">
        /// The host URL for Langfuse project. Eg: https://cloud.langfuse.com
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateLangfuseCredentialDTO(
            string? publicKey,
            string? apiKey,
            string? apiUrl,
            string? name)
        {
            this.PublicKey = publicKey;
            this.ApiKey = apiKey;
            this.ApiUrl = apiUrl;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLangfuseCredentialDTO" /> class.
        /// </summary>
        public UpdateLangfuseCredentialDTO()
        {
        }
    }
}