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
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateDeepgramCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// This can be used to point to an onprem Deepgram instance. Defaults to api.deepgram.com.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiUrl")]
        public string? ApiUrl { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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