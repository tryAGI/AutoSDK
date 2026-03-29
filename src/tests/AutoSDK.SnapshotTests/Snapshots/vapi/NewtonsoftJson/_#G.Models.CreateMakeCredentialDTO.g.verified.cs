//HintName: G.Models.CreateMakeCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMakeCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateMakeCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// Team ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teamId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TeamId { get; set; } = default!;

        /// <summary>
        /// Region of your application. For example: eu1, eu2, us1, us2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        public string Region { get; set; } = default!;

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateMakeCredentialDTO" /> class.
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
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateMakeCredentialDTO(
            string teamId,
            string region,
            string apiKey,
            global::G.CreateMakeCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMakeCredentialDTO" /> class.
        /// </summary>
        public CreateMakeCredentialDTO()
        {
        }
    }
}