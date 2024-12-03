//HintName: G.Models.StartCommercialResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartCommercialResponseDataItem
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

        /// <summary>
        /// Initializes a new instance of the <see cref="StartCommercialResponseDataItem" /> class.
        /// </summary>
        /// <param name="length">
        /// The length of the commercial you requested. If you request a commercial that’s longer than 180 seconds, the API uses 180 seconds.
        /// </param>
        /// <param name="message">
        /// A message that indicates whether Twitch was able to serve an ad.
        /// </param>
        /// <param name="retryAfter">
        /// The number of seconds you must wait before running another commercial.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartCommercialResponseDataItem(
            int length,
            string message,
            int retryAfter)
        {
            this.Length = length;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RetryAfter = retryAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartCommercialResponseDataItem" /> class.
        /// </summary>
        public StartCommercialResponseDataItem()
        {
        }
    }
}