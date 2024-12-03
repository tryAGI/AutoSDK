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
        [global::Newtonsoft.Json.JsonProperty("length", Required = global::Newtonsoft.Json.Required.Always)]
        public int Length { get; set; } = default!;

        /// <summary>
        /// A message that indicates whether Twitch was able to serve an ad.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The number of seconds you must wait before running another commercial.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retry_after", Required = global::Newtonsoft.Json.Required.Always)]
        public int RetryAfter { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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