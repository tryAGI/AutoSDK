//HintName: G.Models.UpdateMakeCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMakeCredentialDTO
    {
        /// <summary>
        /// Team ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teamId")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Region of your application. For example: eu1, eu2, us1, us2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
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
        /// Initializes a new instance of the <see cref="UpdateMakeCredentialDTO" /> class.
        /// </summary>
        /// <param name="teamId">
        /// Team ID
        /// </param>
        /// <param name="region">
        /// Region of your application. For example: eu1, eu2, us1, us2
        /// </param>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public UpdateMakeCredentialDTO(
            string? teamId,
            string? region,
            string? apiKey,
            string? name)
        {
            this.TeamId = teamId;
            this.Region = region;
            this.ApiKey = apiKey;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMakeCredentialDTO" /> class.
        /// </summary>
        public UpdateMakeCredentialDTO()
        {
        }
    }
}