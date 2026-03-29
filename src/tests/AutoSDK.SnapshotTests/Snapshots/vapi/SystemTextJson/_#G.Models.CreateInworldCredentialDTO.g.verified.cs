//HintName: G.Models.CreateInworldCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateInworldCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateInworldCredentialDTOProviderJsonConverter))]
        public global::G.CreateInworldCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is the Inworld Basic (Base64) authentication token. This is not returned in the API.<br/>
        /// Example: your-base64-token-here
        /// </summary>
        /// <example>your-base64-token-here</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateInworldCredentialDTO" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// This is the Inworld Basic (Base64) authentication token. This is not returned in the API.<br/>
        /// Example: your-base64-token-here
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInworldCredentialDTO(
            string apiKey,
            global::G.CreateInworldCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInworldCredentialDTO" /> class.
        /// </summary>
        public CreateInworldCredentialDTO()
        {
        }
    }
}