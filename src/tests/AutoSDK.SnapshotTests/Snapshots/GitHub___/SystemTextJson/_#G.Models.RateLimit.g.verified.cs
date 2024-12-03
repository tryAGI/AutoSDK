//HintName: G.Models.RateLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Remaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Reset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Used { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimit" /> class.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="remaining"></param>
        /// <param name="reset"></param>
        /// <param name="used"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RateLimit(
            int limit,
            int remaining,
            int reset,
            int used)
        {
            this.Limit = limit;
            this.Remaining = remaining;
            this.Reset = reset;
            this.Used = used;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimit" /> class.
        /// </summary>
        public RateLimit()
        {
        }
    }
}