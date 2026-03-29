//HintName: G.Models.CreateMinimaxCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMinimaxCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateMinimaxCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// This is the Minimax Group ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groupId", Required = global::Newtonsoft.Json.Required.Always)]
        public string GroupId { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateMinimaxCredentialDTO" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="groupId">
        /// This is the Minimax Group ID.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateMinimaxCredentialDTO(
            string apiKey,
            string groupId,
            global::G.CreateMinimaxCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.GroupId = groupId ?? throw new global::System.ArgumentNullException(nameof(groupId));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMinimaxCredentialDTO" /> class.
        /// </summary>
        public CreateMinimaxCredentialDTO()
        {
        }
    }
}