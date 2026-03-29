//HintName: G.Models.UpdateInworldCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateInworldCredentialDTO
    {
        /// <summary>
        /// This is the Inworld Basic (Base64) authentication token. This is not returned in the API.<br/>
        /// Example: your-base64-token-here
        /// </summary>
        /// <example>your-base64-token-here</example>
        [global::Newtonsoft.Json.JsonProperty("apiKey")]
        public string? ApiKey { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateInworldCredentialDTO" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// This is the Inworld Basic (Base64) authentication token. This is not returned in the API.<br/>
        /// Example: your-base64-token-here
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public UpdateInworldCredentialDTO(
            string? apiKey,
            string? name)
        {
            this.ApiKey = apiKey;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInworldCredentialDTO" /> class.
        /// </summary>
        public UpdateInworldCredentialDTO()
        {
        }
    }
}