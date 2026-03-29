//HintName: G.Models.KeyGetResponsesContentApplicationJsonSchemaDataRateLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Legacy rate limit information about a key. Will always return -1.
    /// </summary>
    public sealed partial class KeyGetResponsesContentApplicationJsonSchemaDataRateLimit
    {
        /// <summary>
        /// Number of requests allowed per interval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests", Required = global::Newtonsoft.Json.Required.Always)]
        public double Requests { get; set; } = default!;

        /// <summary>
        /// Rate limit interval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval", Required = global::Newtonsoft.Json.Required.Always)]
        public string Interval { get; set; } = default!;

        /// <summary>
        /// Note about the rate limit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note", Required = global::Newtonsoft.Json.Required.Always)]
        public string Note { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyGetResponsesContentApplicationJsonSchemaDataRateLimit" /> class.
        /// </summary>
        /// <param name="requests">
        /// Number of requests allowed per interval
        /// </param>
        /// <param name="interval">
        /// Rate limit interval
        /// </param>
        /// <param name="note">
        /// Note about the rate limit
        /// </param>
        public KeyGetResponsesContentApplicationJsonSchemaDataRateLimit(
            double requests,
            string interval,
            string note)
        {
            this.Requests = requests;
            this.Interval = interval ?? throw new global::System.ArgumentNullException(nameof(interval));
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyGetResponsesContentApplicationJsonSchemaDataRateLimit" /> class.
        /// </summary>
        public KeyGetResponsesContentApplicationJsonSchemaDataRateLimit()
        {
        }
    }
}