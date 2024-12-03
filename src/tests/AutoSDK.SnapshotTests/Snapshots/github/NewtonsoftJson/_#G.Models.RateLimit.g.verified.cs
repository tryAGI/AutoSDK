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
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Limit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remaining", Required = global::Newtonsoft.Json.Required.Always)]
        public int Remaining { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reset", Required = global::Newtonsoft.Json.Required.Always)]
        public int Reset { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("used", Required = global::Newtonsoft.Json.Required.Always)]
        public int Used { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimit" /> class.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="remaining"></param>
        /// <param name="reset"></param>
        /// <param name="used"></param>
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