//HintName: G.Models.UpdateDeepgramCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDeepgramCredentialDTO
    {
        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This can be used to point to an onprem Deepgram instance. Defaults to api.deepgram.com.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiUrl")]
        public string? ApiUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeepgramCredentialDTO" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        /// <param name="apiUrl">
        /// This can be used to point to an onprem Deepgram instance. Defaults to api.deepgram.com.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDeepgramCredentialDTO(
            string? apiKey,
            string? name,
            string? apiUrl)
        {
            this.ApiKey = apiKey;
            this.Name = name;
            this.ApiUrl = apiUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeepgramCredentialDTO" /> class.
        /// </summary>
        public UpdateDeepgramCredentialDTO()
        {
        }
    }
}