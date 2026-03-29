//HintName: G.Models.CreateDeepgramCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDeepgramCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateDeepgramCredentialDTOProviderJsonConverter))]
        public global::G.CreateDeepgramCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// This can be used to point to an onprem Deepgram instance. Defaults to api.deepgram.com.
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
        /// Initializes a new instance of the <see cref="CreateDeepgramCredentialDTO" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="apiUrl">
        /// This can be used to point to an onprem Deepgram instance. Defaults to api.deepgram.com.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeepgramCredentialDTO(
            string apiKey,
            global::G.CreateDeepgramCredentialDTOProvider provider,
            string? apiUrl,
            string? name)
        {
            this.Provider = provider;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.ApiUrl = apiUrl;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeepgramCredentialDTO" /> class.
        /// </summary>
        public CreateDeepgramCredentialDTO()
        {
        }
    }
}