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
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Requests { get; set; }

        /// <summary>
        /// Rate limit interval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Interval { get; set; }

        /// <summary>
        /// Note about the rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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