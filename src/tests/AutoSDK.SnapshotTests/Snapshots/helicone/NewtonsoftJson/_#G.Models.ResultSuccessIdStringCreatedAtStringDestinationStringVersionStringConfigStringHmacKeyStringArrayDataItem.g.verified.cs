//HintName: G.Models.ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hmac_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string HmacKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public string Config { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination", Required = global::Newtonsoft.Json.Required.Always)]
        public string Destination { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem" /> class.
        /// </summary>
        /// <param name="hmacKey"></param>
        /// <param name="config"></param>
        /// <param name="version"></param>
        /// <param name="destination"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        public ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem(
            string hmacKey,
            string config,
            string version,
            string destination,
            string createdAt,
            string id)
        {
            this.HmacKey = hmacKey ?? throw new global::System.ArgumentNullException(nameof(hmacKey));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem" /> class.
        /// </summary>
        public ResultSuccessIdStringCreatedAtStringDestinationStringVersionStringConfigStringHmacKeyStringArrayDataItem()
        {
        }
    }
}