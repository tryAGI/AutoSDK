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
        [global::System.Text.Json.Serialization.JsonPropertyName("hmac_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HmacKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Destination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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