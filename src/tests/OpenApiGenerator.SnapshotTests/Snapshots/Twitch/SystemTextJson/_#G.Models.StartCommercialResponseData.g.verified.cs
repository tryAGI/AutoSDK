//HintName: G.Models.StartCommercialResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartCommercialResponseData
    {
        /// <summary>
        /// The length of the commercial you requested. If you request a commercial that’s longer than 180 seconds, the API uses 180 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Length { get; set; }

        /// <summary>
        /// A message that indicates whether Twitch was able to serve an ad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The number of seconds you must wait before running another commercial.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_after")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RetryAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}